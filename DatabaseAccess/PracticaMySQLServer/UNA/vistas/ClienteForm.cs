using DatabaseAccess;
using System.Windows.Forms;

namespace PracticaMySQLServer.UNA.vistas
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
        public void cargarDatos() {
            MySqlBD mySqlBD = new MySqlBD();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlBD.OpenConnection();
            string query = "Select *From clientes";
            clientesDataGrit.DataSource = mySqlBD.QuerySQL(query);
          
                mySqlBD.CloseConnection();
        }

        private void agregarCliente_btn_Click(object sender, System.EventArgs e)
        {
            FormularioCliente cliente = new FormularioCliente();
            cliente.ShowDialog();

        }

        private void ClienteForm_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            MySqlBD mySqlBD = new MySqlBD();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlBD.OpenConnection();
            string query = "Select *From clientes Where nombre='"+textBox1.Text+"'";
            clientesDataGrit.DataSource = mySqlBD.QuerySQL(query);
            mySqlBD.CloseConnection();
           
        }
    }
}
