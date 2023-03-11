using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace ProyecInter
{
    public partial class Trabajador : Form
    {
        //en esta ventana cargo los datos a través del dataset
        public Trabajador()
        {
            InitializeComponent();
        }
        //al abrir la ventana le indico que pruebe a conectar con el listado de trabajadores xml
        //y si no está que lo cree
        private void Trabajador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajador' Puede moverla o quitarla según sea necesario.
            this.trabajadorTableAdapter.Fill(this.dataSet1.Trabajador);


            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("lista_trabajadores.xml");
               
            }
            catch (Exception exc) {
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);
                XmlElement cliente = doc.CreateElement(string.Empty, "Trabajador", string.Empty);
                doc.AppendChild(cliente);
                doc.Save("lista_trabajadores.xml");
            }

        }
        //al pulsar en generar xml coge todos los datos del datagridview y crea un nuevo listado
        
        private void btnGeneraXml_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement trabajadores = doc.CreateElement("trabajadores");
            doc.AppendChild(trabajadores);

            for (int i = 0; i < dgTrabajadores.Rows.Count; i++)
            {

                XmlElement element = doc.CreateElement(string.Empty, "Trabajador", string.Empty);
                trabajadores.AppendChild(element);

                //a partir de este elemento se introducen los datos
                XmlElement element1 = doc.CreateElement(string.Empty, "Nombre", string.Empty);
                element.AppendChild(element1);
                XmlText text1 = doc.CreateTextNode(dgTrabajadores.Rows[i].Cells[1].Value.ToString());
                element1.AppendChild(text1);

                XmlElement element2 = doc.CreateElement(string.Empty, "Apellidos", string.Empty);
                element.AppendChild(element2);
                XmlText text2 = doc.CreateTextNode(dgTrabajadores.Rows[i].Cells[2].Value.ToString());
                element2.AppendChild(text2);

                XmlElement element3 = doc.CreateElement(string.Empty, "Direccion", string.Empty);
                element.AppendChild(element3);
                XmlText text3 = doc.CreateTextNode(dgTrabajadores.Rows[i].Cells[3].Value.ToString());
                element3.AppendChild(text3);

                XmlElement element4 = doc.CreateElement(string.Empty, "Puesto", string.Empty);
                element.AppendChild(element4);
                XmlText text4 = doc.CreateTextNode(dgTrabajadores.Rows[i].Cells[4].Value.ToString());
                element4.AppendChild(text4);
            }
            
            doc.Save("lista_trabajadores.xml");
        }
        //agregar un trabajador a la base de datos
        private void btnAgregarTRab_Click(object sender, EventArgs e)
        {
         //   SqlConnection conn = new SqlConnection("Server = localhost; Database = AppGest; User Id = sa; Password = oretania");
            SqlConnection conn = new SqlConnection("Server = DESKTOP-0KVUR04; Database = AppGest; Integrated Security=SSPI");
           // SqlConnection conn = new SqlConnection("Server = localhost; Database = AppGest; Integrated Security=SSPI");
         
                //me conecto e inserto

                conn.Open();
                string insertar = "INSERT INTO Trabajador (id, Nombre, Apellidos, Direccion, idPedido) VALUES (@id, @nombre, @apellidos, @direccion, @idPedido)";
                SqlCommand comand = new SqlCommand(insertar, conn);
            //ocurre lo mismo que al introducir un pedido, daria error y tengo que falsearlo por que la base de datos no esta bien creada
                int id = 6;
                String nombre = txbNombre.Text;
                String apellidos = txbApe.Text;
                String direccion = txbDir.Text;
                int idPedido = 4;


                //añadir parametros

                comand.Parameters.Add(new SqlParameter("@id", id));
                comand.Parameters.Add(new SqlParameter("@nombre", nombre));
                comand.Parameters.Add(new SqlParameter("@apellidos", apellidos));
                comand.Parameters.Add(new SqlParameter("@direccion", direccion));
                comand.Parameters.Add(new SqlParameter("@idPedido", idPedido));

                //filas
                int filas = comand.ExecuteNonQuery();
                MessageBox.Show(filas + " filas añadidas");
                conn.Close();
            }

        private void txbNombre_Leave(object sender, EventArgs e)
        {
            if (txbNombre.Text.Length == 0)
            {
                txbNombre.Text = "Nombre";
            }
        }

        private void txbNombre_Enter(object sender, EventArgs e)
        {
            if (txbNombre.Text.Length > 0)
            {
                txbNombre.Text = string.Empty;
            }
        }

        private void txbApe_Leave(object sender, EventArgs e)
        {
            if (txbApe.Text.Length == 0)
            {
                txbApe.Text = "Apellidos";
            }
        }

        private void txbApe_Enter(object sender, EventArgs e)
        {
            if (txbApe.Text.Length > 0)
            {
                txbApe.Text = string.Empty;
            }
        }

        private void txbPuesto_Leave(object sender, EventArgs e)
        {
            if (txbPuesto.Text.Length == 0)
            {
                txbPuesto.Text = "Puesto";
            }
        }

        private void txbPuesto_Enter(object sender, EventArgs e)
        {
            if (txbPuesto.Text.Length > 0)
            {
                txbPuesto.Text = string.Empty;
            }
        }

        private void txbDir_Leave(object sender, EventArgs e)
        {
            if (txbDir.Text.Length == 0)
            {
                txbDir.Text = "Dirección";
            }
        }

        private void txbDir_Enter(object sender, EventArgs e)
        {
            if (txbDir.Text.Length > 0)
            {
                txbDir.Text = string.Empty;
            }
        }
    }
}
