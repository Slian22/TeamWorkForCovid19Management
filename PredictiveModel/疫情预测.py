import requests
import pandas as pd
import time
pd.set_option('max_rows',500)
headers = { 'user-agent': 'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36' }# 设置请求头，伪装为浏览器

url = 'https://c.m.163.com/ug/api/wuhan/app/data/list-total'
r = requests.get(url, headers=headers) # 使用requests发起请求
print(r.status_code)

def get_data(data,info_list):# 将提取数据的方法封装为函数
    info = pd.DataFrame(data)[info_list] # 主要信息
    today_data = pd.DataFrame(
        [i['today'] for i in data])  # 生成today的数据
    today_data.columns = ['today_'+i for i in today_data.columns] # 修改列名
    total_data = pd.DataFrame([i['total'] for i in data ])
    total_data.columns = ['total_'+i for i in total_data.columns]
    return pd.concat([info, total_data, today_data], axis=1)  # info、today和total横向合并最终得到汇总的数据

import json
data_json = json.loads(r.text)
data_json.keys()

data = data_json['data'] # 取出json中的数据
print(data.keys())

chinaDayList = data['chinaDayList']

print(chinaDayList[0])
alltime_China = get_data(chinaDayList,['date','lastUpdateTime'])
alltime_China.head()

def save_data(data,name): # 将保存数据的方法封装为函数
    file_name = name+'_'+time.strftime('%Y_%m_%d',time.localtime(time.time()))+'.csv'
    data.to_csv(file_name,index=None,encoding='utf_8_sig')
    print(file_name+' 保存成功！')
time.strftime('%Y_%m_%d',time.localtime(time.time()))

save_data(alltime_China,'alltime_China')


# 以上为爬虫，接下来为预测


import numpy as np
from matplotlib import pyplot as plt
import warnings
from scipy.optimize import leastsq
from matplotlib.pyplot import savefig


warnings.filterwarnings('ignore')
plt.style.use("seaborn")
plt.rc('font', family='SimHei', size=8)  # 显示中文
plt.rcParams['axes.unicode_minus'] = False  # 用来正常显示负号

China_data = pd.read_csv('alltime_China_2020_08_14.csv', encoding = 'gbk')# 读取文件
print(China_data .head())

plt.plot(China_data ['total_confirm'], label='累计确诊')# 绘图
plt.plot(China_data ['today_suspect'], label='今日疑似')
plt.plot(China_data ['total_dead'], label='累计死亡')
plt.plot(China_data ['total_heal'], label='累计治愈')
plt.legend(loc="best")
plt.xlabel('自2020-01-13之后天数')
plt.ylabel('人数')
plt.title("2019-nCoV疫情曲线")
savefig('2019-nCoV疫情曲线')
plt.show()

# Logistic模型预测累计新冠确诊趋势
def logistic_increase_function(p, t):
    K, a, b = p
    exp_value = np.exp(-a * (t - b))
    return K / (1 + exp_value)

def err_f(p, t, y):# 定义预测误差函数
    return logistic_increase_function(p, t) - y


logistic_p0 = [90000, 0.8, 20]  # 设置参数初始值，初始值只要不是太离谱，最终都会收敛
t = np.array([i + 1 for i in range(213)])

China_y = China_data['total_confirm'].values

logistic_params = leastsq(err_f, logistic_p0, args=(t, China_y))# 利用最小二乘法求解参数
China_p = logistic_params[0]

China_predict_data = logistic_increase_function(China_p, t)# 利用定义的逻辑斯蒂增长函数预测
print(China_predict_data)

China_e = China_y - China_predict_data# 预测的误差
print(China_e)

plt.scatter(China_y, China_e)# 绘制误差的散点图
plt.title("误差散点图")
savefig('2019-nCoV疫情误差散点图')
plt.show()


future_t = [i + 1 for i in range(0, 300)]# 预测中国疫情未来走势
China_future_fit = logistic_increase_function(China_p, future_t)
print(China_future_fit)

plt.scatter(t, China_y, label="实际确诊患者数量")# 绘图
plt.plot(future_t, China_future_fit, label="预测未来患者数量")
plt.xlabel('自2020-01-13之后天数')
plt.ylabel('新冠确诊人数')
plt.title("未来预测")
plt.legend(loc='best')
savefig('2019-nCoV疫情未来预测')
plt.show()

