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
    public partial class Listar_tecnicos : Form
    {
        public Listar_tecnicos()
        {
            InitializeComponent();
        }

     
        private void Listar_tecnicos_Load(object sender, EventArgs e)
        {
            Tecnico c = new Tecnico();
            var dr = c.Listar_Tecnicos();
            DataTable dt = new DataTable();
            dt.Load(c.Listar_Tecnicos());
            dgvLista.DataSource = dt;

        }
    }
}
