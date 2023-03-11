using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ProyecInter
{
    public partial class Productos : Form
    {
        //string connectionString = "Server = localhost; Database = AppGest; User Id = sa; Password = oretania";
        string connectionString = "Server = DESKTOP-0KVUR04; Database = AppGest; Integrated Security=SSPI";
      //  string connectionString = "Server = localhost; Database = AppGest; Integrated Security=SSPI";
        ArrayList cells = new ArrayList();
        public Detalle detalle;
        public bool activo = false;
        public Productos()
        {
            InitializeComponent();
        }
        
        public void aniadir()
        {
            //si contiene filas seleccionadas las envia a la ventana detalles
            DataGridViewSelectedRowCollection filas = dgvProductos.SelectedRows;
            if (filas.Count > 0) {
                
                detalle = new Detalle(ref filas);
                //para controlar que no se accede a la pestaña detalle sin productos
                activo = true;
            }
            //muestro un mensaje si no ha seleccionado ningún producto
            else
            {
                MessageBox.Show("Debe seleccionar algún Producto");
            }
            

            
        }
        //buscar coincidencias
        private void txbBuscarProd_TextChanged(object sender, EventArgs e)
        {
            cells.Clear();
            buscarCoincidencias();
            if (cells.Count > 0)
                dgvProductos.CurrentCell = (DataGridViewCell)cells[0];
            else
                dgvProductos.CurrentCell = dgvProductos[0, 0];
        }
        private void buscarCoincidencias()
        {
            for (int i = 0; i < dgvProductos.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell Cell in dgvProductos.Rows[i].Cells)
                {
                    if (txbBuscarProd.Text != "" && Cell.Value.ToString().Contains(txbBuscarProd.Text))
                    {
                        cells.Add(Cell);
                        Cell.Style.BackColor = Color.Cyan;
                    }
                    else
                        Cell.Style.BackColor = Color.White;
                }
            }
        }
        //consultar los datos nada mas cargar la ventana
        private void Productos_Load(object sender, EventArgs e)
        {
             string sql = "SELECT * FROM Producto";
              SqlConnection cnx = new SqlConnection(connectionString);
              try
              {
                  cnx.Open();
                  SqlCommand command = new SqlCommand(sql, cnx);
                  SqlDataReader dataReader = command.ExecuteReader();
                  DataTable dt = new DataTable();
                  dt.Load(dataReader);
                  dgvProductos.DataSource = dt;
                  cnx.Close();
              }
              catch (SqlException ex)
              {
                  MessageBox.Show("No se puede realizar la conexion");
              }

        }

        private void txbBuscarProd_Leave(object sender, EventArgs e)
        {
            if (txbBuscarProd.Text.Length == 0)
            {
                txbBuscarProd.Text = "Buscar...";
            }
        }

        private void txbBuscarProd_Enter(object sender, EventArgs e)
        {
            if (txbBuscarProd.Text.Length > 0)
            {
                txbBuscarProd.Text = string.Empty;
            }
        }
    }
}
