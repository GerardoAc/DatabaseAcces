namespace PracticaMySQLServer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.facturaBtn = new System.Windows.Forms.Button();
            this.productosBtn = new System.Windows.Forms.Button();
            this.clientesBtn = new System.Windows.Forms.Button();

            this.panelContenedor = new System.Windows.Forms.Panel();

            this.button1 = new System.Windows.Forms.Button();

            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.facturaBtn);
            this.flowLayoutPanel1.Controls.Add(this.productosBtn);
            this.flowLayoutPanel1.Controls.Add(this.clientesBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de facturacion.";
            // 
            // facturaBtn
            // 
            this.facturaBtn.Location = new System.Drawing.Point(174, 3);
            this.facturaBtn.Name = "facturaBtn";
            this.facturaBtn.Size = new System.Drawing.Size(104, 37);
            this.facturaBtn.TabIndex = 0;
            this.facturaBtn.Text = "Nueva factura";
            this.facturaBtn.UseVisualStyleBackColor = true;
            this.facturaBtn.Click += new System.EventHandler(this.facturaBtn_Click);
            // 
            // productosBtn
            // 
            this.productosBtn.Location = new System.Drawing.Point(284, 3);
            this.productosBtn.Name = "productosBtn";
            this.productosBtn.Size = new System.Drawing.Size(104, 37);
            this.productosBtn.TabIndex = 2;
            this.productosBtn.Text = "Productos";
            this.productosBtn.UseVisualStyleBackColor = true;
            this.productosBtn.Click += new System.EventHandler(this.productosBtn_Click);
            // 
            // clientesBtn
            // 
            this.clientesBtn.Location = new System.Drawing.Point(394, 3);
            this.clientesBtn.Name = "clientesBtn";
            this.clientesBtn.Size = new System.Drawing.Size(104, 37);
            this.clientesBtn.TabIndex = 3;
            this.clientesBtn.Text = "Clientes";
            this.clientesBtn.UseVisualStyleBackColor = true;
            this.clientesBtn.Click += new System.EventHandler(this.clientesBtn_Click);
            // 
            // panelContenedor
            // 

            this.panelContenedor.Location = new System.Drawing.Point(-3, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(807, 415);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Controls.Add(this.button1);

            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelContenedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button facturaBtn;
        private System.Windows.Forms.Button productosBtn;
        private System.Windows.Forms.Button clientesBtn;
 		private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button1;
		
    }
}

