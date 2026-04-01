using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloInventario
{
    public partial class frmProyecto : Form
    {
        public frmProyecto()
        {
            InitializeComponent();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {
            maskedTxtEgreso.Enabled = true;
        }


        private void lblStockActual_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            maskedTxtIngreso.Enabled = true;
        }

        private void txtDecrip_TextChanged(object sender, EventArgs e)
        {
            listLista.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtDecrip.Enabled = true;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
        }
    }
}
