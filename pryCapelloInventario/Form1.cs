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
        private void CargarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvProductos.Columns["Código"].Width = 60;
            dgvProductos.Columns["Nombre"].Width = 90;
            dgvProductos.Columns["Descripción"].Width = 120;
            dgvProductos.Columns["Categoria"].Width = 90;
            dgvProductos.Columns["Stock"].Width = 60;
            dgvProductos.Columns["Precio"].Width = 70;
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
            if (txtDecripcion.Text == "")
                {
                 MessageBox.Show("Ingrese la descripción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 txtDecripcion.Focus();
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
        p.Descripción = txtDecripcion.Text;
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
        CargarGrilla();

        txtCode.Text = "";
        txtDecripcion.Text = "";
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            txtCode.Text = fila.Cells["Código"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDecripcion.Text = fila.Cells["Descripción"].Value.ToString();
            cboCategoria.Text = fila.Cells["Categoría"].Value.ToString();
            maskedTxtPrecio.Text = fila.Cells["Precio"].Value.ToString();
            lblStockActual.Text = fila.Cells["Stock"].Value.ToString();

            maskedTxtIngreso.Text = "";
            maskedTxtEgreso.Text = "";
        }
    }
}
