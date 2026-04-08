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
        string varDescripcion = "";
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

     
            if (txtCode.Text == "")
                {
                MessageBox.Show("Ingrese el código");
                txtCode.Focus();
                } 
                else {
                      if (txtNombre.Text == "")
                        {
                         MessageBox.Show("Ingrese el nombre");
                         txtNombre.Focus();
                        }
                        else {
                            if (txtDecripcion.Text == "")
                               {
                                MessageBox.Show("Ingrese la descripción");
                                txtDecripcion.Focus();
                               }
                            else { 
                                if (maskedTxtIngreso.Text == "")
                                    {
                                    MessageBox.Show("Ingrese la cantidad de ingreso de stock");
                                    maskedTxtIngreso.Focus();
                                    }
                                    else {
                                        if (maskedTxtEgreso.Text == "")
                                            {
                                             MessageBox.Show("Ingrese la cantidad de egreso de stock");
                                             maskedTxtEgreso.Focus();
                                            }
                                            else {
                                            if (maskedTxtPrecio.Text == "")
                                            {
                                                MessageBox.Show("Ingrese el precio");
                                                maskedTxtPrecio.Focus();
                                            }
                                            else {

                                                    varCodigo = txtCode.Text;
                                                    varNombre = txtNombre.Text;
                                                    varDescripcion = txtDecripcion.Text;
                                                    varCategoria = cboCategoria.Text;
                                                    varIngreso = int.Parse(maskedTxtIngreso.Text);
                                                    varEgreso = int.Parse(maskedTxtEgreso.Text);
                                                    varPrecio = int.Parse(maskedTxtPrecio.Text);

                                                    varStockActual = varIngreso - varEgreso;

                                                    lblIndexCodigo.Text = varCodigo;
                                                    lblIndexNombre.Text = varNombre;
                                                    lblIndexDescripcion.Text = varDescripcion;
                                                    lblIndexCategoria.Text = varCategoria;
                                                    lblIndexIngreso.Text = varStockActual.ToString();
                                                    lblIndexPrecio.Text = varPrecio.ToString();
                                                    txtCode.Text = "";
                                                    txtDecripcion.Text = "";
                                                    txtNombre.Text = "";
                                                    cboCategoria.Text = "";
                                                    maskedTxtIngreso.Text = "";
                                                    maskedTxtEgreso.Text = "";
                                                    maskedTxtPrecio.Text = "";

                                                    MessageBox.Show("Producto registrado con exito");
                                                 }
                                             }
                                        }                   
                                }
                            }
                    }
        }

        private void lblIndexIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
