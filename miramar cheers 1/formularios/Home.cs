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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            FrmLogin login = new FrmLogin();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
        }

        private void ValidarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Validar_Tecnicos frm = new Validar_Tecnicos();
            frm.TopLevel = false;
            Exibir.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void ListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Listar_tecnicos frm = new Listar_tecnicos();
            frm.TopLevel = false;
            Exibir.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Buscar_pacientes frm = new Buscar_pacientes();
            frm.TopLevel = false;
            Exibir.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void ListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Listar_pacientes frm = new Listar_pacientes();
            frm.TopLevel = false;
            Exibir.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void MeuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibir.Controls.Clear();
            Perfil frm = new Perfil();
            frm.TopLevel = false;
            Exibir.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
    }
}
