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

namespace SoftwareProject.Formularios.CRUD_Clientes
{
    public partial class EditarCliente : Form
    {
        private SqlConnection cnx;
        private int ClienteID;

        public EditarCliente(SqlConnection conexion , int Cliente)
        {
            InitializeComponent();
            cnx= conexion;
            ClienteID = Cliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

            TablaCliente(cnx, ClienteID);


        }
        private void TablaCliente(SqlConnection conexion,int cliente)
        {

            try
            {
                String consulta = "Select * from vConsultarClientes where Clienteid = " + cliente;
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtUsername.Text = reader["Username"].ToString();
                    txtDNI.Text = reader["DNI"].ToString();
                    txtCorreo.Text = reader["E_mail"].ToString();
                    txtTelefono.Text = reader["Telefono"].ToString();
                    txtDireccion.Text = reader["Direccion"].ToString();
                    if (reader["Estado"].ToString() == "A")
                    {
                        chkEstado.Checked = true;
                    }
                    if (reader["Estado"].ToString() == "I")
                    {
                        chkEstado.Checked = false;
                    }



                }
                reader.Close();
                cmd.Dispose();
                
                
                    SqlCommand cmd2 = new SqlCommand("Select * from vClientesInactivos where Clienteid = " + cliente, conexion);
                    SqlDataReader rdr = cmd2.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtNombre.Text = rdr["Nombre"].ToString();
                        txtUsername.Text = rdr["Username"].ToString();
                        txtDNI.Text = rdr["DNI"].ToString();
                        txtCorreo.Text = rdr["E_mail"].ToString();
                        txtTelefono.Text = rdr["Telefono"].ToString();
                        txtDireccion.Text = rdr["Direccion"].ToString();
                        if (rdr["Estado"].ToString() == "A")
                        {
                            chkEstado.Checked = true;
                        }
                        if (rdr["Estado"].ToString() == "I")
                        {
                            chkEstado.Checked = false;
                        }



                    }
                    rdr.Close();
                    cmd2.Dispose();
                
            }
            catch (SqlException ex) 
            { MessageBox.Show("Ocurrio un Error " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spEditarClientes", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                cmd.Parameters.AddWithValue("@Mail", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
               
                if (chkEstado.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", "A");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", "I");
                }



                if (ValidacionesClientes() == true)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Valores guardados correctamente ", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    cmd.Dispose();
                }
              
             
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidacionesClientes()
        {
            bool CONTINUAR = true;
            
            if (txtNombre.Text.Length < 3 || System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"\d")) { 
                MessageBox.Show("El Nombre debe tener almenos 3 Letras y que no tenga numeros", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR = false;
            }
            if (txtUsername.Text.Length < 2)
            {
                MessageBox.Show("El USERNAME debe tener almenos 2 Caracteres", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR = false;
            }
            if(txtCorreo.Text.Length<6 || !txtCorreo.Text.Contains("@") && !txtCorreo.Text.Contains(".com"))
            {
                MessageBox.Show("El CORREO debe tener almenos 1 caracter antes del @, incluir @ y tambien un .com ", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR = false;
            }
            if (txtDNI.Text.Length < 15 || !txtDNI.Text.Contains("-"))
            {
                MessageBox.Show("El DNI debe contener 15 caracteres de la siguiente forma 0000-0000-00000", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR = false;
            }
            if(txtTelefono.Text.Length<8 || !System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("Debe INgresar valores correctos y un numero adecuado para Telefono", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR = false;
            }
            if (txtDireccion.Text.Length <= 0 || System.Text.RegularExpressions.Regex.IsMatch(txtDireccion.Text, @"\d"))
            {
                MessageBox.Show("Ingrese Departamento y Colonia", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                CONTINUAR=false;
            }
           
            return CONTINUAR;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
