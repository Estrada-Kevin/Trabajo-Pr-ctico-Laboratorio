namespace Trabajo_Practico___Kevin_Estrada
{
    partial class AdministracionForm
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
            this.cmbx_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseñaNueva = new System.Windows.Forms.Label();
            this.txt_contraseñaNueva = new System.Windows.Forms.TextBox();
            this.btn_cambiarContraseña = new System.Windows.Forms.Button();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbx_usuario
            // 
            this.cmbx_usuario.FormattingEnabled = true;
            this.cmbx_usuario.Location = new System.Drawing.Point(68, 12);
            this.cmbx_usuario.Name = "cmbx_usuario";
            this.cmbx_usuario.Size = new System.Drawing.Size(223, 23);
            this.cmbx_usuario.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(12, 15);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(47, 15);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseñaNueva
            // 
            this.lbl_contraseñaNueva.AutoSize = true;
            this.lbl_contraseñaNueva.Location = new System.Drawing.Point(12, 54);
            this.lbl_contraseñaNueva.Name = "lbl_contraseñaNueva";
            this.lbl_contraseñaNueva.Size = new System.Drawing.Size(102, 15);
            this.lbl_contraseñaNueva.TabIndex = 2;
            this.lbl_contraseñaNueva.Text = "Contraseña nueva";
            // 
            // txt_contraseñaNueva
            // 
            this.txt_contraseñaNueva.Location = new System.Drawing.Point(124, 46);
            this.txt_contraseñaNueva.Name = "txt_contraseñaNueva";
            this.txt_contraseñaNueva.Size = new System.Drawing.Size(167, 23);
            this.txt_contraseñaNueva.TabIndex = 3;
            // 
            // btn_cambiarContraseña
            // 
            this.btn_cambiarContraseña.Location = new System.Drawing.Point(157, 94);
            this.btn_cambiarContraseña.Name = "btn_cambiarContraseña";
            this.btn_cambiarContraseña.Size = new System.Drawing.Size(134, 23);
            this.btn_cambiarContraseña.TabIndex = 4;
            this.btn_cambiarContraseña.Text = "Cambiar Contraseña";
            this.btn_cambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(12, 123);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(121, 23);
            this.btn_eliminarUsuario.TabIndex = 5;
            this.btn_eliminarUsuario.Text = "Eliminar Usuario";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(157, 123);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(134, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.Location = new System.Drawing.Point(12, 94);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(121, 23);
            this.btn_agregarUsuario.TabIndex = 7;
            this.btn_agregarUsuario.Text = "Agregar Usuario";
            this.btn_agregarUsuario.UseVisualStyleBackColor = true;
            // 
            // AdministracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 164);
            this.ControlBox = false;
            this.Controls.Add(this.btn_agregarUsuario);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.btn_cambiarContraseña);
            this.Controls.Add(this.txt_contraseñaNueva);
            this.Controls.Add(this.lbl_contraseñaNueva);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.cmbx_usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministracionForm";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.AdministracionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbx_usuario;
        private Label lbl_usuario;
        private Label lbl_contraseñaNueva;
        private TextBox txt_contraseñaNueva;
        private Button btn_cambiarContraseña;
        private Button btn_eliminarUsuario;
        private Button btn_salir;
        private Button btn_agregarUsuario;
    }
}