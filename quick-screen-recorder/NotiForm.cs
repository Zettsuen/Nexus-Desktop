using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_screen_recorder
{
    public partial class NotiForm : Form
    {
        public NotiForm(String missatge, Color bgColor)
        {
            InitializeComponent();
            FadeIn.Start();
            this.BackColor = bgColor;
            this.notificacio.Text = missatge;
        }

        private void NotiForm_Load(object sender, EventArgs e)
        {
            Top = 40;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            TopMost = true;
            timerTancarNoti.Start();
        }

        private void timerTancarNoti_Tick(object sender, EventArgs e)
        {
            
            
                timerTancarNoti.Stop();
            
            this.Close();
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1)
            {
                FadeIn.Stop();
            }
        }

        private void notificacio_Click(object sender, EventArgs e)
        {

        }

        private void timerTancarNoti_Tick_1(object sender, EventArgs e)
        {
            timerTancarNoti.Stop();

            this.Close();
        }
    }
}
