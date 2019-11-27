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
using miramar_cheers_1.classes;

namespace miramar_cheers_1.formularios
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Splash splash = new Splash();
            splash.Show();
            this.Hide();
            MessageBox.Show("para sair do aplicativo deslogue-se da sua conta, caso o contrario sua conta permanecerá logada");
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

       

        

     
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.Exibir.Controls.Count > 0)
                this.Exibir.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Exibir.Controls.Add(fh);
            this.Exibir.Tag = fh;
            fh.Show();
           
        }

        

        private void btninicio_Click(object sender, EventArgs e)
        {
         
        }

        private void Btn_Pacientes_Click(object sender, EventArgs e)
        {
            panel_paciente.Visible = true;
        }

        private void Btn_Tecnicos_Click(object sender, EventArgs e)
        {
           panel_tecnico.Visible = true;
        }

        

        private void Paciente__Buscar_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Buscar_pacientes Frm2 = new Buscar_pacientes();
            Frm2.TopLevel = false;
            Frm2.AutoScroll = true;
            Exibir.Controls.Add(Frm2);
            Frm2.Show();
        }

        private void Paciente_lista_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Listar_pacientes Frm2 = new Listar_pacientes();
            Frm2.TopLevel = false;
            Frm2.AutoScroll = true;
            Exibir.Controls.Add(Frm2);
            Frm2.Show();
        }

        private void Tecnico_validar_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Validar_Tecnicos Frm2 = new Validar_Tecnicos();
            Frm2.TopLevel = false;
            Frm2.AutoScroll = true;
            Exibir.Controls.Add(Frm2);
            Frm2.Show();
        }

        private void Tecnico_lista_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Listar_tecnicos Frm2 = new Listar_tecnicos();
            Frm2.TopLevel = false;
            Frm2.AutoScroll = true;
            Exibir.Controls.Add(Frm2);
            Frm2.Show();
        }

        private void Btn_Perfil_Click(object sender, EventArgs e)
        {
            panel_meuPerfil.Visible = true;
        }

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Perfil Frm2 = new Perfil();
            Frm2.TopLevel = false;
            Frm2.AutoScroll = true;
            Exibir.Controls.Add(Frm2);
            Frm2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserLoginCache.Coren_Tecnico = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Btn_Pacientes_MouseHover(object sender, EventArgs e)
        {
            panel_paciente.Visible = true;
            panel_tecnico.Visible = false;
            panel_meuPerfil.Visible = false;
        }

        private void Btn_Tecnicos_MouseHover(object sender, EventArgs e)
        {
            panel_tecnico.Visible = true;
            panel_paciente.Visible = false;
            panel_meuPerfil.Visible = false;
        }

        private void Btn_Perfil_MouseHover(object sender, EventArgs e)
        {
            panel_meuPerfil.Visible = true;
            panel_tecnico.Visible = false;
            panel_paciente.Visible = false;

        }

        private void Exibir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
