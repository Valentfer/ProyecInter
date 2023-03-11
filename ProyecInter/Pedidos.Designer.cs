
namespace ProyecInter
{
    partial class Pedidos
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
            this.txbBuscarPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pedidoTableAdapter1 = new ProyecInter.DataSet1TableAdapters.PedidoTableAdapter();
            this.btnElimPedid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscarPedido
            // 
            this.txbBuscarPedido.Location = new System.Drawing.Point(239, 82);
            this.txbBuscarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscarPedido.Name = "txbBuscarPedido";
            this.txbBuscarPedido.Size = new System.Drawing.Size(451, 22);
            this.txbBuscarPedido.TabIndex = 0;
            this.txbBuscarPedido.Text = "Buscar...";
            this.txbBuscarPedido.TextChanged += new System.EventHandler(this.txbBuscarPedido_TextChanged);
            this.txbBuscarPedido.Enter += new System.EventHandler(this.txbBuscarPedido_Enter);
            this.txbBuscarPedido.Leave += new System.EventHandler(this.txbBuscarPedido_Leave);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(25, 82);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(104, 17);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Buscar Pedido:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(29, 160);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(677, 300);
            this.dgvPedidos.TabIndex = 1;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnElimPedid
            // 
            this.btnElimPedid.Location = new System.Drawing.Point(525, 127);
            this.btnElimPedid.Name = "btnElimPedid";
            this.btnElimPedid.Size = new System.Drawing.Size(165, 28);
            this.btnElimPedid.TabIndex = 3;
            this.btnElimPedid.Text = "Eliminar Pedido";
            this.btnElimPedid.UseVisualStyleBackColor = true;
            this.btnElimPedid.Click += new System.EventHandler(this.btnElimPedid_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(724, 491);
            this.Controls.Add(this.btnElimPedid);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.txbBuscarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBuscarPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private DataSet1TableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        private System.Windows.Forms.Button btnElimPedid;
    }
}