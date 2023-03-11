
namespace ProyecInter
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbBuscarProd = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.productoTableAdapter1 = new ProyecInter.DataSet1TableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscarProd
            // 
            this.txbBuscarProd.Location = new System.Drawing.Point(15, 114);
            this.txbBuscarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscarProd.Name = "txbBuscarProd";
            this.txbBuscarProd.Size = new System.Drawing.Size(288, 22);
            this.txbBuscarProd.TabIndex = 0;
            this.txbBuscarProd.Text = "Buscar...";
            this.txbBuscarProd.TextChanged += new System.EventHandler(this.txbBuscarProd_TextChanged);
            this.txbBuscarProd.Enter += new System.EventHandler(this.txbBuscarProd_Enter);
            this.txbBuscarProd.Leave += new System.EventHandler(this.txbBuscarProd_Leave);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 165);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(692, 311);
            this.dgvProductos.TabIndex = 5;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txbBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBuscarProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private DataSet1TableAdapters.ProductoTableAdapter productoTableAdapter1;
    }
}