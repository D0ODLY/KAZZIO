using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace KAZZIO
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }

        private void gunaButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void options_Load(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {  
            if (bunifuToggleSwitch1.Value == true)
                TopMost = true;
            
            else
                TopMost = false;
        }

        private void gunaButton17_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        { 
            loader f1 = new loader();
            f1.Show();
        }
      }
    }
