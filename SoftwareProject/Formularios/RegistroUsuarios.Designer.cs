namespace SoftwareProject.Formularios
{
    partial class RegistroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.PRegistro = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PRegistro
            // 
            this.PRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PRegistro.Controls.Add(this.txtPass);
            this.PRegistro.Controls.Add(this.btnCerrar);
            this.PRegistro.Controls.Add(this.btnIngresar);
            this.PRegistro.Controls.Add(this.txtDireccion);
            this.PRegistro.Controls.Add(this.txtTelefono);
            this.PRegistro.Controls.Add(this.txtMail);
            this.PRegistro.Controls.Add(this.txtDNI);
            this.PRegistro.Controls.Add(this.txtNombre);
            this.PRegistro.Controls.Add(this.Registro);
            this.PRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.PRegistro.Location = new System.Drawing.Point(852, 0);
            this.PRegistro.Name = "PRegistro";
            this.PRegistro.Size = new System.Drawing.Size(359, 570);
            this.PRegistro.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(90, 208);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(130, 23);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "Contraseña";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(330, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 27);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIngresar.Location = new System.Drawing.Point(74, 404);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(217, 40);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "REGISTRAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(90, 330);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(130, 22);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(90, 288);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(130, 22);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(90, 247);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 22);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "Correo";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(90, 162);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(130, 23);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.Text = "Identidad";
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registro.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Registro.Location = new System.Drawing.Point(74, 16);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(157, 42);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registros";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(589, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 570);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(46, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.PRegistro.ResumeLayout(false);
            this.PRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PRegistro;
        private System.Windows.Forms.Label Registro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtPass;
    }
}