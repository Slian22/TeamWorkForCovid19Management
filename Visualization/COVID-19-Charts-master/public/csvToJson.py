import pandas as pd
import csv
import numpy as np
import json
import time
# df = pd.read_csv('DXYArea.csv')
csv_file = open('../DXYArea.csv', 'r', encoding='gbk', errors='ignore')
jsonfile = open('json_area.json','w')
df = pd.read_csv('../DXYArea.csv')
# print(df.head())
class ToJson:
    def to_area(self):
        by_area = open('by_area.json', 'w')
        records = []
        df_china = df[df['provinceName']=='中国']
        # print(df_china)
        for index, row in df_china.iterrows():
            # print(row)
            msg_dict = {
                "confirmedCount": row['province_confirmedCount'],
                "suspectedCount": row['province_suspectedCount'],
                "curedCount": row['province_curedCount'],
                "deadCount": row['province_deadCount'],
                "seriousCount": 0,
                "suspectedIncreased": 0,
                "confirmedIncreased": 0,
                "curedIncreased": 0,
                "deadIncreased": 0,
                "seriousIncreased": 0,
                "updateTime": row['updateTime'],
                "insickCount": int(row['province_confirmedCount'])-int(row['province_curedCount']),
                "lastUpdate": row['updateTime'],
                "updateDate": row['updateTime'],
                "seriousRate": "0.00",
                "seriousDayRate": "0.00",
                "suspectedDayProcessed": 0,
                "suspectedConfirmedCount": 0,
                "suspectedConfirmedRate": "0.00",
                "suspectedDayProcessedRate": "0.00",
                "suspectedDayConfirmedRate": "0.00"
            }
            records.append(msg_dict)
        area_dict = {
            "name": "全国",
            "enName": "Country",
            "provinceName": "全国",
            "lastUpdate": "2020-07-29T05:34:43.000Z",
            "records": records
        }
        # print(area_dict)
        area_list = []
        area_list.append(area_dict)
        by_area.write(json.dumps(area_list,ensure_ascii=True))
    def to_country(self):
        by_country = open('by_country.json','w')
        df_country = df[df['provinceName']==df['countryName']]
        # print(df_country.head())
        n = 1
        msg_list = []
        for index, row in df_country.iterrows():
            n += 1
            # print(row)
            msg_dict = {
                "name": row['countryName'],
                "enName": row['countryEnglishName'],
                "provinceName": row['provinceName'],
                "lastUpdate": row['updateTime'],
                "confirmedCount": row['province_confirmedCount'],
                "suspectedCount": row['province_suspectedCount'],
                "curedCount": row['province_curedCount'],
                "deadCount": row['province_deadCount'],
                "seriousCount": 0,
                "suspectedIncreased": 0,
                "confirmedIncreased": 0,
                "curedIncreased": 0,
                "deadIncreased": 0,
                "seriousIncreased": 0,
                "updateTime": row['updateTime'],
                "insickCount": int(row['province_confirmedCount'])-int(row['province_curedCount']),
                "updateDate": row['updateTime'],
                "seriousRate": "0.00",
                "seriousDayRate": "0.00",
                "suspectedAccum": 0,
                "curedRate": "0.00",
                "deadRate": "0.00",
                "seriousDeadRate": "0.00"
            }
            msg_list.append(msg_dict)
            if n == 1500:
                break
        by_country.write(json.dumps(msg_list,ensure_ascii=True))
    def to_date(self):
        by_date = open('by_date.json', 'w')
        # df_date = df[df['countryName'] != df['provinceName']]
        # df_china = df_date[df_date['countryName'] == '中国']
        df1 = df[df['countryName'] == "中国"]
        df_date = df1[df1['countryName'] != df1['provinceName']]
        records = []
        tt = ""
        pro_list = []
        for index, row in df_date.iterrows():
            if row['updateTime'] == tt:
                continue
            if row['provinceName'] in pro_list:
                continue
            pro_list.append(row['provinceName'])
            province_dict = {
                "name": row['provinceName'],
                "provinceName": row['provinceName'],
                "confirmedCount": row['province_confirmedCount'],
                "suspectedCount": row['province_suspectedCount'],
                "curedCount": row['province_curedCount'],
                "deadCount": row['province_deadCount'],
                "updateTime": row['updateTime'],
                "lastUpdate": row['updateTime'],
                "zipCode": row['province_zipCode'],
                "insickCount": int(row['province_confirmedCount'])-int(row['province_curedCount']),
                "confirmedIncreased": 0,
                "curedIncreased": 0,
                "deadIncreased": 0,
            }
            city_list = []
            df_city1 = df_date[df_date['provinceName'] == row['provinceName']]
            df_city = df_city1[df_city1['updateTime'] == row['updateTime']]
            # print(df_city)

            try:
                for index1, ro in df_city.iterrows():
                    msg={
                        "name": ro['cityName'],
                        "provinceName": row['provinceName'],
                        "confirmedCount": ro['city_confirmedCount'],
                        "curedCount": ro['city_curedCount'],
                        "deadCount": ro['city_deadCount'],
                        "updateTime": "2020-07-29T05:34:43.000Z",
                        "lastUpdate": row['updateTime'],
                        "zipCode": ro['city_zipCode'],
                        "suspectedCount": ro['city_suspectedCount'],
                        "insickCount": int(ro['city_confirmedCount'])-int(ro['city_curedCount']),
                        "confirmedIncreased": 0,
                        "curedIncreased": 0,
                        "deadIncreased": 0
                    }
                    print(ro['cityName'])

                    city_list.append(msg)

            except:
                continue

            tt = row['updateTime']

            province_dict.update({"cityList":city_list})
            records.append(province_dict)
        date_dict = {
            "day": "2020-07-29T05:34:43.000Z",
            "records": records,
            "confirmedIncreased": 0,
            "curedIncreased": 0,
            "deadIncreased": 0,
            "maxZeroIncrDays": 0
        }
        date_list = []
        date_list.append(date_dict)
        by_date.write(json.dumps(date_list,ensure_ascii=True))
    def to_increase(self):
        by_increase = open('by_increase.json', 'w')




sss = ToJson()
sss.to_area()
sss.to_country()
sss.to_date()

