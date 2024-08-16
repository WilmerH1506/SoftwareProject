using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareProject.Formularios.CRUD_Clientes
{
    public partial class ConsultarClientes : Form
    {
        private SqlConnection cnx;
        
        public ConsultarClientes(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
            //probando git
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {



        }
    }
}
