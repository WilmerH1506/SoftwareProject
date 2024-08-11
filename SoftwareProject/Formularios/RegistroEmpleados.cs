﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProject.Formularios
{
    public partial class RegistroEmpleados : Form
    {
        String url = "Server= 3.128.144.165;" +
                           "DataBase= DB20222000953;" +
                           "User ID= david.rodriguez;" +
                           "password= DR20222000953;";
        SqlConnection conexion;
        private SqlConnection cnx;
        private int userID;
        public RegistroEmpleados(SqlConnection conexion, int usuario)
        {
            InitializeComponent();
            cnx= conexion;
            userID = usuario;
            conexion = new SqlConnection(url);
        }

        private void Registro_Click(object sender, EventArgs e)
        {

        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            String[] Areas = { "Administracion Gerencial", "Tecnico Redes" };
            cmbAreas.Items.AddRange(Areas);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (UsuarioExiste(txtUsername.Text))
            {
                MessageBox.Show("El nombre de usuario que desea registrar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Autorizado(cnx, userID);
                    Commando(cnx, userID);
                    MessageBox.Show("Se ha Registrado Exitosamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private SqlCommand Commando(SqlConnection conexion, int user) {

            try
            {
                SqlCommand cmd = new SqlCommand("spRegistrarEmpleadosJefes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                String consulta = "Select * from Empleado where UsuarioId = @user";
                SqlCommand leerID = new SqlCommand(consulta, conexion);
                leerID.Parameters.AddWithValue("@user", user);
                SqlDataReader reader = leerID.ExecuteReader();
                int id = 0;

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["EmpleadoId"]);
                }
                reader.Close();
                leerID.Dispose();

                cmd.Parameters.AddWithValue("@Name", txtNombre.Text);
                cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                cmd.Parameters.AddWithValue("@Cel", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Area", cmbAreas.SelectedItem);
                cmd.Parameters.AddWithValue("@Sueldo", txtSueldo.Text);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                bool x = CHKBox();
                if (x == true)
                {
                    cmd.Parameters.AddWithValue("@Jefe", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Jefe", id);
                }

                cmd.Parameters.AddWithValue("Pass", txtPass.Text);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return cmd;
            }
            catch (SqlException ex)
            {
              MessageBox.Show("Ocurrio un Error "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           return null;
        }

        private bool CHKBox() 
        {
            bool ConfirmarF = false;

            if (chkJefe.Checked)
            {
                ConfirmarF = true;
            }
            else
            {
                ConfirmarF = false;
            }
            return ConfirmarF;
        }
        private bool Autorizado(SqlConnection conexion, int user)
        {
            bool acceso = false;
            try
            {

                SqlCommand cmd = new SqlCommand("spJefes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userid", user);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                if (reader.IsDBNull(0))
                {
                    acceso = true;
                    Console.WriteLine("SI FUnciona");
                }
            }
                else
                {
                    Console.WriteLine("Nuuuu");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return acceso;
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
    }
}
