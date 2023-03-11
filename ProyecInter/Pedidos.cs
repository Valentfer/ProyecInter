using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyecInter
{
    public partial class Pedidos : Form
    {
        //nos conectamos con la autentificación de windows y al localhost
        // string connectionString = "Server = localhost; Database = AppGest; User Id = sa; Password = oretania";
        string connectionString = "Server = DESKTOP-0KVUR04; Database = AppGest; Integrated Security=SSPI";
       // string connectionString = "Server = localhost; Database = AppGest; Integrated Security=SSPI";
        ArrayList cells = new ArrayList();
        public Pedidos()
        {
            InitializeComponent();
        }
        //con esta función voy buscando coindencias por cada linea y en cada celda del datagriview
        private void buscarCoincidencias()
        {
            for (int i = 0; i < dgvPedidos.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell Cell in dgvPedidos.Rows[i].Cells)
                {
                    if (txbBuscarPedido.Text != "" && Cell.Value.ToString().Contains(txbBuscarPedido.Text))
                    {
                        cells.Add(Cell);
                        Cell.Style.BackColor = Color.Cyan;
                    }
                    else
                        Cell.Style.BackColor = Color.White;
                }
            }
        }
        //si introduzco una palabra en el textbox busqueda llamo a la función para buscar coincidencias
        private void txbBuscarPedido_TextChanged(object sender, EventArgs e)
        {
            cells.Clear();
            buscarCoincidencias();
            if (cells.Count > 0)
                dgvPedidos.CurrentCell = (DataGridViewCell)cells[0];
            else
                dgvPedidos.CurrentCell = dgvPedidos[0, 0];
        }
        //cargo la consulta en el datagrid nada mas abrir la ventana
        private void Pedidos_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Pedido";
            SqlConnection cnx = new SqlConnection(connectionString);
            try
            {
                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvPedidos.DataSource = dt;
                cnx.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede realizar la conexion");
            }
        }
        //eliminar una fila del datagridview
        private void btnElimPedid_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Server = localhost; Database = AppGest; Integrated Security=SSPI");
            SqlConnection conn = new SqlConnection("Server = DESKTOP-0KVUR04; Database = AppGest; Integrated Security=SSPI");

            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                //me conecto y elimino el pedido de datos

                conn.Open();
                string insertar = "DELETE FROM Pedido WHERE id = @id";
                SqlCommand comand = new SqlCommand(insertar, conn);

                //añadir parametros
                comand.Parameters.Add(new SqlParameter("@id", dgvPedidos.CurrentRow.Index));

                //filas
                int filas = comand.ExecuteNonQuery();
                MessageBox.Show(filas + " filas Eliminadas");
                conn.Close();
            }
            //Elimino el pedido del datagridview
            this.dgvPedidos.Rows.RemoveAt(dgvPedidos.CurrentRow.Index);
        }
        //si dejamos el texbox y no hay nada escrito se vuelve a ver la palabra buscar
        private void txbBuscarPedido_Leave(object sender, EventArgs e)
        {
            if (txbBuscarPedido.Text.Length == 0)
            {
                txbBuscarPedido.Text = "Buscar...";
            }
        }
        //cuando entro al textbox se vacia para escribir
        private void txbBuscarPedido_Enter(object sender, EventArgs e)
        {
            if (txbBuscarPedido.Text.Length > 0)
            {
                txbBuscarPedido.Text = string.Empty;
            }
        }
    }
}
