using SoftwareProject.Formularios;
using SoftwareProject.Formularios.Formularios_de_DELETE;
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
    public partial class Menu : Form
    {
        private SqlConnection cnx;
        private int userID;
        public Menu(SqlConnection conexion, int usuario)
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
            subMenuEmpleado.Visible = false;
            subMenuInventario.Visible = false;
        }

        private void Ocultar()
        { 
            if (subMenuClie.Visible == true)
            {
                subMenuClie.Visible = false;
            }

            if (subMenuEmpleado.Visible == true)
            {
                subMenuEmpleado.Visible = false;
            }

            if (subMenuInventario.Visible == true)
            {
                subMenuInventario.Visible = false;
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
            Mostrar(subMenuEmpleado);
        }

        private void btnAggUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegistroEmpleados(cnx, userID));
            Ocultar();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteEmpleados(cnx));
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

        private Form activeForm = null;
        public void OpenChildForm (Form childForm)
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Mostrar(subMenuInventario);
        }

        private void btnCompraInv_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void btnInfoInv_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        #endregion Metodos
    }
}