print("以下为从8月13号之后的30天内累积确诊人数预测")# 输出预测结果
future_p = [i + 1 for i in range(213, 233)]
future_fit = logistic_increase_function(China_p, future_p)
print(future_fit)

# LSTM模型预测每日确诊人数
import math
from keras.models import Sequential
from keras.layers import Dense
from keras.layers import LSTM
from sklearn.metrics import mean_squared_error
from keras.callbacks import ReduceLROnPlateau
from sklearn.preprocessing import MinMaxScaler

dataset = China_data['today_confirm'].values
plt.plot(dataset )# 绘图
plt.title("每日确诊")
plt.xlabel('自2020-01-13之后天数')
plt.ylabel('新冠确诊人数')
savefig('2019-nCoV疫情每日确诊')
plt.show()

m = np.argmax(dataset)# 找到异常值位置
dataset[m] = 0.5*(dataset[m-1]+dataset[m+1])# 平均插值
dataset_or = dataset

def create_dataset(dataset, look_back=1):# 为后续lstm的输入创建一个数据处理函数
    dataX, dataY = [], []
    for i in range(len(dataset)-look_back):
        a = dataset[i:(i+look_back), 0]
        dataX.append(a)
        dataY.append(dataset[i + look_back, 0])
    return np.array(dataX), np.array(dataY)

np.random.seed(7)# 设置随机种子，标准化数据
scaler = MinMaxScaler(feature_range=(0, 1))
dataset = scaler.fit_transform(dataset.reshape(-1,1))
train = dataset

look_back = 7# 设置时间滑窗，创建训练集
trainX, trainY = create_dataset(train, look_back)

trainX = np.reshape(trainX, (trainX.shape[0], 1, trainX.shape[1]))# 对训练集x做reshape

model = Sequential()# 搭建lstm网络
model.add(LSTM(20, input_shape=(1, look_back)))#输出节点为25，输入的每个样本长度为look_back
model.add(Dense(1))#添加一个全连接层，输出维度为1
model.compile(loss='mean_squared_error', optimizer='adam')#使用均方差做损失函数，优化器用adam
reduce_lr = ReduceLROnPlateau(monitor='val_loss', patience=10, mode='max')
model.fit(trainX, trainY, epochs=500, batch_size=1, verbose=2, callbacks=[reduce_lr])#训练模型，100epoch，批次为1，每一个epoch显示一次日志，学习率动态减小

trainPredict = model.predict(trainX)#预测训练集
def do_the_thing(old_list):# 将小于0的数变为0
    new_list = []
    for num in old_list:
        if num < 0:
             new_list.append(0)
        else:
            new_list.append(num)
    return new_list

trainPredict=do_the_thing(trainPredict)
# 预测后7天每日确诊人数
testx = [0.]*(7+look_back)
testx[0:look_back] = train[-look_back:]
testx = np.array(testx)
testx  = testx.astype('float64')
testPredict = [0]*7
for i in range(7):
    testxx = testx[-look_back:]
    testxx = np.reshape(testxx, (1, 1, look_back))
    testy = model.predict(testxx)
    testx[look_back+i] = testy
    testPredict[i] = testy
testPredict = np.array(testPredict)
testPredict = np.reshape(testPredict,(7,1))

trainPredict = np.array(trainPredict)
trainPredict = scaler.inverse_transform(trainPredict.reshape(-1,1))# 反标准化
trainY = scaler.inverse_transform([trainY])
testPredict = scaler.inverse_transform(testPredict)

trainScore = math.sqrt(mean_squared_error(trainY[0,:], trainPredict[:,0]))
print('Train Score: %.2f RMSE' % (trainScore))# 输出训练RMSE

trainPredictPlot = np.reshape(np.array([None]*(len(dataset)+7)),((len(dataset)+7),1))# 绘图
trainPredictPlot[look_back:len(trainPredict)+look_back, :] = trainPredict
testPredictPlot = np.reshape(np.array([None]*(len(dataset)+7)),((len(dataset)+7),1))
testPredictPlot[:, :] = np.nan
testPredictPlot[len(dataset):(len(dataset)+7), :] = testPredict
plt.plot(dataset_or,label='true')
plt.plot(trainPredictPlot,label='trainpredict')
plt.plot(testPredictPlot,label='testpredict')
plt.legend()
plt.title('每日确诊预测')
plt.xlabel('自2020-01-13之后天数')
plt.ylabel('新冠确诊人数')
savefig('2019-nCoV疫情每日确诊预测')
plt.show()