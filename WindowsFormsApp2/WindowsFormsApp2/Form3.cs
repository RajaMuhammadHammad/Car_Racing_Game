using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            label1Gameover.Visible = false;
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            Gameover();
            coin(gamespeed);
            collectioncoins();
        }
        int collectedcoins = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            //enemy details

            if (ENEMY1.Top >= 700)
            {
                x = r.Next(0, 200);

                ENEMY1.Location = new Point(x, 0);
            }
            else { ENEMY1.Top += speed; }

            if (ENEMY2.Top >= 700)
            {
                x = r.Next(0, 400);
                ENEMY2.Location = new Point(x, 0);
            }
            else { ENEMY2.Top += speed; }

            if (ENEMY3.Top >= 700)
            {
                x = r.Next(400, 500);
               ENEMY3.Location = new Point(x, 0);
            }
            else { ENEMY3.Top += speed; }

        
        }

        // coins details

        void coin(int speed)
        {
            if (coin1.Top >= 700)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 700)
            {
                x = r.Next(0, 300);

                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 700)
            {
                x = r.Next(0, 400);

                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 700)
            {
                x = r.Next(0, 500);

                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }

            if (coin5.Top >= 700)
            {
                x = r.Next(500, 600);

                coin5.Location = new Point(x, 0);
            }
            else { coin5.Top += speed; }
      
        }

        // game over sound
        //game over label

        void Gameover()
        {
            SoundPlayer gameover = new SoundPlayer(@"Game Over - Sound Effect [HD].wav ");

            if (car.Bounds.IntersectsWith(ENEMY1.Bounds))
            {
                timer1.Enabled = false;
                label1Gameover.Visible = true;
                btnRestart.Visible = true;
                quit.Visible = true;
                gameover.Play();
            }

            if (car.Bounds.IntersectsWith(ENEMY2.Bounds))
            {
                timer1.Enabled = false;
                label1Gameover.Visible = true;
                btnRestart.Visible = true;
                quit.Visible = true;
                gameover.Play();
            }

            if (car.Bounds.IntersectsWith(ENEMY3.Bounds))
            {
                timer1.Enabled = false;
                label1Gameover.Visible = true;
                btnRestart.Visible = true;
                quit.Visible = true;
                gameover.Play();

                
            }
        }

        // moving line behind the game as lanes

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 700)
            {
                pictureBox1.Top = 0;
            }
            else { pictureBox1.Top += speed; }
            if (pictureBox2.Top >= 700)
            {
                pictureBox2.Top = 0;
            }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 700)
            {
                pictureBox3.Top = 0;
            }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 700)
            {
                pictureBox4.Top = 0;
            }
            else { pictureBox4.Top += speed; }
            if (pictureBox5.Top >= 700)
            {
                pictureBox5.Top = 0;
            }
            else { pictureBox5.Top += speed; }
            if (pictureBox6.Top >= 700)
            {
                pictureBox6.Top = 0;
            }
            else { pictureBox6.Top += speed; }
            if (pictureBox7.Top >= 700)
            {
                pictureBox7.Top = 0;
            }
            else { pictureBox7.Top += speed; }
            if (pictureBox8.Top >= 700)
            {
                pictureBox8.Top = 0;
            }
            else { pictureBox8.Top += speed; }
            if (pictureBox9.Top >= 700)
            {
                pictureBox9.Top = 0;
            }
            else { pictureBox9.Top += speed; }
            if (pictureBox10.Top >= 700)
            {
                pictureBox10.Top = 0;
            }
            else { pictureBox10.Top += speed; }

        }

        // collecting of coins and to make score

        void collectioncoins ()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                lblScore.Text = " " + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                lblScore.Text = " " + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                lblScore.Text = " " + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin3.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                lblScore.Text = " " + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin4.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collectedcoins++;
                lblScore.Text = " " + collectedcoins.ToString();
                x = r.Next(0, 200);

                coin5.Location = new Point(x, 0);

               
            }
        }


        int gamespeed = 0;

        private void label1Gameover_Click(object sender, EventArgs e)
        {

        }

        // replay again button the after over of game 
        // writing the score in the file


        private void btnRestart_Click(object sender, EventArgs e)
        {
            var path = @"highest.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
         
            writer.Write("\nScore:" + lblScore.Text+"\n");
            writer.Close();
           
            entername f4 = new entername();
            Hide();
            f4.ShowDialog();
            Close();
            entername fm = new entername();
            fm.Show();
        }

        // going to home page

        private void pictureBox23_Click(object sender, EventArgs e)
        {


            var path = @"highest.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            writer.Write("\nScore:" + lblScore.Text + "\n");
            writer.Close();

            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
            Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            
         
        }

        // quit the game button
        // writing the score in the file

        private void quit_Click(object sender, EventArgs e)
        {
            var path = @"highest.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
         
            writer.Write("\tScore:" + lblScore.Text+"\n");
            writer.Close();
            
            this.Close();
        }



        private void Form3_Load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)                                   // left movement
                    car.Left += -50;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 580)                                // right movement
                    car.Left += 50;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 5)
                {
                    gamespeed++;                                    //game speed
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 3)
                {
                    gamespeed--;
                }
            }
        }
    }
}
