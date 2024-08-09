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
using System.Diagnostics;

namespace SoftwareProject.Formularios
{ 
    public partial class RegistroUsuarios : Form
    {
        String url = "Server= 3.128.144.165;" +
                            "DataBase= DB20222000953;" +
                            "User ID= david.rodriguez;" +
                            "password= DR20222000953;";
        SqlConnection conexion;
        SqlDataAdapter adpUserName;
        private SqlConnection cnx;
        private bool conectado;
            
        public RegistroUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    

            conexion = new SqlConnection(url);
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(RegistroUsuarios_btnCerrar);
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (UsuarioExiste(txtNombre.Text))
            {
                MessageBox.Show("El usuario que desea registrar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    String url = "Server= 3.128.144.165;" +
                                "DataBase= DB20222000953;" +
                                "User ID= david.rodriguez;" +
                                "password= DR20222000953;";
                    conectado = false;
                    cnx = new SqlConnection(url);
                    cnx.Open();
                    conectado = true;

                    Comando("spRegistrarUsuarios", cnx);
                    MessageBox.Show("Se ha Registrado Exitosamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    this.FormClosed += new FormClosedEventHandler(RegistroUsuarios_btnCerrar);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Pudo conectar y " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

     


        }
        private SqlCommand Comando(String sql,SqlConnection cnx) 
        { 

            
        SqlCommand cmd= new SqlCommand(sql,cnx);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Contra", txtPass.Text);
            cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
            cmd.Parameters.AddWithValue("@Email", txtMail.Text);
            cmd.Parameters.AddWithValue("@Cel", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return cmd;
        }

        private bool UsuarioExiste(string nombreUsuario)
        {
            bool existe = false;
            try
            {
                SqlConnection cnx = new SqlConnection(url);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.fnUsuarioExiste(@NombreUsuario)", cnx);

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                existe = (bool)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el usuario existe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }


        private void RegistroUsuarios_btnCerrar(object sender, FormClosedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void btnJefes_Click(object sender, EventArgs e)
        {

         
          


        }

        //private void txtNombre_Enter(object sender, EventArgs e)
        //{
        //    if (txtNombre.Text == "Nombre")
        //    {
        //        txtNombre.Text = "";
        //    }
        //}

        //private void txtNombre_Leave(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrWhiteSpace(txtNombre.Text))
        //    {
        //        txtNombre.Text = "Nombre";
        //    }

        //}
    }
}
