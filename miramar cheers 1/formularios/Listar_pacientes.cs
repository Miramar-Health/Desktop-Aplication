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
    public partial class Listar_pacientes : Form
    {
        public Listar_pacientes()
        {
            InitializeComponent();
        }

        private void Listar_pacientes_Load(object sender, EventArgs e)
        {
            Paciente c = new Paciente();
            var dr = c.Listar_Pacientes();
            DataTable dt = new DataTable();
            dt.Load(c.Listar_Pacientes());
            dgvLista.DataSource = dt;
        }
    }
}
