using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyecInter
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }
        //datos recibidos de los productos seleccionados
        public Detalle(ref DataGridViewSelectedRowCollection filas)
        {
            InitializeComponent();
            foreach (DataGridViewRow fila in filas)
            {
                object[] valores =
                {
                    //me quedo con las celdas que me interesan
                    fila.Cells[0].Value,
                    fila.Cells[1].Value,
                    fila.Cells[2].Value,
                    fila.Cells[3].Value,
                };
                //creo un nuevo datagridview
                DataGridViewRow nuevaFila= new DataGridViewRow();
                nuevaFila.CreateCells(dgvDetalle, valores);
                dgvDetalle.Rows.Add(nuevaFila);
            }

        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            //conexion usando el autentificador de windows
            //SqlConnection conn = new SqlConnection("Server = localhost; Database = AppGest; Integrated Security=SSPI");
            SqlConnection conn = new SqlConnection("Server = DESKTOP-0KVUR04; Database = AppGest; Integrated Security=SSPI");

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                //me conecto e inserto

                conn.Open();
                //string insertar = "INSERT INTO Pedido (id, NombreCliente, Direccion, idTrabajador) VALUES (@id, @nombre, @direccion, @idTrabajador)";
                string insertar = "INSERT INTO Pedido ( NombreCliente, Direccion, idTrabajador) VALUES ( @nombre, @direccion, @idTrabajador)";
                SqlCommand comand = new SqlCommand(insertar, conn);
                //cambio el valor del parámetro id porque da fallo si intento meterle el valor de la celda del datagridview
                //que seria lo correcto pero el fallo viene en la creación de la base de datos
                //int id = (int)fila.Cells[0].Value;
                //int id = 9;
                String nombre = txbNomDet.Text;
                String direccion = txbDirDet.Text;
                int idTrabajador = int.Parse(txbTrabDet.Text);


                //añadir parametros

              //  comand.Parameters.Add(new SqlParameter("@id", id));
                comand.Parameters.Add(new SqlParameter("@nombre", nombre));
                comand.Parameters.Add(new SqlParameter("@direccion", direccion));
                comand.Parameters.Add(new SqlParameter("@idTrabajador", idTrabajador));

                //filas
                int filas = comand.ExecuteNonQuery();
                MessageBox.Show(filas + " filas añadidas");
                conn.Close();
            }

        }
        //función para eliminar una linea del datagridview
        private void btnElimDet_Click(object sender, EventArgs e)
        {
            this.dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
        }
    }
}
