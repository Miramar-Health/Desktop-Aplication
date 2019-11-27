using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miramar_cheers_1.formularios
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            Enfermeiro enfermeiro = new Enfermeiro();
            enfermeiro.Buscar_enfermeiro();
            txt_nome.Text = enfermeiro.Nome;
            txt_email.Text = enfermeiro.Email;
            txt_coren.Text = enfermeiro.Coren;
            check_situacao.Checked = enfermeiro.Situacao;
            panel_Nome.Visible = true;
            panel_email.Visible = true;
            panel_coren.Visible = true;
            panel_situacao.Visible = true;
        }

      
        private void Btnproductos_Click(object sender, EventArgs e)
        {
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
