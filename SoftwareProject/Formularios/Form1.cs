using SoftwareProject.Formularios;
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

namespace SoftwareProject
{
    public partial class Form1 : Form
    {
        private SqlConnection cnx;
        private int userID;
        public Form1(SqlConnection conexion, int usuario)
        {
            InitializeComponent();
            Design();
           cnx= conexion;
            userID = usuario;
        }

        #region Metodos

        private void Design()
        {

            subMenuClie.Visible = false;
            subMenuUsers.Visible = false;
        }

        private void Ocultar()
        { 
            if (subMenuClie.Visible == true)
            {
                subMenuClie.Visible = false;
            }

            if (subMenuUsers.Visible == true)
            {
                subMenuUsers.Visible = false;
            }
        
        }


        private void Mostrar(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                Ocultar();
                subMenu.Visible = true;
            }
            else 
                subMenu.Visible = false; 
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Mostrar(subMenuUsers);
            Console.WriteLine(userID);



        }

        private void btnAggUser_Click(object sender, EventArgs e)
        {
            Ocultar();
            RegistroEmpleados frmE = new RegistroEmpleados(cnx,userID);
            frmE.ShowDialog();
           
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prueba());
            Ocultar();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Mostrar(subMenuClie);
        }

        private void btnAggClie_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void btnEditClie_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void btnDeleteClie_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private Form activeForm = null;
        private void OpenChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(childForm);
            panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Metodos

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private int TipoAutorizado(SqlConnection conexion, int usuario)
        { 
        int quien = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("spJefes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userid", usuario);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read()) { 
                if (reader.IsDBNull(0))
                {
                    quien = 1;

                }
                if (!reader.IsDBNull(0))
                {
                    quien = 2;
                }
                if (!reader.HasRows)
                {
                    quien = 0;
                }
            }
                reader.Close();
                return quien;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return quien;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            if (TipoAutorizado(cnx, userID) != 1)
            { 
           btnEmpleados.Visible = false;
                
            }

        }
    }
}
