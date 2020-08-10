using MyGDIFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueCast
{
    public partial class FrmNewsList : Form
    {
        public FrmNewsList()
        {
            InitializeComponent();
        }

        MyGDIFramework.GdiSystem GDI;

        private void FrmNewsList_Load(object sender, EventArgs e)
        {
            InitializeGdi();
            GDI = new GdiSystem(this);
            GDI.Graphics.Clear(backgroundColor);
            GDI.UpdateWindow();
            tblLiskContainer.MouseWheel += TblLiskContainer_MouseWheel;
        }

        private void TblLiskContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                velotery -=0.2f;
            }
            else if (e.Delta < 0)
            {
                velotery += 0.2f;
            }
        }



        #region InitializeGDI

        Color backgroundColor = Color.FromArgb(96, 0, 0, 0);
        Pen stdLine = new Pen(new SolidBrush(Color.White), 1f);
        Brush bgPaint = new SolidBrush(Color.FromArgb(96, 0, 0, 0));
        Brush fgPaint = Brushes.White;
        StringFormat alignLeft = new StringFormat(StringFormatFlags.NoWrap);
        StringFormat alignRight = new StringFormat(StringFormatFlags.NoWrap);
        Bitmap bg = Properties.Resources.bg_list;
        Bitmap bgItem = Properties.Resources.bg_news;

        Bitmap listSurface;
        Graphics listGraphics;

        void InitializeGdi()
        {
            alignLeft.LineAlignment = StringAlignment.Center;
            alignLeft.Alignment = StringAlignment.Near;
            alignRight.LineAlignment = StringAlignment.Center;
            alignRight.Alignment = StringAlignment.Far;

            listSurface = new Bitmap(tblLiskContainer.Width, tblLiskContainer.Height);
            listGraphics = Graphics.FromImage(listSurface);

            bg = new Bitmap(bg, Width, Height);
            bgItem = new Bitmap(bgItem, lblContent.Width, lblContent.Height);
        }

        #endregion

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            draw();
            GDI.UpdateWindow();
        }

        void draw() {
            Graphics g = GDI.Graphics;
            g.Clear(Color.Transparent);
            g.DrawImage(bg, 0, 0, Width, Height);
            DrawItem(listGraphics);
            g.DrawImage(listSurface, tblLiskContainer.Location);
            g.DrawString(lblInfoArea.Text, lblInfoArea.Font, fgPaint, InfoArea, alignRight);
        }

        private RectangleF infoArea = RectangleF.Empty;
        RectangleF InfoArea {
            get {
                if (RectangleF.Empty == infoArea) {
                    infoArea = new RectangleF(lblInfoArea.Left,lblInfoArea.Top,lblInfoArea.Width,lblInfoArea.Height);
                }
                return infoArea;
            }
        }

        float velotery = 0;
        /// <summary>
        /// 1 stands for an item.
        /// </summary>
        float position = 0;
        float maxPosition = 1;

        List<NewsItem> tickItems { get { return Form1.newsItems; } }

        Pen splitItem = new Pen(Color.FromArgb(64, 255, 255, 255), 1);

        Brush scrollbarBack = new SolidBrush(Color.FromArgb(48, 255, 255, 255));
        Brush scrollbarBar = new SolidBrush(Color.FromArgb(96, 255, 255, 255));

        int postDrag = 0;

        int postSwipe = 0;

        int postClickX = 0;
        int postClickY = 0;

        

        public void DrawItem(Graphics g)
        {
            g.Clear(Color.Transparent);
            if (null == tickItems) { return; }
            velotery *= 0.95f;
            position += velotery;
            float itemHeight = itemTemplate.Height;
            float panelHeight = tblLiskContainer.Height;
            float panelItems = panelHeight / itemHeight;
            maxPosition = Math.Max(0, (float)tickItems.Count - panelItems);

            if (panelItems >= tickItems.Count)
            {
                position = 0;
                velotery = 0;
            }
            else
            {
                if (position > maxPosition)
                {
                    position = maxPosition;
                    velotery = 0;
                }
                if (position < 0)
                {
                    position = 0;
                    velotery = 0;
                }

                float scrollBarX = Width - scrollBarArea.Width;
                float scrollBarY =0;
                float scrollBarW = scrollBarArea.Width;
                float scrollBarH = scrollBarArea.Height;

                
                float scrollBlockHeight = Math.Max(8f, scrollBarH / ((float)tickItems.Count) * panelItems);
                float scrollBlockPos = (scrollBarH - scrollBlockHeight) / maxPosition * position;
                g.FillRectangle(scrollbarBack, scrollBarX, scrollBarY, scrollBarW, Height);
                g.FillRectangle(scrollbarBar, scrollBarX, scrollBarY + scrollBlockPos, scrollBarW, scrollBlockHeight);

                if (postDrag != 0)
                {
                    position += maxPosition / (scrollBarH - scrollBlockHeight) * (postDrag);

                    postDrag = 0;
                }

                if (postSwipe != 0)
                {
                    if (panelLeftDown)
                    {
                        velotery = 0;
                    }
                    position += ((float)postSwipe / itemHeight);
                    postSwipe = 0;
                }


                if (position > maxPosition)
                {
                    position = maxPosition;
                }
                if (position < 0)
                {
                    position = 0;
                }
            }
            float itemBegin = (float)Math.Floor(position);
            float itemEnd = Math.Min((float)Math.Ceiling(position + panelItems), tickItems.Count - 1);
            for (float f = itemBegin; f <= itemEnd; f += 1)
            {
                float baseX = 0;
                float baseY = (f - position) * itemHeight;
                int itemId = (int)f;
                NewsItem ti = tickItems[itemId];

                
                RectangleF timeArea = new RectangleF(baseX +lblTime.Left, baseY + lblTime.Top, lblTime.Width, lblTime.Height);
                RectangleF titleArea = new RectangleF(baseX +lblContent.Left, baseY + lblContent.Top, lblContent.Width, lblContent.Height);

                g.DrawString(Utils.parstUnixTime(ti.pubDate).ToString("yyyy\\-MM\\-dd HH\\:mm\\:ss")+"  "+ti.provinceName, lblTime.Font, fgPaint, timeArea, alignLeft);
                g.DrawImage(bgItem, titleArea);
                g.DrawString(ti.title, lblTime.Font, fgPaint, titleArea, alignLeft);

                if (f != itemEnd)
                {
                    g.DrawLine(splitItem, 0, baseY + itemHeight, Width, baseY + itemHeight);
                }

                if (postClickX != 0 && postClickY != 0)
                {
                    if (titleArea.Contains(postClickX, postClickY) || timeArea.Contains(postClickX, postClickY)) {
                        postClickY = 0; postClickX = 0;
                        Visible = false;
                        new FrmNewsDialog(ti.title, ti.summary, ti.sourceUrl).ShowDialog();
                        Visible = true;
                    }
                }

                

            }
            postClickY = 0; postClickX = 0;
            
        }



        int dx = 0, dy = 0;
        private void scrollBarArea_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            beginDragY = e.Y;
        }
        int beginDragY;
        bool isDragging = false;
        private void scrollBarArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                dy = e.Y - beginDragY;
                postDrag += dy;
                beginDragY = e.Y;
            }
        }

        private void scrollBarArea_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void tblTaskContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lenLine(e.Location, panelDownPoint) < 3)
                {
                    postClickX =e.X;
                    postClickY = e.Y;
                }
                else
                {
                    velotery = ((float)deltaY) / 24;
                }
                panelLeftDown = false;
            }
        }


        int lenLine(Point p1, Point p2)
        {
            int x1 = p1.X, x2 = p2.X, y1 = p1.Y, y2 = p2.Y;
            return (int)Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }


        Point panelDownPoint = Point.Empty;

        bool panelLeftDown = false;

        int deltaY = 0;

        private void tblTaskContainer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelDownPoint = e.Location;
                panelLastPoint = e.Location;
                panelLeftDown = true;
            }
        }


        Point panelLastPoint = Point.Empty;

        private void FrmNewsList_VisibleChanged(object sender, EventArgs e)
        {
            renderTimer.Enabled = this.Visible;
        }

        private void tblLiskContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblTaskContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (panelLeftDown)
            {
                postSwipe = -(e.Y - panelLastPoint.Y);
                deltaY = postSwipe;
                panelLastPoint = e.Location;
            }
            this.ActiveControl = tblLiskContainer;
        }
    }
}
