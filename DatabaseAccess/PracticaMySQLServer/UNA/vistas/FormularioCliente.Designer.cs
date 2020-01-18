namespace PracticaMySQLServer.UNA.vistas
{
    partial class FormularioCliente
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
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.correoTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.guardarClienteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(140, 63);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreTxt.TabIndex = 0;
            // 
            // correoTxt
            // 
            this.correoTxt.Location = new System.Drawing.Point(142, 170);
            this.correoTxt.Name = "correoTxt";
            this.correoTxt.Size = new System.Drawing.Size(100, 20);
            this.correoTxt.TabIndex = 1;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(142, 110);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(100, 20);
            this.telefonoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(142, 225);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(100, 20);
            this.direccionTxt.TabIndex = 6;
            // 
            // guardarClienteBtn
            // 
            this.guardarClienteBtn.Location = new System.Drawing.Point(154, 265);
            this.guardarClienteBtn.Name = "guardarClienteBtn";
            this.guardarClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarClienteBtn.TabIndex = 8;
            this.guardarClienteBtn.Text = "Gardar";
            this.guardarClienteBtn.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.guardarClienteBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.correoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox correoTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.Button guardarClienteBtn;
    }
}