using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class entername : Form
    {
        public entername()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tstname_TextChanged(object sender, EventArgs e)
        { 
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            // process of enter username and save the name with help of streamwriter in yhe file
            // Exceptional handling
            if (txtname.Text != "")
            {
                try
                {
                    var path = @"highest.txt";
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);

                    writer.Write(" " + txtname.Text);
                    writer.Close();

                }
                catch
                {
                    MessageBox.Show("AN UNEXPECTED ERROR OCCURED WHILE SAVING SCORE");
                }
                Form3 f3 = new Form3();
                Hide();
                f3.ShowDialog();
                Close();
                Form3 fm = new Form3();
                fm.Show();

            }
            else { MessageBox.Show("PLEASE ENTER YOUR NAME!"); }

          

        }
    }
}
