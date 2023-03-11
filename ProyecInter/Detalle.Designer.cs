namespace ProyecInter
{
    partial class Detalle
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
            this.btnAniadir = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbNomDet = new System.Windows.Forms.TextBox();
            this.txbDirDet = new System.Windows.Forms.TextBox();
            this.txbTrabDet = new System.Windows.Forms.TextBox();
            this.lblNomDet = new System.Windows.Forms.Label();
            this.lblDirDet = new System.Windows.Forms.Label();
            this.lblTRabDet = new System.Windows.Forms.Label();
            this.btnElimDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(490, 501);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(167, 28);
            this.btnAniadir.TabIndex = 0;
            this.btnAniadir.Text = "Añadir Pedido";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.IdTrabajador});
            this.dgvDetalle.Location = new System.Drawing.Point(25, 183);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(632, 310);
            this.dgvDetalle.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unidades";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.HeaderText = "Precio";
            this.IdTrabajador.MinimumWidth = 6;
            this.IdTrabajador.Name = "IdTrabajador";
            this.IdTrabajador.Width = 125;
            // 
            // txbNomDet
            // 
            this.txbNomDet.Location = new System.Drawing.Point(143, 108);
            this.txbNomDet.Margin = new System.Windows.Forms.Padding(4);
            this.txbNomDet.Name = "txbNomDet";
            this.txbNomDet.Size = new System.Drawing.Size(271, 22);
            this.txbNomDet.TabIndex = 2;
            // 
            // txbDirDet
            // 
            this.txbDirDet.Location = new System.Drawing.Point(143, 140);
            this.txbDirDet.Margin = new System.Windows.Forms.Padding(4);
            this.txbDirDet.Name = "txbDirDet";
            this.txbDirDet.Size = new System.Drawing.Size(271, 22);
            this.txbDirDet.TabIndex = 3;
            // 
            // txbTrabDet
            // 
            this.txbTrabDet.Location = new System.Drawing.Point(571, 108);
            this.txbTrabDet.Margin = new System.Windows.Forms.Padding(4);
            this.txbTrabDet.Name = "txbTrabDet";
            this.txbTrabDet.Size = new System.Drawing.Size(85, 22);
            this.txbTrabDet.TabIndex = 4;
            // 
            // lblNomDet
            // 
            this.lblNomDet.AutoSize = true;
            this.lblNomDet.Location = new System.Drawing.Point(21, 112);
            this.lblNomDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDet.Name = "lblNomDet";
            this.lblNomDet.Size = new System.Drawing.Size(113, 17);
            this.lblNomDet.TabIndex = 5;
            this.lblNomDet.Text = "Nombre Cliente: ";
            // 
            // lblDirDet
            // 
            this.lblDirDet.AutoSize = true;
            this.lblDirDet.Location = new System.Drawing.Point(21, 149);
            this.lblDirDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirDet.Name = "lblDirDet";
            this.lblDirDet.Size = new System.Drawing.Size(75, 17);
            this.lblDirDet.TabIndex = 6;
            this.lblDirDet.Text = "Dirección: ";
            // 
            // lblTRabDet
            // 
            this.lblTRabDet.AutoSize = true;
            this.lblTRabDet.Location = new System.Drawing.Point(449, 117);
            this.lblTRabDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTRabDet.Name = "lblTRabDet";
            this.lblTRabDet.Size = new System.Drawing.Size(97, 17);
            this.lblTRabDet.TabIndex = 7;
            this.lblTRabDet.Text = "Atendido por: ";
            // 
            // btnElimDet
            // 
            this.btnElimDet.Location = new System.Drawing.Point(25, 500);
            this.btnElimDet.Name = "btnElimDet";
            this.btnElimDet.Size = new System.Drawing.Size(153, 23);
            this.btnElimDet.TabIndex = 8;
            this.btnElimDet.Text = "Eliminar Producto";
            this.btnElimDet.UseVisualStyleBackColor = true;
            this.btnElimDet.Click += new System.EventHandler(this.btnElimDet_Click);
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(671, 549);
            this.Controls.Add(this.btnElimDet);
            this.Controls.Add(this.lblTRabDet);
            this.Controls.Add(this.lblDirDet);
            this.Controls.Add(this.lblNomDet);
            this.Controls.Add(this.txbTrabDet);
            this.Controls.Add(this.txbDirDet);
            this.Controls.Add(this.txbNomDet);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAniadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrabajador;
        private System.Windows.Forms.TextBox txbNomDet;
        private System.Windows.Forms.TextBox txbDirDet;
        private System.Windows.Forms.TextBox txbTrabDet;
        private System.Windows.Forms.Label lblNomDet;
        private System.Windows.Forms.Label lblDirDet;
        private System.Windows.Forms.Label lblTRabDet;
        private System.Windows.Forms.Button btnElimDet;
    }
}