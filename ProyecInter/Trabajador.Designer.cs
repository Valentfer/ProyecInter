
namespace ProyecInter
{
    partial class Trabajador
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregarTRab = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.txbPuesto = new System.Windows.Forms.TextBox();
            this.txbDir = new System.Windows.Forms.TextBox();
            this.btnGeneraXml = new System.Windows.Forms.Button();
            this.dgTrabajadores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyecInter.DataSet1();
            this.trabajadorTableAdapter = new ProyecInter.DataSet1TableAdapters.TrabajadorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTRab
            // 
            this.btnAgregarTRab.Location = new System.Drawing.Point(535, 250);
            this.btnAgregarTRab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarTRab.Name = "btnAgregarTRab";
            this.btnAgregarTRab.Size = new System.Drawing.Size(179, 28);
            this.btnAgregarTRab.TabIndex = 4;
            this.btnAgregarTRab.Text = "Agregar Trabajador";
            this.btnAgregarTRab.UseVisualStyleBackColor = true;
            this.btnAgregarTRab.Click += new System.EventHandler(this.btnAgregarTRab_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(16, 122);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(696, 22);
            this.txbNombre.TabIndex = 5;
            this.txbNombre.Text = "Nombre";
            this.txbNombre.Enter += new System.EventHandler(this.txbNombre_Enter);
            this.txbNombre.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(16, 154);
            this.txbApe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(696, 22);
            this.txbApe.TabIndex = 6;
            this.txbApe.Text = "Apellidos";
            this.txbApe.Enter += new System.EventHandler(this.txbApe_Enter);
            this.txbApe.Leave += new System.EventHandler(this.txbApe_Leave);
            // 
            // txbPuesto
            // 
            this.txbPuesto.Location = new System.Drawing.Point(16, 186);
            this.txbPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPuesto.Name = "txbPuesto";
            this.txbPuesto.Size = new System.Drawing.Size(696, 22);
            this.txbPuesto.TabIndex = 7;
            this.txbPuesto.Text = "Puesto";
            this.txbPuesto.Enter += new System.EventHandler(this.txbPuesto_Enter);
            this.txbPuesto.Leave += new System.EventHandler(this.txbPuesto_Leave);
            // 
            // txbDir
            // 
            this.txbDir.Location = new System.Drawing.Point(16, 218);
            this.txbDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDir.Name = "txbDir";
            this.txbDir.Size = new System.Drawing.Size(696, 22);
            this.txbDir.TabIndex = 8;
            this.txbDir.Text = "Dirección";
            this.txbDir.Enter += new System.EventHandler(this.txbDir_Enter);
            this.txbDir.Leave += new System.EventHandler(this.txbDir_Leave);
            // 
            // btnGeneraXml
            // 
            this.btnGeneraXml.Location = new System.Drawing.Point(309, 250);
            this.btnGeneraXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeneraXml.Name = "btnGeneraXml";
            this.btnGeneraXml.Size = new System.Drawing.Size(217, 28);
            this.btnGeneraXml.TabIndex = 10;
            this.btnGeneraXml.Text = "Generar Listado";
            this.btnGeneraXml.UseVisualStyleBackColor = true;
            this.btnGeneraXml.Click += new System.EventHandler(this.btnGeneraXml_Click);
            // 
            // dgTrabajadores
            // 
            this.dgTrabajadores.AllowUserToAddRows = false;
            this.dgTrabajadores.AllowUserToDeleteRows = false;
            this.dgTrabajadores.AutoGenerateColumns = false;
            this.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idPedidoDataGridViewTextBoxColumn});
            this.dgTrabajadores.DataSource = this.trabajadorBindingSource;
            this.dgTrabajadores.Location = new System.Drawing.Point(16, 310);
            this.dgTrabajadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgTrabajadores.Name = "dgTrabajadores";
            this.dgTrabajadores.ReadOnly = true;
            this.dgTrabajadores.RowHeadersWidth = 51;
            this.dgTrabajadores.Size = new System.Drawing.Size(697, 185);
            this.dgTrabajadores.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // trabajadorBindingSource
            // 
            this.trabajadorBindingSource.DataMember = "Trabajador";
            this.trabajadorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabajadorTableAdapter
            // 
            this.trabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(767, 510);
            this.Controls.Add(this.dgTrabajadores);
            this.Controls.Add(this.btnGeneraXml);
            this.Controls.Add(this.txbDir);
            this.Controls.Add(this.txbPuesto);
            this.Controls.Add(this.txbApe);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnAgregarTRab);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Trabajador";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarTRab;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.TextBox txbPuesto;
        private System.Windows.Forms.TextBox txbDir;
        private System.Windows.Forms.Button btnGeneraXml;
        private System.Windows.Forms.DataGridView dgTrabajadores;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource trabajadorBindingSource;
        private DataSet1TableAdapters.TrabajadorTableAdapter trabajadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
    }
}