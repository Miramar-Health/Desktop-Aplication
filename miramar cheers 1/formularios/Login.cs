using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace miramar_cheers_1.formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Panel_Login.Visible = true;
            panel_Senha.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            Enfermeiro enfermeiro = new Enfermeiro();
            bool login = enfermeiro.Efetuar_Login(txt_login.Text, txt_senha.Text);
            if (login == true)
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario ou senha incorretos");
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
