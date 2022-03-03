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
    public partial class options : UserControl
    {
        public options()
        {
            InitializeComponent();
        }

        private void options_Load(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
                FrmInicial main = new FrmInicial();
            if(bunifuiOSSwitch1.Value == true)
            {
                main.TopMost = true;
            }
            else
            {
                main.TopMost = false;
            }
        }

        private void bunifuiOSSwitch1_CheckedChanged_1(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
             FrmInicial main = new FrmInicial();
            if(bunifuiOSSwitch1.Value == true)
            {
                main.TopMost = true;
                main.Show();
                
            }
            else
            {
                main.TopMost = false;
                main.Show();
                
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
