using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareProject.Formularios.Formularios_de_DELETE
{
    public partial class DeleteEmpleados : Form
    {
        SqlConnection cnx;
        DataTable TabEmpleados;
        
        public DeleteEmpleados(SqlConnection conexion)
        {
            InitializeComponent();
            cnx= conexion;
        }

        private void DeleteEmpleados_Load(object sender, EventArgs e)
        {
            
            try
            {
                TabEmpleados = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Empleado",cnx);
                adapter.Fill(TabEmpleados);
                dataGridView1.DataSource = TabEmpleados;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) 
            {

                int EmpleadoUserId = (int)TabEmpleados.DefaultView[dataGridView1.CurrentRow.Index]["UsuarioId"];
                Console.WriteLine(EmpleadoUserId);
                DeleteEmpleadosProc(cnx, EmpleadoUserId);
                dataGridView1.Refresh();
                

            }

        }
        private SqlCommand DeleteEmpleadosProc(SqlConnection conexion, int usuarioID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmpleados", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", usuarioID);
                DialogResult r = MessageBox.Show("Estas Seguro que quieres Eliminar al Usuario" + usuarioID + "?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                return cmd;
            }
            catch (SqlException ex)
            {
               MessageBox.Show("Ocurrio un Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;
        }
    }
}
