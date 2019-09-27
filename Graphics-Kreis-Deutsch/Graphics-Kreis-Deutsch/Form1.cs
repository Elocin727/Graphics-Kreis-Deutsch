using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Kreis_Deutsch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            Pen circlePen = new Pen(Color.Black,5f);
            Rectangle rect = new Rectangle((this.ClientSize.Width/2-100), (this.ClientSize.Height/2-100), 200, 200);
            SolidBrush ellipseBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(ellipseBrush, rect);
            e.Graphics.DrawEllipse(circlePen, rect);
        }


        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
