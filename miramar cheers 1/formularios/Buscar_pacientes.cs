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
    public partial class Buscar_pacientes : Form
    {
        public Buscar_pacientes()
        {
            InitializeComponent();
        }



        private void Buscar_pacientes_Load(object sender, EventArgs e)
        {
            prontuario.Enabled = false;
            prontuario.Visible = false;
            Paciente c = new Paciente();
            var dr = c.Listar_Pacientes();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvLista.DataSource = dt;
            dgvLista.Visible = true;
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txt_id_paciente.Text != string.Empty) {Paciente c = new Paciente();
            c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
            txt_nome_paciente.Text = c.Nome;
            txt_local_paciente.Text = c.Local_Ferida;
            txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
            txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
            txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
            panel_local_ferida.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txt_id_paciente.Text != string.Empty) {Paciente c = new Paciente();
            c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
            txt_nome_paciente.Text = c.Nome;
            txt_local_paciente.Text = c.Local_Ferida;
            txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
            txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
            txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
            panel_nome.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txt_id_paciente.Text != string.Empty) {Paciente c = new Paciente();
            c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
            txt_nome_paciente.Text = c.Nome;
            txt_local_paciente.Text = c.Local_Ferida;
            txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
            txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
            txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
            panel_descricao.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
             if (txt_id_paciente.Text != string.Empty) { Paciente c = new Paciente();
            c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
            txt_nome_paciente.Text = c.Nome;
            txt_local_paciente.Text = c.Local_Ferida;
            txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
            txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
            txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
            panel_data.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }

        }

        

        private void Btn_Pacientes_Click(object sender, EventArgs e)
        {
            Paciente c = new Paciente();
            if (txt_id_paciente.Text != string.Empty)
            {
                c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
                txt_nome_paciente.Text = c.Nome;
                txt_local_paciente.Text = c.Local_Ferida;
                txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
                txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
                txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
                panel_local_ferida.Visible = true;
                panel_nome.Visible = true;
                panel_descricao.Visible = true;
                panel_data.Visible = true;
                panel_id_tecnico.Visible = true;
            }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (txt_id_paciente.Text != string.Empty) {Paciente c = new Paciente();
            c.Buscar_Paciente(int.Parse(txt_id_paciente.Text));
            txt_nome_paciente.Text = c.Nome;
            txt_local_paciente.Text = c.Local_Ferida;
            txt_descricao_paciente.Text = c.Descricao_Inicial_Ferida;
            txt_data_paciente.Text = Convert.ToString(c.Data_Cadastro);
            txt_id_tecnico.Text = Convert.ToString(c.Id_tecnico);
            panel_id_tecnico.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de paciente");
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Txt_Prontuario_Click(object sender, EventArgs e)
        {
            dgvLista.Enabled = false;
            dgvLista.Visible = false;
            prontuario.Enabled = true;
            prontuario.Visible = true;
            prontuario.Image = miramar_cheers_1.Properties.Resources.logo_tipo1;

        }

        private void Lista_Click(object sender, EventArgs e)
        {
            prontuario.Enabled = false;
            prontuario.Visible = false;
            dgvLista.Visible = true;
        }
    }
}
