using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_aster
{
    public partial class Form1 : Form
    {
        Graphics g;
        PictureBox Korable;
        PictureBox[] Asters;
        bool isFired;
        PictureBox Bullet = new PictureBox();
        int direction;
        //0 up
        //1 right up
        //2 right
        //3 right down
        //4 down
        //5 left down
        //6 left
        //7 left up
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Korable = new PictureBox();
            Asters = new PictureBox[5];
            Bullet = new PictureBox();
            direction = 0;
            isFired = false;
            
            timer1.Start();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (isFired == false)
                {
                    timer2.Start();
                    Bullet_Move();

                }
                Bullet.Visible = true;
                isFired = true;
                
                
               
            }
            Korable = pictureBox1;
            if (e.KeyCode == Keys.Right) {

                switch (direction)
                {
                    case 0:
                        {
                            Korable.Load(@"Korableupright.jpg");
                            direction++;
                            break;
                        }
                    case 1:
                        {
                            Korable.Load(@"Korableright.jpg");
                            direction++;
                            break;
                        }
                    case 2:
                        {
                            Korable.Load(@"Korabledownright.jpg");
                            direction++;
                            break;
                        }
                    case 3:
                        {
                            Korable.Load(@"Korabledown.jpg");
                            direction++;
                            break;
                        }
                    case 4:
                        {
                            Korable.Load(@"Korabledownleft.jpg");
                            direction++;
                            break;
                        }
                    case 5:
                        {
                            Korable.Load(@"Korableleft.jpg");
                            direction++;
                            break;
                        }
                    case 6:
                        {
                            Korable.Load(@"Korableupleft.jpg");
                            direction++;
                            break;
                        }
                    case 7:
                        {
                            Korable.Load(@"Korable.jpg");
                            direction = 0 ;
                            break;
                        }
                }
                
                
            }
            if (e.KeyCode == Keys.Left)
            {

                switch (direction)
                {
                    case 0:
                        {
                            Korable.Load(@"Korableupleft.jpg");
                            direction=7;
                            break;
                        }
                    case 1:
                        {
                            Korable.Load(@"Korable.jpg");
                            direction--;
                            break;
                        }
                    case 2:
                        {
                            Korable.Load(@"Korableupright.jpg");
                            direction--;
                            break;
                        }
                    case 3:
                        {
                            Korable.Load(@"Korableright.jpg");
                            direction--;
                            break;
                        }
                    case 4:
                        {
                            Korable.Load(@"Korabledownright.jpg");
                            direction--;
                            break;
                        }
                    case 5:
                        {
                            Korable.Load(@"Korabledown.jpg");
                            direction--;
                            break;
                        }
                    case 6:
                        {
                            Korable.Load(@"Korabledownleft.jpg");
                            direction--;
                            break;
                        }
                    case 7:
                        {
                            Korable.Load(@"Korableleft.jpg");
                            direction--;
                            break;
                        }
                }


            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i<5; i++)
            if (Asters[i].Bounds.IntersectsWith(Korable.Bounds))
            {
                    timer1.Stop();
                MessageBox.Show("GAME OVER");
                

                timer2.Stop();
            }
            Asters[0].Left -= 4;
            Asters[0].Top += 4;
            Asters[1].Left += 1;
            Asters[1].Top += 3;
            Asters[2].Left += 2;
            Asters[3].Top -= 1;
            Asters[4].Left -= 2;
            Asters[4].Top -= 2;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Asters_Move(sender,e);

            Bullet_Move();
           
        }
        private void Bullet_Move() {
            Bullet = pictureBox2;
           
            
            Bullet.Visible = false;

            switch (direction) {
                case 0: {
                        Bullet.Location = new Point(325, 185);
                        break;
                    }
                case 1: {
                        Bullet.Location = new Point(345, 206);
                        break;
                    }
                case 2:
                    {
                        Bullet.Location = new Point(345, 212);
                        break;
                    }
                case 3:
                    {
                        Bullet.Location = new Point(344, 235);
                        break;
                    }
                case 4:
                    {
                        Bullet.Location = new Point(325, 236);
                        break;
                    }
                case 5:
                    {
                        Bullet.Location = new Point(298, 224);
                        break;
                    }
                case 6:
                    {
                        Bullet.Location = new Point(296, 214);
                        break;
                    }
                case 7:
                    {
                        Bullet.Location = new Point(307, 186);
                        break;
                    }
            }
           


        }

        
        private void Asters_Move(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Asters[i] = new PictureBox();
                Asters[i].Image = Image.FromFile("aster.jpg");
                Asters[i].Size = new System.Drawing.Size(150, 80);
             
                Asters[i].Location = new Point(rnd.Next(this.Width), rnd.Next(this.Height));
                while ((Asters[i].Left < 0 || Asters[i].Left>this.Width) || (Asters[i].Top<0 && Asters[i].Top>this.Height)) {
                    Asters[i].Location = new Point(rnd.Next(this.Width), rnd.Next(this.Height));
                }
                Controls.Add(Asters[i]);
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Bullet.Left > this.Width || Bullet.Top < 0 || Bullet.Left<0 || Bullet.Top >this.Height)
            {
                timer2.Stop();
                isFired = false;

                
                Bullet.Visible = false;
            }
            for (int i = 0; i < 5; i++)
            {
                if (Bullet.Bounds.IntersectsWith(Asters[i].Bounds))
                {
                    Controls.Remove(Asters[i]);
                   
                    Bullet.Visible = false;
                    timer2.Stop();
                    isFired = false;
                }
                
            }
            switch (direction)
            {
                case 0:
                    {
                        
                        Bullet.Top -= 5;
                        break;
                    }
                case 1:
                    {
                        
                        Bullet.Left += 3;
                        Bullet.Top -= 2;
                        break;
                    }
                case 2:
                    {
                        Bullet.Left +=5;
                        break;
                    }
                case 3:
                    {
                        Bullet.Left += 3;
                        Bullet.Top += 2;
                        break;

                    }
                case 4:
                    {
                        Bullet.Top += 5;
                        break;
                    }
                case 5:
                    {
                        Bullet.Left -= 3;
                        Bullet.Top += 2;
                        break;
                    }
                case 6:
                    {
                        Bullet.Left -= 5;
                        break;
                    }
                case 7:
                    {
                        Bullet.Left -= 3;
                        Bullet.Top -= 2;
                        break;
                    }
            }
            
        }
    }
}
