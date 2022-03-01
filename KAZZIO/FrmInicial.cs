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
using WeAreDevs_API;

namespace KAZZIO
{
    public partial class FrmInicial : Form
    {
        ExploitAPI module = new ExploitAPI();
        public static class globals
        {
            public static bool injected = false;
        }
        public FrmInicial()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void gunaButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.fastColoredTextBox1.Clear();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            ScriptHub openform = new ScriptHub();
            openform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "C:/Scripts/", "*.txt");
            Functions.PopulateListBox(listBox1, "C:/Scripts/", "*.lua");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
            globals.injected = true;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            if (globals.injected)
            {
#pragma warning disable CS0618 // Type or member is obsolete
                module.SendLimitedLuaScript(fastColoredTextBox1.Text);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            else
            {
                MessageBox.Show("You have to inject first!","Executor not injected...",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText ($"C:/Scripts/{listBox1.SelectedItem}");
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "C:/Scripts/", "*.txt");
            Functions.PopulateListBox(listBox1, "C:/Scripts/", "*.lua");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            options openform = new options();
            openform.Show();
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            info openform = new info();
            openform.Show();
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3XABg3bsaB");
        }
    }
}
