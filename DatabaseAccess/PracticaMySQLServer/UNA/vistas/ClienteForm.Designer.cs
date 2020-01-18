namespace PracticaMySQLServer.UNA.vistas
{
    partial class ClienteForm
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
            this.agregarCliente_btn = new System.Windows.Forms.Button();
            this.clientesDataGrit = new System.Windows.Forms.DataGridView();
            this.nombreColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoColuDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoColDTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrit)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarCliente_btn
            // 
            this.agregarCliente_btn.Location = new System.Drawing.Point(297, 47);
            this.agregarCliente_btn.Name = "agregarCliente_btn";
            this.agregarCliente_btn.Size = new System.Drawing.Size(152, 23);
            this.agregarCliente_btn.TabIndex = 0;
            this.agregarCliente_btn.Text = "Agregar cliente";
            this.agregarCliente_btn.UseVisualStyleBackColor = true;
            // 
            // clientesDataGrit
            // 
            this.clientesDataGrit.AllowUserToAddRows = false;
            this.clientesDataGrit.AllowUserToDeleteRows = false;
            this.clientesDataGrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColDTG,
            this.telefonoColuDTG,
            this.direccionColDTG,
            this.CorreoColDTG});
            this.clientesDataGrit.Location = new System.Drawing.Point(25, 125);
            this.clientesDataGrit.Name = "clientesDataGrit";
            this.clientesDataGrit.ReadOnly = true;
            this.clientesDataGrit.Size = new System.Drawing.Size(751, 239);
            this.clientesDataGrit.TabIndex = 16;
            // 
            // nombreColDTG
            // 
            this.nombreColDTG.HeaderText = "Nombre";
            this.nombreColDTG.Name = "nombreColDTG";
            this.nombreColDTG.ReadOnly = true;
            // 
            // telefonoColuDTG
            // 
            this.telefonoColuDTG.HeaderText = "Telefono";
            this.telefonoColuDTG.Name = "telefonoColuDTG";
            this.telefonoColuDTG.ReadOnly = true;
            // 
            // direccionColDTG
            // 
            this.direccionColDTG.HeaderText = "Direccion";
            this.direccionColDTG.Name = "direccionColDTG";
            this.direccionColDTG.ReadOnly = true;
            // 
            // CorreoColDTG
            // 
            this.CorreoColDTG.HeaderText = "Correo";
            this.CorreoColDTG.Name = "CorreoColDTG";
            this.CorreoColDTG.ReadOnly = true;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 415);
            this.Controls.Add(this.clientesDataGrit);
            this.Controls.Add(this.agregarCliente_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarCliente_btn;
        private System.Windows.Forms.DataGridView clientesDataGrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoColuDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionColDTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoColDTG;
    }
}