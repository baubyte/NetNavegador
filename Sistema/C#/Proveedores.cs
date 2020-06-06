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
    public partial class Proveedores : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public Proveedores()
        {
            InitializeComponent();
            /**Creamos el Objeto*/
            routines = new Routines();
        }
        #region Metodos Necesarios para el Funcinamiento del ABM
        /**Para Buscar los Clientes*/
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NProveedor, ApeYNom, CUIT FROM ProveedoresBusqueda WHERE " + condicion + " ORDER BY ApeYNom", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "proveedores");
            if (dataSet.Tables["proveedores"].Rows.Count == 0)
            {
                gridProveedores.Visible = false;
                lIdProveedor.Visible = false;
                btnBorrar.Visible = false;
                btnEditar.Visible = false;
            }
            else
            {
                gridProveedores.DataSource = dataSet.Tables["proveedores"];
                gridProveedores.Refresh();
                gridProveedores.Visible = true;
                lIdProveedor.Visible = true;
                btnBorrar.Visible = true;
                btnEditar.Visible = true;
            }
        }
        /**Filtro de la Fila Seleccionada*/
        public void FilaClick(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridProveedores.Rows[fila].Cells[0].Value))
            {
                lIdProveedor.Text = "0";
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                tfila = gridProveedores.Rows[fila].Cells[0].Value.ToString();
                lIdProveedor.Text = tfila.ToString();
                CargarCamposClientes();
            }
        }
        /**Carga los Datos del Cliente seleccionado en los campos*/
        public void CargarCamposClientes()
        {
            if (Conversion.Val(lIdProveedor.Text) == 0)
            {
                //gridClientes.Visible = false;
                lIdProveedor.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                lIdProveedor.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoProveedor,'****')))) AS ApellidoProveedor, UPPER(LTRIM(RTRIM(ISNULL(NombreProveedor, '****')))) AS NombreProveedor, LTRIM(RTRIM(ISNULL(DocumentoProveedor, ''))) AS DocumentoProveedor, LTRIM(RTRIM(ISNULL(CuitProveedor, ''))) AS CuitProveedor,LTRIM(RTRIM(ISNULL(DomicilioProveedor, ''))) AS DomicilioProveedor,LTRIM(RTRIM(ISNULL(PostalProveedor, ''))) AS PostalProveedor,LTRIM(RTRIM(ISNULL(LocalidadProveedor, ''))) AS LocalidadProveedor,LTRIM(RTRIM(ISNULL(ProvinciaProveedor, ''))) AS ProvinciaProveedor,LTRIM(RTRIM(ISNULL(TelefonoProveedor, ''))) TelefonoProveedor,FechaNacimientoProveedor,LTRIM(RTRIM(ISNULL(ComentariosProveedor, ''))) AS ComentariosProveedor,LTRIM(RTRIM(ISNULL(EMailProveedor, ''))) AS EMailProveedor,isnull(Estado, 0) AS Estado FROM Proveedores WHERE NProveedor = " + Conversion.Val(lIdProveedor.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "proveedores");
                tApellido.Text = dataSet.Tables["proveedores"].Rows[0]["ApellidoProveedor"].ToString();
                tNombre.Text = dataSet.Tables["proveedores"].Rows[0]["NombreProveedor"].ToString();
                tDNI.Text = dataSet.Tables["proveedores"].Rows[0]["DocumentoProveedor"].ToString();
                DateTimePicker1.Value = (DateTime)dataSet.Tables["proveedores"].Rows[0]["FechaNacimientoProveedor"];
                CheckBox1.Checked = Conversion.Val(dataSet.Tables["proveedores"].Rows[0]["Estado"]) == 0 ? false : true;
                tCUIT.Text = dataSet.Tables["proveedores"].Rows[0]["CuitProveedor"].ToString();
                tDireccion.Text = dataSet.Tables["proveedores"].Rows[0]["DomicilioProveedor"].ToString();
                tLocalidad.Text = dataSet.Tables["proveedores"].Rows[0]["LocalidadProveedor"].ToString();
                tCP.Text = dataSet.Tables["proveedores"].Rows[0]["PostalProveedor"].ToString();
                tProvincia.Text = dataSet.Tables["proveedores"].Rows[0]["ProvinciaProveedor"].ToString();
                tTelefono.Text = dataSet.Tables["proveedores"].Rows[0]["TelefonoProveedor"].ToString();
                tEmail.Text = dataSet.Tables["proveedores"].Rows[0]["EMailProveedor"].ToString();
                tComentario.Text = dataSet.Tables["proveedores"].Rows[0]["ComentariosProveedor"].ToString();
            }
        }

        #endregion Metodos Necesarios para el Funcinamiento del ABM
        #region Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /**Aca me quede
            if (routines.SqlAccion("INSERT INTO Clientes (ApellidoCliente ,NombreCliente ,DocumentoCliente ,CuitCliente ,UsuarioCliente ,ClaveCliente ,DomicilioCliente ,PostalCliente ,LocalidadCliente ,ProvinciaCliente ,TelefonoCliente ,FechaNacimientoCliente ,ComentariosCliente ,EMailCliente ,Estado) VALUES ('*****', '*****','','','', '', '', '', '', '','', getdate(), '', '', 1)  "))
            {
                buscar(" ApeYNom LIKE '****%' ");
                MessageBox.Show("Se ha Creado un Nuevo Registro para el Proveedor que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar'.", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
        #endregion Botones

        #region Eventos
        private void gridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        private void gridProveedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }

        #endregion Eventos

        private void Proveedores_Load(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
    }
}
