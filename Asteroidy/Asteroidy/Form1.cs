using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroidy
{
    public partial class Form1 : Form
    {
        Graphics g;
      //  int? x1 = null, y1 = null;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int w = 0, h = 0;
       
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.Blue);
            Pen pen = new Pen(br, 5);
            Point[] points ={
                new Point((this.Width) / 2+w, (this.Height) / 2 - 30+h),
                new Point((this.Width) / 2-30+w, (this.Height) / 2 + 10+h),
                new Point((this.Width) / 2+30+w, (this.Height) / 2 + 10+h)
            };
            g.FillClosedCurve(br, points);
            SolidBrush aster = new SolidBrush(Color.Green);
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Rectangle rect = new Rectangle(r.Next(0, this.Width), r.Next(0, this.Height), 50, 50);

                g.FillEllipse(aster, rect);
            }
         //   g.FillRectangle(Brushes.Black, points[0], 20, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        int direction;
        //0 up
        //1 rigth up
        //2 right
        //3 right down
        //4 down
        //5 left down
        //6 left
        //7 left up
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == (char)Keys.Enter) {
                Pen mypen = new Pen(Color.Black, 5);
                g.DrawLine(mypen, new Point(this.Width / 2, this.Height / 2 - 30), 
                    new Point(this.Width / 2, this.Height / 2 - 30));
            }*/
            if (e.KeyChar == (char)Keys.Right) {
                if (direction == 7) direction = 0;
                direction++;
              //  e.Handled = true;
                if (w == 100 || h == 100)
                {
                    w -= 25;
                    h -= 25;

                }
                else
                {
                    //e.Handled = true;
                    w += 25;
                    h += 25;
                   
                }
                Refresh();
            }
            if (e.KeyChar == (char)Keys.Left)
                if (direction == 0) direction = 7;
            direction--;
            {
                if (w == 100 || h == 100)
                {
                    w += 25;
                    h += 25;
                }
                else
                {
                    w -= 25;
                    h -= 25;
                }
                Refresh();
            }

        }





        /*    private void Form1_MouseClick(object sender, MouseEventArgs e)
            {
                Pen p = new Pen(Color.Aqua, 3);
                Rectangle rect = new Rectangle(e.X, e.Y, 20, 30); 
                g.DrawEllipse(p, rect);
            }
            */
        /*  private void Form1_MouseMove(object sender, MouseEventArgs e)
          {
              Pen p = new Pen(Color.Aqua, 3);
              g.DrawLine(p, new Point(x1 ?? e.X, y1 ?? e.Y), new Point(e.X, e.Y));
              x1 = e.X;
              y1 = e.Y;
          }*/
    }
}
