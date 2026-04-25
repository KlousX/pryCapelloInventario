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
    public partial class frmGrilla : Form
    {
        public frmGrilla()
        {
            InitializeComponent();
        }

        private List<Producto> productos;

        private void frmGrilla_Load(object sender, EventArgs e)
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

        public frmGrilla(List<Producto> listaProductos)
        {
            InitializeComponent();
            productos = listaProductos;
        }
    }
}
