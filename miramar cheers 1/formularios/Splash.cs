using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miramar_cheers_1.classes;

namespace miramar_cheers_1.formularios
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            desaparece();
        }



        void desaparece()
        {
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
            Opacity = 1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;
            if (ativo)
            {
                Opacity -= 0.01D;
            }
            if (Opacity == 0)
            {
                ativo = false;
                timer1.Enabled = false;
                if(UserLoginCache.Coren_Tecnico != null)
                {
                    Home home = new Home();
                    home.Show();
                    Hide();
                }
                else
                {
                    Login login = new Login();
                    login.Show();
                    Hide();
                }
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
