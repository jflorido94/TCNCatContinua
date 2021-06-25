using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Historial_Catergorias_Articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcion llamada cuando el form1 se ha cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //rellenamos los datagridview
            rellenarDGVFam();
            rellenarDGVGT();

            //rellenamos los combobox 
            rellenarcomboboxes();
        }

        #region Funciones comunes
        /// <summary>
        /// Obtiene los datos de las tablas de la base de datos, segun la query pasada por parametros
        /// </summary>
        /// <param name="sql">Query, ya filtrada, que queremos obtener de la base de datos</param>
        /// <returns>Dataset | Devuelve los datos obtenidos de la base de datos con la query pasada por parametros</returns>
        public DataSet getDataSet(string sql)
        {
            SqlCommand command;     //Comando para preparar la consulta Sql y la base de datos
            SqlDataAdapter adapter; //Adaptador con el que se pasa el comando SqlCommand al DataSet
            DataSet data;           //Datos que seran devueltos en la funcion
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    command = new SqlCommand();

                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;

                    adapter = new SqlDataAdapter(command);

                    data = new DataSet();
                    adapter.Fill(data);
                }

                return data;
            }
            catch (SqlException )
            {
                MessageBox.Show("Incidencia detectada, por favor contacte con el administrador", "¡Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();

                return null;
           }

        }

        /// <summary>
        /// Obtiene los datos y los muestra en sus respectivos comboboxes
        /// </summary>
        public void rellenarcomboboxes()
        {
            //----Familia Actual-----
            string sql = "SELECT distinct FamActual as 'Familia Actual' FROM B_HistoFamilia";

            DataSet dataset = getDataSet(sql);

            DataRow dr = dataset.Tables[0].NewRow();    //Creamos una nueva fila en la tabla

            dr["Familia Actual"] = "---Todas---";      //Rellenamos esa fila con el valor predeterminado (para no filtrar)

            dataset.Tables[0].Rows.InsertAt(dr, 0);     //Colocamos esa fila en la primera posicion de la tabla

            cbNewFamiliaFam.DisplayMember = "Familia Actual";  //valor a mostrar al usuario en el combobox
            cbNewFamiliaFam.ValueMember = "Familia Actual";    //valor que devuelve el combobox con SelectedValue

            cbNewFamiliaFam.DataSource = dataset.Tables[0];     //Asignamos la tabla completa al combobox

            //----Familia Anterior-----
            sql = "SELECT distinct FamAnterior as 'Familia Anterior' FROM B_HistoFamilia";

            DataSet dataset2 = getDataSet(sql);

            DataRow dr2 = dataset2.Tables[0].NewRow();    //Creamos una nueva fila en la tabla

            dr2["Familia Anterior"] = "---Todas---";     //Rellenamos esa fila con el valor predeterminado (para no filtrar)

            dataset2.Tables[0].Rows.InsertAt(dr2, 0);     //Colocamos esa fila en la primera posicion de la tabla

            cbOldFamiliaFam.DisplayMember = "Familia Anterior";     //valor a mostrar al usuario en el combobox
            cbOldFamiliaFam.ValueMember = "Familia Anterior";       //valor que devuelve el combobox con SelectedValue

            cbOldFamiliaFam.DataSource = dataset2.Tables[0];         //Asignamos la tabla completa al combobox

            //----Familia Grupo terapeutico-----
            sql = "SELECT distinct Familia FROM B_HistoGT";

            DataSet dataset3 = getDataSet(sql);

            DataRow dr3 = dataset3.Tables[0].NewRow();    //Creamos una nueva fila en la tabla

            dr3["Familia"] = "---Todas---";     //Rellenamos esa fila con el valor predeterminado (para no filtrar)

            dataset3.Tables[0].Rows.InsertAt(dr3, 0);     //Colocamos esa fila en la primera posicion de la tabla

            cbFamiliaGT.DisplayMember = "Familia";     //valor a mostrar al usuario en el combobox
            cbFamiliaGT.ValueMember = "Familia";       //valor que devuelve el combobox con SelectedValue

            cbFamiliaGT.DataSource = dataset3.Tables[0];         //Asignamos la tabla completa al combobox

            //----Accion-----
            sql = "SELECT distinct Accion FROM B_HistoGT";

            DataSet dataset4 = getDataSet(sql);

            DataRow dr4 = dataset4.Tables[0].NewRow();    //Creamos una nueva fila en la tabla

            dr4["Accion"] = "---Todas---";     //Rellenamos esa fila con el valor predeterminado (para no filtrar)

            dataset4.Tables[0].Rows.InsertAt(dr4, 0);     //Colocamos esa fila en la primera posicion de la tabla

            cbAccionGT.DisplayMember = "Accion";     //valor a mostrar al usuario en el combobox
            cbAccionGT.ValueMember = "Accion";       //valor que devuelve el combobox con SelectedValue

            cbAccionGT.DataSource = dataset4.Tables[0];         //Asignamos la tabla completa al combobox

        }

        #endregion

        #region Historial Familias

        /// <summary>
        /// Obtiene los datos de la tabla B_HistoFamilia usando los filtros y los muestra en el DatagridView
        /// </summary>
        public void rellenarDGVFam()
        {
            string sql = "SELECT  Fecha, IdArticulo as Artículo, Descripcion as Descripción, FamAnterior as 'Familia Anterior', FamActual as 'Familia Actual'  FROM B_HistoFamilia";

            addFiltroFam(ref sql);                          //añadimos el filtrado al sql por referencia
            dgvFam.DataSource = getDataSet(sql).Tables[0];  //pasamos el sql a la funcion getDataSet y asociamos el datasource a la tabla obtenida
        }

        
        /// <summary>
        /// Metodo por el que filtramos el dataset por los campos del formulario filtrar
        /// </summary>
        void addFiltroFam(ref string sql)
        {
            // Añadimos a la query sql la clausula WHERE y buscamos por la descripcion del Articulo (con un LIKE)
            sql += string.Format(" WHERE Descripcion LIKE '%{0}%'", tbArticuloFam.Text);

            //buscamos por el Codigo de Articulo (con un LIKE)
            sql += string.Format(" AND IdArticulo LIKE '%{0}%'", tbCodArticuloFam.Text);

            // si existe el valor de Categoria y NO esta seleccionada la opcion "Todas"
            if (cbNewFamiliaFam.SelectedValue != null && cbNewFamiliaFam.SelectedValue.ToString() != "---Todas---")
            {
                // añadimos al string otra clausula que filtra por la categoria actual
                sql += string.Format(" AND FamActual = '{0}'", cbNewFamiliaFam.SelectedValue);
            }
            // si existe el valor de OldCategoria y NO esta seleccionada la opcion "Todas"
            if (this.cbOldFamiliaFam.SelectedValue != null && cbOldFamiliaFam.SelectedValue.ToString() != "---Todas---")
            {
                // añadimos al string otra clausula que filtra por la categoria Antigua
                sql += string.Format(" AND FamAnterior = '{0}'", cbOldFamiliaFam.SelectedValue);
            }

            //buscamos desde la fecha indicada
            sql += string.Format(" AND Fecha >= '{0}'", dtpDesdeFam.Value);

            //y buscamos hasta la fecha indicada
            sql += string.Format(" AND Fecha <= '{0}'", dtpHastaFam.Value);

        }

        #endregion

        #region Comportamiento eventos componentes Historial Familias

        /// <summary>
        /// Cuando hay algun cambio en el textbox tbArticuloFam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbArticuloFam_TextChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }
        /// <summary>
        /// Cuando hay algun cambio en el textbox tbCodArticuloFam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCodArticuloFam_TextChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }

        /// <summary>
        /// Cuando se cambia la Familia Actual en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNewFamiliaFam_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }
        /// <summary>
        /// Cuando se cambia la Familia Anterior en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOldFamiliaFam_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }
        /// <summary>
        /// Cuando se cambia la fecha en datetimepicker Desde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDesdeFam_ValueChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }
        /// <summary>
        /// Cuando se cambia la fecha en datetimepicker Hasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpHastaFam_ValueChanged(object sender, EventArgs e)
        {
            rellenarDGVFam(); //actualizamos el DataGridView
        }

        /// <summary>
        /// Establece los campos del formulario a su valor predeterminado, para eliminar todos los filtros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiarFam_Click(object sender, EventArgs e)
        {
            this.tbArticuloFam.Text = "";
            this.tbCodArticuloFam.Text = "";
            this.cbNewFamiliaFam.SelectedIndex = 0;
            this.cbOldFamiliaFam.SelectedIndex = 0;
            this.dtpDesdeFam.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dtpHastaFam.Value = DateTime.Now;
        }
        /// <summary>
        /// Vuelve a cargar los datos en la tabla cuando clica en refrescar, sin perder el filtro establecido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarFam_Click(object sender, EventArgs e)
        {
            rellenarDGVFam();  //actualizamos el DataGridView
        }

        #endregion

        #region Grupos Teraputicos

        /// <summary>
        /// Obtiene los datos de la tabla HistoGT usando los filtros y los muestra en el DatagridView
        /// </summary>
        public void rellenarDGVGT()
        {
            string sql = "SELECT  Fecha, Accion as Acción, GTCodigo as 'Código Grupo', GTDescripcion as 'Descripción Grupo', Familia FROM B_HistoGT";

            addFiltroGT(ref sql);                          //añadimos el filtrado al sql por referencia
            dgvGT.DataSource = getDataSet(sql).Tables[0];  //pasamos el sql a la funcion getDataSet y asociamos el datasource a la tabla obtenida
        }


        /// <summary>
        /// Metodo por el que filtramos el dataset por los campos del formulario filtrar
        /// </summary>
        void addFiltroGT(ref string sql)
        {
            // Añadimos a la query sql la clausula WHERE y buscamos por la descripcion (con un LIKE)
            sql += string.Format(" WHERE GTDescripcion LIKE '%{0}%'", tbDescripcionGT.Text);

            // Añadimos a la query sql la clausula WHERE y buscamos por la descripcion (con un LIKE)
            sql += string.Format(" AND GTCodigo LIKE '%{0}%'", tbCodigoGT.Text);

            // si existe el valor de Familia y NO esta seleccionada la opcion "Todas"
            if (cbFamiliaGT.SelectedValue != null && cbFamiliaGT.SelectedValue.ToString() != "---Todas---")
            {
                // añadimos al string otra clausula que filtra por la categoria actual
                sql += string.Format(" AND Familia = '{0}'", cbFamiliaGT.SelectedValue);
            }
            // si existe el valor de Accion y NO esta seleccionada la opcion "Todas"
            if (cbAccionGT.SelectedValue != null && cbAccionGT.SelectedValue.ToString() != "---Todas---")
            {
                // añadimos al string otra clausula que filtra por la categoria actual
                sql += string.Format(" AND Accion = '{0}'", cbAccionGT.SelectedValue);
            }


            //buscamos desde la fecha indicada
            sql += string.Format(" AND Fecha >= '{0}'", dtpDesdeGT.Value);

            //y buscamos hasta la fecha indicada
            sql += string.Format(" AND Fecha <= '{0}'", dtpHastaGT.Value);

        }
        #endregion

        #region  Comportamiento eventos componentes Historial Categorias

        /// <summary>
        /// Cuando se cambia la Accion en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAccionGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }
        /// <summary>
        /// Cuando se cambia la Familia en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFamiliaGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }

        /// <summary>
        /// Cuando hay algun cambio en el textbox tbDescripcionGT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDescripcionGT_TextChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }
        /// <summary>
        /// Cuando hay algun cambio en el textbox tbCodigoGT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCodigoGT_TextChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }

        /// <summary>
        /// Cuando se cambia la fecha en datetimepicker Desde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDesdeGT_ValueChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }

        /// <summary>
        /// Cuando se cambia la fecha en datetimepicker Hasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpHastaGT_ValueChanged(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }

        /// <summary>
        /// Establece los campos del formulario a su valor predeterminado, para eliminar todos los filtros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiarGT_Click(object sender, EventArgs e)
        {
            this.tbDescripcionGT.Text = "";
            this.tbCodigoGT.Text = "";
            this.cbFamiliaGT.SelectedIndex = 0;
            this.cbAccionGT.SelectedIndex = 0;
            this.dtpDesdeGT.Value = new DateTime(DateTime.Now.Year, 1, 1); ;
            this.dtpHastaGT.Value = DateTime.Now;
        }

        /// <summary>
        /// Vuelve a cargar los datos en la tabla cuando clica en refrescar, sin perder el filtro establecido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btActualizarGT_Click(object sender, EventArgs e)
        {
            rellenarDGVGT();
        }





        #endregion

        
    }
}
