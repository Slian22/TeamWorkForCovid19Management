using MyGDIFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueCast
{
    public partial class FrmNewsDialog : Form
    {
        public string title, content, link;

        public override bool Equals(object obj)
        {
            if (obj is FrmNewsDialog) {
                return (obj as FrmNewsDialog).title == this.title;
            }
            return false;
        }

        public FrmNewsDialog(string title, string content, string link)
        {
            this.title = title;
            this.content = content;
            this.link = link;
            InitializeComponent();
        }
        GdiSystem gdi;

        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(link);
                Process.Start("iexplore.exe", link);
                //Process.Start("explorer.exe",link);
                Close();
            }
            catch (Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewsDialog_Load(object sender, EventArgs e)
        {
            gdi = new GdiSystem(this);
            draw();
            gdi.UpdateWindow();
        }

        void draw() {
            Graphics g = gdi.Graphics;
            g.Clear(Color.Transparent);
            g.DrawImage(this.BackgroundImage, 0, 0, Width, Height);
            g.DrawString(title, lblTitle.Font, Brushes.White, new RectangleF(lblTitle.Left,lblTitle.Top,lblTitle.Width,lblTitle.Height));
            g.DrawString(content, lblDetail.Font, Brushes.White, new RectangleF(lblDetail.Left, lblDetail.Top, lblDetail.Width,lblDetail.Height));
            g.DrawString("详细", lblLink.Font, Brushes.White, lblLink.Left, lblLink.Top);
        }
    }
}
