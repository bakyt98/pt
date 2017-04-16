using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public enum Shape { Pencil, Ellipse, Triangle, Line, Rectangle, None};
        Graphics g;
        bool mousedown;
        
        public Pen pen;
        int b;
        public GraphicsPath path;
        Color clr;
        Point init;
        public Shape shape;
        public Bitmap btm;
        float x1, y1;
        public Form1()
        {
            InitializeComponent();
            
            path = new GraphicsPath();
            mousedown = false;
            b = 1;
            clr= Color.Black;
            shape = Shape.Pencil;
            pen = new Pen(clr, b);
            init = new Point();
            
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            pictureBox1.Paint += pictureBox1_Paint;
        }
        

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Ellipse;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Rectangle;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr = Color.Red;
          
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            b = 5;
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG file|*.jpg|PNG files|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btm.Save(saveFileDialog1.FileName);
            }
        }
       

      

       

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Line;
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Pencil;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Triangle;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            init = e.Location;
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

            x1 = 0;
            y1 = 0;
            if (path != null)
                g.DrawPath(pen, path);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
                e.Graphics.DrawPath(pen, path);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            b = 3;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            b = 1;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr = Color.Blue;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clr = Color.Green;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr = Color.Black;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr = Color.Pink;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clr = Color.Purple;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            b = 7;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Graphics clear = pictureBox1.CreateGraphics();
            clear.Clear(Color.White);
            Graphics.FromImage(btm).Clear(Color.White);
                
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "JPG file|*.jpg|PNG files|*.png";
            if ( openFileDialog1.ShowDialog()==DialogResult.OK)
            btm = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            shape = Shape.None;
                g.FillPath(Brushes.Black, path);
                Region rg = new Region();
                g.FillRegion(Brushes.Red, rg);
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(clr, b);
            if (mousedown)
            {
                if (x1 == 0 && y1 == 0) {
                    x1 = init.X;
                    y1 = init.Y;
                }
                
                switch (shape)
                {
                    
                    case Shape.Line:
                        {
                            path.Reset();
                            path.AddLine(init, e.Location);
                            break;
                        }
                    case Shape.Rectangle:
                        {
                            int x = Math.Min(init.X, e.Location.X);
                            int y = Math.Min(init.Y, e.Location.Y);
                                
                            path.Reset();
                            path.AddRectangle(new Rectangle(x,y, Math.Abs(init.X - e.X), Math.Abs(init.Y - e.Y)));
                            
                            break;
                        }
                    case Shape.Pencil:
                        {
                           g.DrawLine(pen, x1, y1, e.X, e.Y);
                            x1 = e.X;
                            y1=e.Y;
                            break;
                        }
                    case Shape.Ellipse: {
                            int x = Math.Min(init.X, e.X);
                            int y = Math.Min(init.Y, e.Y);

                            path.Reset();
                            path.AddEllipse(new Rectangle(x, y, Math.Abs(init.X -e.X), Math.Abs(init.Y - e.Y)));
                            break;
                        }
                    case Shape.Triangle: {
                            path.Reset();
                            Point[] points = {
                                new Point(init.X, init.Y),
                                new Point(e.Location.X, e.Y),
                                new Point(e.X-2*(e.X-init.X), e.Y)
                            };
                            path.AddPolygon(points);
                           
                            break;
                        }

                }
                pictureBox1.Refresh();



            }
        }

        
            
        }
    }

