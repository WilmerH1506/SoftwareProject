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

namespace SoftwareProject.Formularios
{
    public partial class Login : Form
    {
        private SqlConnection cnx;
        private bool conectado;


        public Login()
        {
            InitializeComponent();
        }


        public SqlConnection CNX
        {
            get { return cnx; }
        }

        public bool Conectado
        {
            get { return conectado; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
