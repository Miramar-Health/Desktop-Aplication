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
    public partial class Validar_Tecnicos : Form
    {
        public Validar_Tecnicos()
        {
            InitializeComponent();
        }


        private void Validar_Tecnicos_Load(object sender, EventArgs e)
        {
            Tecnico c = new Tecnico();
            var dr = c.Listar_Tecnicos();
            DataTable dt = new DataTable();
            dt.Load(c.Listar_Tecnicos());
            dgvLista.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty) { Tecnico c = new Tecnico();
            c.Buscar_Tecnico(int.Parse(txtId.Text));
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCoren.Text = c.Coren;
            checkSituacao.Checked = c.Situacao;
            panel_Nome.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty) {Tecnico c = new Tecnico();
            c.Buscar_Tecnico(int.Parse(txtId.Text));
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCoren.Text = c.Coren;
            checkSituacao.Checked = c.Situacao;
            panel_email.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty) {Tecnico c = new Tecnico();
            c.Buscar_Tecnico(int.Parse(txtId.Text));
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCoren.Text = c.Coren;
            checkSituacao.Checked = c.Situacao;
            panel_coren.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty) { Tecnico c = new Tecnico();
            c.Buscar_Tecnico(int.Parse(txtId.Text));
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCoren.Text = c.Coren;
            checkSituacao.Checked = c.Situacao;
            panel_situaça.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }

        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            if(txtId.Text != string.Empty) {Tecnico c = new Tecnico();
            c.Buscar_Tecnico(int.Parse(txtId.Text));
            txtNome.Text = c.Nome;
            txtEmail.Text = c.Email;
            txtCoren.Text = c.Coren;
            checkSituacao.Checked = c.Situacao;
            panel_Nome.Visible = true;
            panel_email.Visible = true;
            panel_coren.Visible = true;
            panel_situaça.Visible = true; }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }


        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {

            if (txtId.Text != String.Empty)
            {
                Tecnico c = new Tecnico();
                c.Id = int.Parse(txtId.Text);
                c.Situacao = checkSituacao.Checked;
                if (c.Validar_Tecnico())
                {
                    MessageBox.Show("Tecnico Validado com sucesso!", "DOS TITIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("insira um id de tecnico");
            }

        }
    }
}
