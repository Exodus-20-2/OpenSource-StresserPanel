using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePanel
{
    public partial class Login : Form
    {
        
        public Login()
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            MainHub main = new MainHub();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
