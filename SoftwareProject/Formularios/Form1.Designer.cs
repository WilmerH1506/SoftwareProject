namespace SoftwareProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LateralMenu = new System.Windows.Forms.Panel();
            this.subMenuClie = new System.Windows.Forms.Panel();
            this.btnDeleteClie = new System.Windows.Forms.Button();
            this.btnEditClie = new System.Windows.Forms.Button();
            this.btnAggClie = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.subMenuUsers = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAggEmpleado = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LateralMenu.SuspendLayout();
            this.subMenuClie.SuspendLayout();
            this.subMenuUsers.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LateralMenu
            // 
            this.LateralMenu.AutoScroll = true;
            this.LateralMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LateralMenu.Controls.Add(this.subMenuClie);
            this.LateralMenu.Controls.Add(this.btnClientes);
            this.LateralMenu.Controls.Add(this.subMenuUsers);
            this.LateralMenu.Controls.Add(this.btnEmpleados);
            this.LateralMenu.Controls.Add(this.panelLogo);
            this.LateralMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LateralMenu.Location = new System.Drawing.Point(0, 0);
            this.LateralMenu.Name = "LateralMenu";
            this.LateralMenu.Size = new System.Drawing.Size(281, 622);
            this.LateralMenu.TabIndex = 0;
            // 
            // subMenuClie
            // 
            this.subMenuClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuClie.Controls.Add(this.btnDeleteClie);
            this.subMenuClie.Controls.Add(this.btnEditClie);
            this.subMenuClie.Controls.Add(this.btnAggClie);
            this.subMenuClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuClie.Location = new System.Drawing.Point(0, 361);
            this.subMenuClie.Name = "subMenuClie";
            this.subMenuClie.Size = new System.Drawing.Size(281, 147);
            this.subMenuClie.TabIndex = 3;
            // 
            // btnDeleteClie
            // 
            this.btnDeleteClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteClie.FlatAppearance.BorderSize = 0;
            this.btnDeleteClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteClie.Location = new System.Drawing.Point(0, 90);
            this.btnDeleteClie.Name = "btnDeleteClie";
            this.btnDeleteClie.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnDeleteClie.Size = new System.Drawing.Size(281, 45);
            this.btnDeleteClie.TabIndex = 3;
            this.btnDeleteClie.Text = "Eliminar";
            this.btnDeleteClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClie.UseVisualStyleBackColor = true;
            // 
            // btnEditClie
            // 
            this.btnEditClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditClie.FlatAppearance.BorderSize = 0;
            this.btnEditClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditClie.Location = new System.Drawing.Point(0, 45);
            this.btnEditClie.Name = "btnEditClie";
            this.btnEditClie.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnEditClie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditClie.Size = new System.Drawing.Size(281, 45);
            this.btnEditClie.TabIndex = 2;
            this.btnEditClie.Text = "Editar";
            this.btnEditClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClie.UseVisualStyleBackColor = true;
            this.btnEditClie.Click += new System.EventHandler(this.btnEditClie_Click);
            // 
            // btnAggClie
            // 
            this.btnAggClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggClie.FlatAppearance.BorderSize = 0;
            this.btnAggClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggClie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAggClie.Location = new System.Drawing.Point(0, 0);
            this.btnAggClie.Name = "btnAggClie";
            this.btnAggClie.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAggClie.Size = new System.Drawing.Size(281, 45);
            this.btnAggClie.TabIndex = 1;
            this.btnAggClie.Text = "Agregar";
            this.btnAggClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggClie.UseVisualStyleBackColor = true;
            this.btnAggClie.Click += new System.EventHandler(this.btnAggClie_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 310);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(281, 51);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // subMenuUsers
            // 
            this.subMenuUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuUsers.Controls.Add(this.btnDeleteUser);
            this.subMenuUsers.Controls.Add(this.btnEditUser);
            this.subMenuUsers.Controls.Add(this.btnAggEmpleado);
            this.subMenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsers.Location = new System.Drawing.Point(0, 163);
            this.subMenuUsers.Name = "subMenuUsers";
            this.subMenuUsers.Size = new System.Drawing.Size(281, 147);
            this.subMenuUsers.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 90);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(281, 45);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditUser.Location = new System.Drawing.Point(0, 45);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnEditUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditUser.Size = new System.Drawing.Size(281, 45);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAggEmpleado
            // 
            this.btnAggEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAggEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAggEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnAggEmpleado.Name = "btnAggEmpleado";
            this.btnAggEmpleado.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAggEmpleado.Size = new System.Drawing.Size(281, 45);
            this.btnAggEmpleado.TabIndex = 1;
            this.btnAggEmpleado.Text = "Agregar";
            this.btnAggEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggEmpleado.UseVisualStyleBackColor = true;
            this.btnAggEmpleado.Click += new System.EventHandler(this.btnAggUser_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 112);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(281, 51);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleado";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(281, 112);
            this.panelLogo.TabIndex = 1;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelForms.Controls.Add(this.pictureBox1);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(281, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(767, 622);
            this.panelForms.TabIndex = 2;
            this.panelForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForms_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SoftwareProject.Properties.Resources.software_development;
            this.pictureBox1.Location = new System.Drawing.Point(162, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1048, 622);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.LateralMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Servicio Tecnico Avanzado";
            this.LateralMenu.ResumeLayout(false);
            this.subMenuClie.ResumeLayout(false);
            this.subMenuUsers.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LateralMenu;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel subMenuUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAggEmpleado;
        private System.Windows.Forms.Panel subMenuClie;
        private System.Windows.Forms.Button btnDeleteClie;
        private System.Windows.Forms.Button btnEditClie;
        private System.Windows.Forms.Button btnAggClie;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

