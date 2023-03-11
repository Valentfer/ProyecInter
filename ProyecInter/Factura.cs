using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyecInter
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            
            this.reportViewer1.RefreshReport();
        }
        //generación del subinforme
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            var code = e.Parameters["nombre"].Values.First();

            DataSet1.DataTable1DataTable tabla = new DataSet1.DataTable1DataTable();
            this.DataTable1TableAdapter.FillBy(tabla, code);

            e.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)tabla));
        }
        //en este metodo filtramos la búsqueda, si es no se introduce nada en el textbox aparecen todos los datos
           private void txbNomFact_TextChanged(object sender, EventArgs e)
           {
               if (txbNomFact.TextLength > 0)
               {
                   this.DataTable1TableAdapter.FillBy(this.DataSet1.DataTable1, txbNomFact.Text);
               }
               else
               {
                   this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
               }
               this.reportViewer1.RefreshReport();
           }
    }
}
