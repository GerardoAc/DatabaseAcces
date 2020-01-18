namespace PracticaMySQLServer.UNA.vistas
{
    partial class Factura
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
            this.vendedrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteCBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.productosDataGrit = new System.Windows.Forms.DataGridView();
            this.productoColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColuDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarPruductoBtn = new System.Windows.Forms.Button();
            this.nuevoClienteBtn = new System.Windows.Forms.Button();
            this.nuevoUsuariBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrit)).BeginInit();
            this.SuspendLayout();
            // 
            // vendedrLbl
            // 
            this.vendedrLbl.AutoSize = true;
            this.vendedrLbl.Location = new System.Drawing.Point(295, 31);
            this.vendedrLbl.Name = "vendedrLbl";
            this.vendedrLbl.Size = new System.Drawing.Size(56, 13);
            this.vendedrLbl.TabIndex = 10;
            this.vendedrLbl.Text = "Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // ClienteCBox
            // 
            this.ClienteCBox.FormattingEnabled = true;
            this.ClienteCBox.Location = new System.Drawing.Point(78, 26);
            this.ClienteCBox.Name = "ClienteCBox";
            this.ClienteCBox.Size = new System.Drawing.Size(189, 21);
            this.ClienteCBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(357, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(620, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // productosDataGrit
            // 
            this.productosDataGrit.AllowUserToAddRows = false;
            this.productosDataGrit.AllowUserToDeleteRows = false;
            this.productosDataGrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoColDTG,
            this.codigoColuDTG,
            this.descripcionColDTG,
            this.precioUnitarioColDTG,
            this.precioTotalColDTG});
            this.productosDataGrit.Location = new System.Drawing.Point(25, 116);
            this.productosDataGrit.Name = "productosDataGrit";
            this.productosDataGrit.ReadOnly = true;
            this.productosDataGrit.Size = new System.Drawing.Size(751, 239);
            this.productosDataGrit.TabIndex = 15;
            // 
            // productoColDTG
            // 
            this.productoColDTG.HeaderText = "Producto";
            this.productoColDTG.Name = "productoColDTG";
            this.productoColDTG.ReadOnly = true;
            // 
            // codigoColuDTG
            // 
            this.codigoColuDTG.HeaderText = "Codigo";
            this.codigoColuDTG.Name = "codigoColuDTG";
            this.codigoColuDTG.ReadOnly = true;
            // 
            // descripcionColDTG
            // 
            this.descripcionColDTG.HeaderText = "Descripcion";
            this.descripcionColDTG.Name = "descripcionColDTG";
            this.descripcionColDTG.ReadOnly = true;
            // 
            // precioUnitarioColDTG
            // 
            this.precioUnitarioColDTG.HeaderText = "Precio Unitario";
            this.precioUnitarioColDTG.Name = "precioUnitarioColDTG";
            this.precioUnitarioColDTG.ReadOnly = true;
            // 
            // precioTotalColDTG
            // 
            this.precioTotalColDTG.HeaderText = "Precio total";
            this.precioTotalColDTG.Name = "precioTotalColDTG";
            this.precioTotalColDTG.ReadOnly = true;
            // 
            // agregarPruductoBtn
            // 
            this.agregarPruductoBtn.Location = new System.Drawing.Point(620, 87);
            this.agregarPruductoBtn.Name = "agregarPruductoBtn";
            this.agregarPruductoBtn.Size = new System.Drawing.Size(113, 23);
            this.agregarPruductoBtn.TabIndex = 16;
            this.agregarPruductoBtn.Text = "Agregar producto";
            this.agregarPruductoBtn.UseVisualStyleBackColor = true;
            // 
            // nuevoClienteBtn
            // 
            this.nuevoClienteBtn.Location = new System.Drawing.Point(480, 87);
            this.nuevoClienteBtn.Name = "nuevoClienteBtn";
            this.nuevoClienteBtn.Size = new System.Drawing.Size(113, 23);
            this.nuevoClienteBtn.TabIndex = 17;
            this.nuevoClienteBtn.Text = "Nuevo cliente";
            this.nuevoClienteBtn.UseVisualStyleBackColor = true;
            this.nuevoClienteBtn.Click += new System.EventHandler(this.nuevoClienteBtn_Click);
            // 
            // nuevoUsuariBtn
            // 
            this.nuevoUsuariBtn.Location = new System.Drawing.Point(338, 87);
            this.nuevoUsuariBtn.Name = "nuevoUsuariBtn";
            this.nuevoUsuariBtn.Size = new System.Drawing.Size(113, 23);
            this.nuevoUsuariBtn.TabIndex = 18;
            this.nuevoUsuariBtn.Text = "Nuevo usuario";
            this.nuevoUsuariBtn.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 415);
            this.Controls.Add(this.nuevoUsuariBtn);
            this.Controls.Add(this.nuevoClienteBtn);
            this.Controls.Add(this.agregarPruductoBtn);
            this.Controls.Add(this.productosDataGrit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClienteCBox);
            this.Controls.Add(this.vendedrLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vendedrLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClienteCBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView productosDataGrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoColDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColuDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioColDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalColDTG;
        private System.Windows.Forms.Button agregarPruductoBtn;
        private System.Windows.Forms.Button nuevoClienteBtn;
        private System.Windows.Forms.Button nuevoUsuariBtn;
    }
}