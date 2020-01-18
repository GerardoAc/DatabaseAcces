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

namespace PracticaMySQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
