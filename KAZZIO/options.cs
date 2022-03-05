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
        public static options instance;
        public options()
        {
            InitializeComponent();
            instance = this;
        }

        private void options_Load(object sender, EventArgs e)
        {
            customization1.Hide();
            customization1.SendToBack();
        }

        private void bunifuiOSSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
        }

        private void bunifuiOSSwitch1_CheckedChanged_1(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            FrmInicial.instance.TopMost = bunifuiOSSwitch1.Value;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

            customization1.BringToFront();
            customization1.Show();
            gunaButton4.BringToFront();
            gunaButton3.BringToFront();
            gunaButton5.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaButton4.BringToFront();
            gunaButton5.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            customization1.Hide();
            customization1.SendToBack();
            gunaButton4.BringToFront();
            gunaButton3.BringToFront();
            gunaButton5.BringToFront();
        }
    }
}
