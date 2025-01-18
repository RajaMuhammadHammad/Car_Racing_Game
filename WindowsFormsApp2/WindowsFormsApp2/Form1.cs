using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sound  
            SoundPlayer sp = new SoundPlayer(@"Gran Turismo - Honda-Acura Dealer Theme Remastered.wav");
            sp.Play();
            sp.PlayLooping();
        }



        private void btnplay_Click(object sender, EventArgs e)
        {
            // play button

            entername f4 = new entername();
            Hide();
            f4.ShowDialog();
            Close();

            entername fm = new entername();
            fm.Show();

           
        }

        private void btninstruction_Click(object sender, EventArgs e)
        {
            // instruction button

            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
            Close();
            Form2 fm = new Form2();
            fm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //exit of the game
        }

        private void btnPlaysound_Click(object sender, EventArgs e)
        {

            // symbol of play of sound

            SoundPlayer sp = new SoundPlayer(@"Gran Turismo - Honda-Acura Dealer Theme Remastered.wav");
            sp.Play();
            sp.PlayLooping();                                                     
            btnmute.Visible = true;
            btnPlaysound.Visible = false;
        }

        private void btnmute_Click(object sender, EventArgs e)
        {
            // symbol of mute of sound

            SoundPlayer sp = new SoundPlayer(@"Gran Turismo - Honda-Acura Dealer Theme Remastered.wav");
            sp.Play();
            sp.Stop();

            btnmute.Visible = false;
            btnPlaysound.Visible = true;
        }

        private void btnhighestscore_Click(object sender, EventArgs e)
        {
            // filling of highest score to show score by streamReader

            var path = @"highest.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader=new StreamReader(fs);
            string content = File.ReadAllText(path);
            MessageBox.Show(content);

        }
    }
}
