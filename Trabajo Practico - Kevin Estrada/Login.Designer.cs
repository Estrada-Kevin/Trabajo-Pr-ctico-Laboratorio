namespace Trabajo_Practico___Kevin_Estrada
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_autoCompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_usuario.Location = new System.Drawing.Point(416, 96);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(176, 23);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_contraseña.Location = new System.Drawing.Point(416, 159);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(176, 23);
            this.txt_contraseña.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usuario.Location = new System.Drawing.Point(339, 98);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(69, 21);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_contraseña.Location = new System.Drawing.Point(314, 159);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(96, 21);
            this.lbl_contraseña.TabIndex = 3;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(416, 230);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_autoCompletar
            // 
            this.btn_autoCompletar.Location = new System.Drawing.Point(416, 440);
            this.btn_autoCompletar.Name = "btn_autoCompletar";
            this.btn_autoCompletar.Size = new System.Drawing.Size(133, 23);
            this.btn_autoCompletar.TabIndex = 5;
            this.btn_autoCompletar.Text = "Auto completar";
            this.btn_autoCompletar.UseVisualStyleBackColor = true;
            this.btn_autoCompletar.Click += new System.EventHandler(this.btn_autoCompletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 485);
            this.Controls.Add(this.btn_autoCompletar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_contraseña;
        private Label lbl_usuario;
        private Label lbl_contraseña;
        private Button btn_ingresar;
        private Button btn_autoCompletar;
    }
}