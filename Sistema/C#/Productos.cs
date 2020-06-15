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
    public partial class Productos : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public Productos()
        {
            InitializeComponent();
            /**Creamos el Objeto*/
            routines = new Routines();
            Routines.checkSave = true;
        }
        #region Metodos Necesarios para el Funcinamiento del ABM
        /**Recibirá el Proveedor desde el formulario BuscarProveedores*/
        public void SetCategoria(string idProveedor, string nombreProveedor)
        {
            lIdProveedor.Text = idProveedor;
            tProveedor.Text = nombreProveedor;
        }
        /**Para Buscar los Productos*/
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NProducto, Producto, Precio FROM ProductosBusqueda WHERE " + condicion + " ORDER BY Producto", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "productos");
            if (dataSet.Tables["productos"].Rows.Count == 0)
            {
                gridProductos.Visible = false;
                lIdProducto.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
            }
            else
            {
                gridProductos.DataSource = dataSet.Tables["productos"];
                gridProductos.Refresh();
                gridProductos.Visible = true;
                lIdProducto.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = false;
            }
        }
        /**Filtro de la Fila Seleccionada*/
        public void FilaClick(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridProductos.Rows[fila].Cells[0].Value))
            {
                lIdProducto.Text = "0";
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                tfila = gridProductos.Rows[fila].Cells[0].Value.ToString();
                lIdProducto.Text = tfila.ToString();
                CargarCamposProductos();
            }
        }
        /**Carga los Datos del Producto seleccionado en los campos*/
        public void CargarCamposProductos()
        {
            if (Conversion.Val(lIdProveedor.Text) == 0)
            {
                //gridClientes.Visible = false;
                lIdProducto.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                lIdProducto.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoProveedor,'****')))) AS ApellidoProveedor, UPPER(LTRIM(RTRIM(ISNULL(NombreProveedor, '****')))) AS NombreProveedor, LTRIM(RTRIM(ISNULL(DocumentoProveedor, ''))) AS DocumentoProveedor, LTRIM(RTRIM(ISNULL(CuitProveedor, ''))) AS CuitProveedor,LTRIM(RTRIM(ISNULL(DomicilioProveedor, ''))) AS DomicilioProveedor,LTRIM(RTRIM(ISNULL(PostalProveedor, ''))) AS PostalProveedor,LTRIM(RTRIM(ISNULL(LocalidadProveedor, ''))) AS LocalidadProveedor,LTRIM(RTRIM(ISNULL(ProvinciaProveedor, ''))) AS ProvinciaProveedor,LTRIM(RTRIM(ISNULL(TelefonoProveedor, ''))) TelefonoProveedor,FechaNacimientoProveedor,LTRIM(RTRIM(ISNULL(ComentariosProveedor, ''))) AS ComentariosProveedor,LTRIM(RTRIM(ISNULL(EMailProveedor, ''))) AS EMailProveedor,isnull(Estado, 0) AS Estado FROM Proveedores WHERE NProveedor = " + Conversion.Val(lIdProveedor.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "productos");
                tApellido.Text = dataSet.Tables["productos"].Rows[0]["ApellidoProveedor"].ToString();
                tNombre.Text = dataSet.Tables["productos"].Rows[0]["NombreProveedor"].ToString();
                tDNI.Text = dataSet.Tables["productos"].Rows[0]["DocumentoProveedor"].ToString();
                DateTimePicker1.Value = (DateTime)dataSet.Tables["productos"].Rows[0]["FechaNacimientoProveedor"];
                CheckBox1.Checked = Conversion.Val(dataSet.Tables["productos"].Rows[0]["Estado"]) == 0 ? false : true;
                tCUIT.Text = dataSet.Tables["productos"].Rows[0]["CuitProveedor"].ToString();
                tDireccion.Text = dataSet.Tables["productos"].Rows[0]["DomicilioProveedor"].ToString();
                tLocalidad.Text = dataSet.Tables["productos"].Rows[0]["LocalidadProveedor"].ToString();
                tCP.Text = dataSet.Tables["productos"].Rows[0]["PostalProveedor"].ToString();
                tProvincia.Text = dataSet.Tables["productos"].Rows[0]["ProvinciaProveedor"].ToString();
                tTelefono.Text = dataSet.Tables["productos"].Rows[0]["TelefonoProveedor"].ToString();
                tEmail.Text = dataSet.Tables["productos"].Rows[0]["EMailProveedor"].ToString();
                tComentario.Text = dataSet.Tables["productos"].Rows[0]["ComentariosProveedor"].ToString();
            }
        }
        #endregion
    }
}
