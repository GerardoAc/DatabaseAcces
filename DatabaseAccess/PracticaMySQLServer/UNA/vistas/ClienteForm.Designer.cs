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
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrit)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarCliente_btn
            // 
            this.agregarCliente_btn.Location = new System.Drawing.Point(41, 60);
            this.agregarCliente_btn.Name = "agregarCliente_btn";
            this.agregarCliente_btn.Size = new System.Drawing.Size(123, 23);
            this.agregarCliente_btn.TabIndex = 0;
            this.agregarCliente_btn.Text = "Agregar cliente";
            this.agregarCliente_btn.UseVisualStyleBackColor = true;
            this.agregarCliente_btn.Click += new System.EventHandler(this.agregarCliente_btn_Click);
            // 
            // clientesDataGrit
            // 
            this.clientesDataGrit.AllowUserToAddRows = false;
            this.clientesDataGrit.AllowUserToDeleteRows = false;
            this.clientesDataGrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGrit.Location = new System.Drawing.Point(25, 125);
            this.clientesDataGrit.Name = "clientesDataGrit";
            this.clientesDataGrit.ReadOnly = true;
            this.clientesDataGrit.Size = new System.Drawing.Size(751, 239);
            this.clientesDataGrit.TabIndex = 16;
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
    }
}