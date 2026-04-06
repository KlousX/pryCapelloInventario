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

        //DECLARACION DE VARIABLES GLOBALES
        string varCodigo = "";
        string varNombre = "";
        string varDescrip = "";
        string varCategoria = "";
        int varIngreso = 0;
        int varEgreso = 0;
        int varPrecio = 0;
        int varStockActual = 0;

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
            
        }


        private void lblStockActual_Click(object sender, EventArgs e)
        {
           varStockActual = varIngreso - varEgreso;
           lblStockActual.Text = varStockActual.ToString();
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

        private void frmProyecto_Load(object sender, EventArgs e)
        {

        }

        private void listLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTxtIngreso.Enabled = true;
        }

        private void maskedTxtEgreso_TextChanged(object sender, EventArgs e)
        {
            maskedTxtPrecio.Enabled = true;
        }

        private void maskedTxtIngreso_TextChanged(object sender, EventArgs e)
        {
            maskedTxtEgreso.Enabled = true;
        }

        private void maskedTxtPrecio_TextChanged(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
        }

        private void maskedTxtIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTxtIngreso_TextChanged_1(object sender, EventArgs e)
        {
            maskedTxtEgreso.Enabled = true;

        }

        private void maskedTxtPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            btnRegistrar.Enabled = true;
        }

        private void maskedTxtEgreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTxtPrecio.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        { 

            varCodigo = txtCode.Text;
            varNombre = txtNombre.Text;
            varDescrip = txtDecrip.Text;
            varCategoria = listLista.Text;
            varIngreso = int.Parse(maskedTxtIngreso.Text);
            varEgreso = int.Parse(maskedTxtEgreso.Text);
            varPrecio = int.Parse(maskedTxtPrecio.Text);

            lblIndexCodigo.Text = varCodigo;
            lblIndexNombre.Text = varNombre;
            lblIndexDescrip.Text = varDescrip;
            lblIndexCategoria.Text = varCategoria;
            lblIndexIngreso.Text = varIngreso.ToString();
            lblIndexPrecio.Text = varPrecio.ToString();

            MessageBox.Show("Producto registrado con exito");
        }

        
    }
}
