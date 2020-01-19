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

namespace PracticaMySQLServer.UNA.vistas
{
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void guardarClienteBtn_Click(object sender, EventArgs e)
        {
            MySqlBD mySqlBD = new MySqlBD();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlBD.OpenConnection();
            //mySqlBD.BeginTransaction();
            string query = string.Format("INSERT INTO clientes(nombre, telefono, correo)VALUES('{0}','{1}','{2}' )",
                nombreTxt.Text,telefonoTxt.Text,correoTxt.Text);
            //"INSERT INTO clientes(nombre,telefono,correo)VALUES('rube','71363520','ruben01@gmail.com')";
            mySqlBD.EjectSQL(query);
           //mySqlBD.CommitTransaction();
            mySqlBD.CloseConnection();
            this.Hide();
        }
    }
}
