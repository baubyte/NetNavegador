using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**Libreria para los Iconos*/
using FontAwesome.Sharp;
//Clases para ADO, para la Conexion con la DB
using System.Data.SqlClient;
//Clases de VisualBasic
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace sistema
{
    public partial class BuscarProveedor : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public BuscarProveedor()
        {
            InitializeComponent();
            /**Creamos el Objeto*/
            routines = new Routines();
            /**Desactivamos los Controles y los titulos de la Vnetana del FORM*/
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        #region Metodos Necesarios
        /**Para Buscar los Proveedores*/
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NProveedor, ApeYNom, CUIT FROM ProveedoresBusqueda WHERE " + condicion + " ORDER BY ApeYNom", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "proveedores");
            if (dataSet.Tables["proveedores"].Rows.Count == 0)
            {
                gridProveedores.Visible = false;
            }
            else
            {
                gridProveedores.DataSource = dataSet.Tables["proveedores"];
                gridProveedores.Refresh();
                gridProveedores.Visible = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
        #endregion

        #region Eventos
        private void BuscarProveedor_Load(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
        private void gridProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos frmProductos = (Productos)Owner;
            frmProductos.lIdProveedor.Text = gridProveedores.CurrentRow.Cells["nproveedor"].Value.ToString();
            frmProductos.tProveedor.Text = gridProveedores.CurrentRow.Cells["ApeYNom"].Value.ToString();
            this.Close();
        }
        #endregion

    }
}
