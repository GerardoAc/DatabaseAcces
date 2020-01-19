using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaMySQLServer.UNA.vistas;
namespace PracticaMySQLServer
{
    public partial class Form1 : Form
    {
        Factura factura = new Factura();
        ClienteForm cliente = new ClienteForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Object hija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form h = hija as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(h);
            this.panelContenedor.Tag = h;
            h.Show();
        }
        private void facturaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(factura);
        }

        private void productosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(factura);
        }

        private void clientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(cliente);
            cliente.cargarDatos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // string ruta = @" server = localhost; user id = root; persistsecurityinfo = True; database = facturador;";
            MySqlBD mySqlBD = new MySqlBD();
            mySqlBD.ConnectionString= System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlBD.OpenConnection();


        }
    }
}
