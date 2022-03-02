using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAZZIO
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void loaderimage_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (txtusername.Text=="a" && txtpassword.Text=="a")
             {
                new FrmInicial().Show();
                this.Hide();


             }

             else
             {
                MessageBox.Show("Username or Passowrd is incorrect");
                txtpassword.Clear();
             }
        }

        private void loader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loader_Load(object sender, EventArgs e)
        {
         
        }

        private void cbrememberme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/jrCh7ANX7g");
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaCirclePictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (gunaCheckBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtpassword.UseSystemPasswordChar = true;
            }





            }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
     
        }
    }
}
