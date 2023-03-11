using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyecInter
{
    public partial class AppGest : Form
    {
        Productos vtProductos;
        public AppGest()
        {
            InitializeComponent();
        }
        // con el siguiente código consigo que se pueda mover la ventana del login cuando se pincha sobre ella
        //hay que hacer el import correspondiente (using System.Runtime.InteropServices;)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       //dependiendo de el botón que pulse se hace visible el panel correspondiente para dar la sensación de desplegar nuevos botones
       // y le indico la ventana que debe mostrar en el panel
        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = true;
            pnlPedi.Visible = false;
            pnlTraba.Visible = false;
            vtProductos = new Productos();
            abrirForm(vtProductos);
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            pnlTraba.Visible = true;
            pnlProductos.Visible = false;
            pnlPedi.Visible = false;
            abrirForm(new Trabajador());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            pnlPedi.Visible = true;
            pnlProductos.Visible = false;
            pnlTraba.Visible = false;
            abrirForm(new Pedidos());
        }
        //esta función es para mostrar el form correspondiente cuando se pulsa el botón
        private void abrirForm(object formhijo)
        {
            //le indicamos que si tiene controles los borre para proceder con el nuevo
            if (this.panelDatos.Controls.Count > 0)
            {
                this.panelDatos.Controls.RemoveAt(0);
                //creamos el form
                Form fhijo = formhijo as Form;
                //le indicamos qeu no es de alto nivel
                fhijo.TopLevel = false;
                //le indicamos donde se debe acoplar, añadimos y mostramos
                fhijo.Dock = DockStyle.Fill;
                this.panelDatos.Controls.Add(fhijo);
                this.panelDatos.Tag = fhijo;
                fhijo.Show();
            }else
            {
                Form fhijo = formhijo as Form;
                //le indicamos qeu no es de alto nivel
                fhijo.TopLevel = false;
                //le indicamos donde se debe acoplar, añadimos y mostramos
                fhijo.Dock = DockStyle.Fill;
                this.panelDatos.Controls.Add(fhijo);
                this.panelDatos.Tag = fhijo;
                fhijo.Show();
            }
        }
        //captura el panel con un click sin soltar para poder arrartrarlo
        private void AppGest_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuVer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //pulsando en la imagen de la cruz se cierra
        private void pctbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            abrirForm(new Factura());
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAniadirProd_Click(object sender, EventArgs e)
        {
            vtProductos.aniadir();
            if (vtProductos.activo)
            {
                btnDetProd.Enabled = true;
            }
            }

        private void btnDetProd_Click(object sender, EventArgs e)
        {
            abrirForm(vtProductos.detalle);
        }
        //pulsando en la imagen de la linea baja se minimiza
        private void pctbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }
    }
}
