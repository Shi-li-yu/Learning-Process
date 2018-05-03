using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 画图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random random = new Random();
        Color getRandomColor()
        {
            return Color.FromArgb(
                random.Next(200),
                random.Next(200),
                random.Next(200));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x0 = this.Width / 2;
            int y0 = this.Height / 2;
            for(int r=0;r<this.Height/2;r+=2)
            {
                g.DrawEllipse(
                    new Pen(getRandomColor(), 1),
                    x0 - r, y0 - r, r * 2, r * 2);
            }
            g.Dispose();
        }
    }
}
