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
        /**Para Buscar los Productos*/
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NProducto,CodigoProducto , Producto, PrecioVenta FROM ProductosBusqueda WHERE " + condicion + " ORDER BY Producto", routines.Conectar());
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
                pnlBordeEditar.Visible = true;
            }
        }
        /**Filtro de la Fila Seleccionada*/
        public void FilaClick(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridProductos.Rows[fila].Cells["NProducto"].Value))
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
            if (Conversion.Val(lIdProducto.Text) == 0)
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
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT dbo.Productos.NProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.NombreProducto,'****')))) AS NombreProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.CodigoProducto, ''))) AS CodigoProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.MarcaProducto, '*')))) AS MarcaProducto, UPPER(LTRIM(RTRIM(ISNULL(dbo.Productos.DescripcionProducto, '****')))) AS DescripcionProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioProducto, ''))) AS PrecioProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.PrecioCostoProducto, ''))) AS PrecioCostoProducto, LTRIM(RTRIM(ISNULL(dbo.Productos.StockProducto, ''))) AS StockProducto, UPPER(LTRIM(dbo.Proveedores.NombreProveedor) + ', ' + LTRIM(dbo.Proveedores.ApellidoProveedor)) AS Proveedor, LTRIM(RTRIM(ISNULL(dbo.Productos.CategoriaProducto, ''))) AS CategoriaProducto, ISNULL(dbo.Productos.Estado, 0) AS Estado, dbo.Proveedores.NProveedor AS NProveedor FROM dbo.Productos LEFT JOIN dbo.Proveedores ON dbo.Productos.NProveedor = dbo.Proveedores.NProveedor WHERE dbo.Productos.NProducto = " + Conversion.Val(lIdProducto.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "productos");
                tNombreProducto.Text = dataSet.Tables["productos"].Rows[0]["NombreProducto"].ToString();
                tCodProducto.Text = dataSet.Tables["productos"].Rows[0]["CodigoProducto"].ToString();
                tMarcaProducto.Text = dataSet.Tables["productos"].Rows[0]["MarcaProducto"].ToString();
                tDescripcionProducto.Text = dataSet.Tables["productos"].Rows[0]["DescripcionProducto"].ToString();
                tPrecioCosto.Text = dataSet.Tables["productos"].Rows[0]["PrecioCostoProducto"].ToString();
                tPrecioVenta.Text = dataSet.Tables["productos"].Rows[0]["PrecioProducto"].ToString();
                tStock.Text = dataSet.Tables["productos"].Rows[0]["StockProducto"].ToString();
                CheckBox1.Checked = Conversion.Val(dataSet.Tables["productos"].Rows[0]["Estado"]) == 0 ? false : true;
                tProveedor.Text = dataSet.Tables["productos"].Rows[0]["Proveedor"].ToString();
                cmbCategoria.SelectedIndex = cmbCategoria.FindString(dataSet.Tables["productos"].Rows[0]["CategoriaProducto"].ToString());
                /**ID del Proveedor Actual*/
                lIdProveedor.Text = dataSet.Tables["productos"].Rows[0]["NProveedor"].ToString();
            }
        }
        /**Para Abrir el FORM de Buscar Proveedor*/
        private void openBuscarProveedor()
        {
            Form buscarProveedor = new BuscarProveedor();
            AddOwnedForm(buscarProveedor);
            buscarProveedor.ShowDialog();
        }
        #endregion
        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                buscar(" Producto LIKE '" + tBuscar.Text + "%' ");
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Producto Creado o Eliminarlo en su Defecto Antes de Buscar.", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está por ELIMINAR definitivamente el Producto: " + tNombreProducto.Text.Trim().ToUpper() + ", " + tCodProducto.Text.Trim().ToUpper() + ". Es algo EXTREMO. ¿Está SEGURO?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;
            // Ejecutamos el Delete
            if (routines.SqlAccion("DELETE FROM Productos  WHERE  NProducto=" + Conversion.Val(lIdProducto.Text)) == false)
            {
                MessageBox.Show("Hubo un Error al intentar Borrar el Producto, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Routines.checkSave)
                {
                    Routines.checkSave = true;
                }
                buscar(" NProducto=" + Conversion.Val(lIdProducto.Text));
                MessageBox.Show("El Producto fue ELIMINADO de la Base de Datos.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                if (routines.SqlAccion("INSERT INTO Productos (NombreProducto,CodigoProducto,MarcaProducto,DescripcionProducto,PrecioProducto,PrecioCostoProducto,StockProducto,NProveedor,CategoriaProducto,Estado) VALUES ('*****', '*****','****','','','', '', '','', 1)  "))
                {
                    /**Cambiamos el Estado de la Validacion*/
                    Routines.checkSave = false;
                    buscar(" Producto LIKE '****%' ");
                    MessageBox.Show("Se ha Creado un Nuevo Registro para el Producto que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar'.", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Producto Creado Antes Agregar un Nuevo Proveedor.", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            /**Para Guardar los Errores que Surjan*/
            string errores = "";
            /**Guardamos el caracter del enter*/
            string enter = Constants.vbCrLf;
            if (tNombreProducto.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el Nombre del Producto." + enter;
            }
            tCodProducto.Text = tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tCodProducto.Text.Trim().Length < 4 | tCodProducto.Text.IndexOf("11111") > -1 | tCodProducto.Text.IndexOf("12345") > -1 | tCodProducto.Text.IndexOf("000000") > -1 | routines.Vnum(tCodProducto.Text) <= 0)
            {
                errores += "Debe completar CORRECTAMENTE el Código del Producto (Solo Números." + enter;
            }

            if (routines.YaExisteSql("SELECT CodigoProducto FROM Productos WHERE CodigoProducto =" + routines.Vnum(tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "AND NProducto != " + routines.Vnum(lIdProducto.Text)) == true)
            {
                errores += "El Código del Producto Ingresado ya Existe." + enter;
            }
            tPrecioVenta.Text = tPrecioVenta.Text.Trim().Replace("-", "");
            if (tPrecioVenta.Text.IndexOf("11111") > -1 | tPrecioVenta.Text.IndexOf("12345") > -1 | tPrecioVenta.Text.IndexOf("000000") > -1 | routines.Vnum(tPrecioVenta.Text) <= 0)
            {
                errores += "Debe completar CORRECTAMENTE el Precio de Venta." + enter;
            }
            tPrecioCosto.Text = tPrecioCosto.Text.Trim().Replace("-", "");
            if (tPrecioCosto.Text.IndexOf("11111") > -1 | tPrecioCosto.Text.IndexOf("12345") > -1 | tPrecioCosto.Text.IndexOf("000000") > -1 | routines.Vnum(tPrecioCosto.Text) <= 0)
            {
                errores += "Debe completar CORRECTAMENTE el Precio de Costo." + enter;
            }
            tStock.Text = tStock.Text.Trim().Replace("-", "");
            if (tStock.Text.IndexOf("11111") > -1 | tStock.Text.IndexOf("12345") > -1 | tStock.Text.IndexOf("000000") > -1 | routines.Vnum(tStock.Text) <= 0)
            {
                errores += "Debe completar CORRECTAMENTE el Stock del Producto." + enter;
            }
            if (tProveedor.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el Nombre del Proveedor." + enter;
            }
            if (cmbCategoria.SelectedIndex == 0)
            {
                errores += "Debe Sellecionar una Categoria." + enter;
            }
            if (errores.Length > 0)
            {
                MessageBox.Show("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" + enter + enter + errores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /**Ejecutamos el Update*/
            if (routines.SqlAccion("UPDATE Productos SET Estado =" + (CheckBox1.Checked ? 1 : 0) + ", NombreProducto='" + tNombreProducto.Text.Trim().ToUpper().Replace("'", "´") + "' , MarcaProducto='" + tMarcaProducto.Text.Trim().ToUpper().Replace("'", "´") + "', CodigoProducto=" + Conversion.Val(tCodProducto.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", PrecioProducto =" + routines.NumSql(tPrecioVenta.Text.Trim().Replace(" ", "")) + ", DescripcionProducto='" + tDescripcionProducto.Text.Trim().ToUpper().Replace("'", "´") + "', CategoriaProducto='" + cmbCategoria.SelectedItem + "', PrecioCostoProducto='" + routines.NumSql(tPrecioCosto.Text.Trim().Replace(" ", "")) + "', StockProducto='" + routines.NumSql(tStock.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "', NProveedor='" + Conversion.Val(lIdProveedor.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "' WHERE NProducto=" + routines.Vnum(lIdProducto.Text)) == true)
            {
                MessageBox.Show("Cambios Realizados Correctamente.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar(" NProducto=" + routines.Vnum(lIdProducto.Text));
                /**Cambiamos el Estado del checkSave*/
                Routines.checkSave = true;
            }
            else
            {
                MessageBox.Show("Se Produjo un Error al Querer Guardar los Datos del Producto, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAddProveedor_Click(object sender, EventArgs e)
        {
            openBuscarProveedor();
        }
        #endregion
        #region Eventos
        private void Productos_Load(object sender, EventArgs e)
        {
            buscar(" Producto LIKE '" + tBuscar.Text + "%' ");
        }
        private void gridProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        private void tProveedor_Click(object sender, EventArgs e)
        {
            openBuscarProveedor();
        }
        #endregion
    }
}
