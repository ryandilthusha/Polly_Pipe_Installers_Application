using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polly_Pipe
{
    public partial class Splash_Screen_Form : Form
    {
        int startpoint = 0;

        public Splash_Screen_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = startpoint;
            startpoint += 10;

            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();

                Login_Form obj = new Login_Form();
                this.Hide();
                obj.Show();
            }
        }

        private void Splash_Screen_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
