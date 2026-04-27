using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloInventario
{
    public partial class frmProyecto : Form
    {

        private List<Producto> productos = new List<Producto>();


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
           
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtDecrip_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {

        }

        private void listLista_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTxtEgreso_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTxtIngreso_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTxtPrecio_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void maskedTxtIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTxtIngreso_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTxtPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void maskedTxtEgreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();


            if (txtCode.Text == "")
                {
                MessageBox.Show("Ingrese el código", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCode.Focus();
                return;
                }
            if (txtNombre.Text == "")
              {
               MessageBox.Show("Ingrese el nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txtNombre.Focus();
                return;
              }
            if (txtDescripcion.Text == "")
                {
                 MessageBox.Show("Ingrese la descripción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 txtDescripcion.Focus();
                return;
            }
            if (maskedTxtIngreso.Text == "")
                {
                MessageBox.Show("Ingrese la cantidad de ingreso de stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTxtIngreso.Focus();
                return;
            }
            if (maskedTxtEgreso.Text == "")
                {
                 MessageBox.Show("Ingrese la cantidad de egreso de stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 maskedTxtEgreso.Focus();
                return;
            }
            if (maskedTxtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTxtPrecio.Focus();
                return;
            }
        p.Código = txtCode.Text;
        p.Nombre = txtNombre.Text;
        p.Descripción = txtDescripcion.Text;
        p.Categoria = cboCategoria.Text;

        int ingreso ;
            if (!int.TryParse(maskedTxtIngreso.Text, out ingreso))
                {
                    MessageBox.Show("Ingreso inválido");
                    return;
                }

        int egreso;
            if (!int.TryParse(maskedTxtEgreso.Text, out egreso))
            {
                MessageBox.Show("Egreso inválido");
                return;
            }

        int precio;
            if (!int.TryParse(maskedTxtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

        p.Stock = ingreso - egreso;
        p.Precio = precio;
        
        productos.Add(p);

        txtCode.Text = "";
        txtDescripcion.Text = "";
        txtNombre.Text = "";
        cboCategoria.Text = "";
        maskedTxtIngreso.Text = "";
        maskedTxtEgreso.Text = "";
        maskedTxtPrecio.Text = "";

            MessageBox.Show("Producto registrado con exito");
        }

        private void lblIndexIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gBoxInventario_Enter(object sender, EventArgs e)
        {

        }

        private void btnGrilla_Click(object sender, EventArgs e)
        {
            frmGrilla grilla = new frmGrilla(productos);
            grilla.ShowDialog();
        }
    }
}
