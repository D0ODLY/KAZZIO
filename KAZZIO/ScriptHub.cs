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
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/x3fall3nangel/RobloxScript/main/Anime%20Battlegrounds%20X.lua");
            module.SendLuaScript(Script);
        }

        private void gunaButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton16_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
            module.SendLuaScript(Script);
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
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

        private void ScriptHub_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/Whybiee/Roblox-scripts/main/Anime%20Punching%20Simulator.lua");
            module.SendLuaScript(Script);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/fusiongreg/BoltsHubV5/main/BoltsHubV5");
            module.SendLuaScript(Script);
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/LeoKholYt/roblox/main/carcrushers2_lkhub.lua");
            module.SendLuaScript(Script);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/Pawel12d/hexagon/main/scripts/CounterBlox.lua");
            module.SendLuaScript(Script);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/wally-rblx/funky-friday-autoplay/main/main.lua");
            module.SendLuaScript(Script);
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
            module.SendLuaScript(Script);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
            module.SendLuaScript(Script);
        }

        private void ScriptHub_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ScriptHub_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/lel69/KAT/main/GUI");
            module.SendLuaScript(Script);
        }
    }
}
