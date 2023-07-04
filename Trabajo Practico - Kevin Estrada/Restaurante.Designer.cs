namespace Trabajo_Practico___Kevin_Estrada
{
    partial class Restaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurante));
            this.btn_agregarPedido = new System.Windows.Forms.Button();
            this.listb_Productos = new System.Windows.Forms.ListBox();
            this.cmbBox_comida = new System.Windows.Forms.ComboBox();
            this.cmbBox_bebida = new System.Windows.Forms.ComboBox();
            this.lbl_bebida = new System.Windows.Forms.Label();
            this.lbl_comida = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_comensales = new System.Windows.Forms.TextBox();
            this.lbl_para = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_comensales = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_finalizar = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrarRest = new System.Windows.Forms.Button();
            this.btn_administrarUsuarios = new System.Windows.Forms.Button();
            this.cmbBox_mesas = new System.Windows.Forms.ComboBox();
            this.btn_agregarPedidoALaMesa = new System.Windows.Forms.Button();
            this.btn_nuevaMesa = new System.Windows.Forms.Button();
            this.btn_eliminarMesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregarPedido
            // 
            this.btn_agregarPedido.Location = new System.Drawing.Point(75, 66);
            this.btn_agregarPedido.Name = "btn_agregarPedido";
            this.btn_agregarPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarPedido.TabIndex = 6;
            this.btn_agregarPedido.Text = "Agregar";
            this.btn_agregarPedido.UseVisualStyleBackColor = true;
            this.btn_agregarPedido.Click += new System.EventHandler(this.btn_agregarPedido_Click);
            // 
            // listb_Productos
            // 
            this.listb_Productos.FormattingEnabled = true;
            this.listb_Productos.ItemHeight = 15;
            this.listb_Productos.Location = new System.Drawing.Point(75, 95);
            this.listb_Productos.Name = "listb_Productos";
            this.listb_Productos.Size = new System.Drawing.Size(262, 274);
            this.listb_Productos.TabIndex = 7;
            // 
            // cmbBox_comida
            // 
            this.cmbBox_comida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_comida.FormattingEnabled = true;
            this.cmbBox_comida.Location = new System.Drawing.Point(75, 8);
            this.cmbBox_comida.Name = "cmbBox_comida";
            this.cmbBox_comida.Size = new System.Drawing.Size(121, 23);
            this.cmbBox_comida.TabIndex = 8;
            // 
            // cmbBox_bebida
            // 
            this.cmbBox_bebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_bebida.FormattingEnabled = true;
            this.cmbBox_bebida.Location = new System.Drawing.Point(75, 37);
            this.cmbBox_bebida.Name = "cmbBox_bebida";
            this.cmbBox_bebida.Size = new System.Drawing.Size(121, 23);
            this.cmbBox_bebida.TabIndex = 9;
            // 
            // lbl_bebida
            // 
            this.lbl_bebida.AutoSize = true;
            this.lbl_bebida.Location = new System.Drawing.Point(3, 37);
            this.lbl_bebida.Name = "lbl_bebida";
            this.lbl_bebida.Size = new System.Drawing.Size(43, 15);
            this.lbl_bebida.TabIndex = 11;
            this.lbl_bebida.Text = "Bebida";
            // 
            // lbl_comida
            // 
            this.lbl_comida.AutoSize = true;
            this.lbl_comida.Location = new System.Drawing.Point(3, 11);
            this.lbl_comida.Name = "lbl_comida";
            this.lbl_comida.Size = new System.Drawing.Size(49, 15);
            this.lbl_comida.TabIndex = 12;
            this.lbl_comida.Text = "Comida";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(434, 241);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 23);
            this.txt_telefono.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(434, 131);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 14;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(434, 160);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido.TabIndex = 15;
            // 
            // txt_comensales
            // 
            this.txt_comensales.Location = new System.Drawing.Point(434, 212);
            this.txt_comensales.Name = "txt_comensales";
            this.txt_comensales.Size = new System.Drawing.Size(100, 23);
            this.txt_comensales.TabIndex = 16;
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Location = new System.Drawing.Point(343, 188);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(79, 15);
            this.lbl_para.TabIndex = 17;
            this.lbl_para.Text = "pedido para...";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nombre.Location = new System.Drawing.Point(377, 131);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 18;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_apellido.Location = new System.Drawing.Point(377, 160);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_apellido.TabIndex = 19;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_comensales
            // 
            this.lbl_comensales.AutoSize = true;
            this.lbl_comensales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comensales.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_comensales.Location = new System.Drawing.Point(357, 212);
            this.lbl_comensales.Name = "lbl_comensales";
            this.lbl_comensales.Size = new System.Drawing.Size(71, 15);
            this.lbl_comensales.TabIndex = 20;
            this.lbl_comensales.Text = "Comensales";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_telefono.Location = new System.Drawing.Point(370, 241);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 15);
            this.lbl_telefono.TabIndex = 21;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_finalizar
            // 
            this.lbl_finalizar.AutoSize = true;
            this.lbl_finalizar.Location = new System.Drawing.Point(343, 354);
            this.lbl_finalizar.Name = "lbl_finalizar";
            this.lbl_finalizar.Size = new System.Drawing.Size(164, 15);
            this.lbl_finalizar.TabIndex = 22;
            this.lbl_finalizar.Text = "Seleccione mesa para finalizar";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(653, 58);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar mesas";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrarRest
            // 
            this.btn_cerrarRest.Location = new System.Drawing.Point(604, 419);
            this.btn_cerrarRest.Name = "btn_cerrarRest";
            this.btn_cerrarRest.Size = new System.Drawing.Size(137, 23);
            this.btn_cerrarRest.TabIndex = 24;
            this.btn_cerrarRest.Text = "Calcular ganancias";
            this.btn_cerrarRest.UseVisualStyleBackColor = true;
            this.btn_cerrarRest.Click += new System.EventHandler(this.btn_cerrarRest_Click);
            // 
            // btn_administrarUsuarios
            // 
            this.btn_administrarUsuarios.Enabled = false;
            this.btn_administrarUsuarios.Location = new System.Drawing.Point(604, 390);
            this.btn_administrarUsuarios.Name = "btn_administrarUsuarios";
            this.btn_administrarUsuarios.Size = new System.Drawing.Size(137, 23);
            this.btn_administrarUsuarios.TabIndex = 25;
            this.btn_administrarUsuarios.Text = "Administrar Usuarios";
            this.btn_administrarUsuarios.UseVisualStyleBackColor = true;
            this.btn_administrarUsuarios.Visible = false;
            this.btn_administrarUsuarios.Click += new System.EventHandler(this.btn_administrarUsuarios_Click);
            // 
            // cmbBox_mesas
            // 
            this.cmbBox_mesas.FormattingEnabled = true;
            this.cmbBox_mesas.Location = new System.Drawing.Point(75, 400);
            this.cmbBox_mesas.Name = "cmbBox_mesas";
            this.cmbBox_mesas.Size = new System.Drawing.Size(262, 23);
            this.cmbBox_mesas.TabIndex = 26;
            // 
            // btn_agregarPedidoALaMesa
            // 
            this.btn_agregarPedidoALaMesa.Location = new System.Drawing.Point(357, 399);
            this.btn_agregarPedidoALaMesa.Name = "btn_agregarPedidoALaMesa";
            this.btn_agregarPedidoALaMesa.Size = new System.Drawing.Size(150, 24);
            this.btn_agregarPedidoALaMesa.TabIndex = 27;
            this.btn_agregarPedidoALaMesa.Text = "Agregar Pedido";
            this.btn_agregarPedidoALaMesa.UseVisualStyleBackColor = true;
            this.btn_agregarPedidoALaMesa.Click += new System.EventHandler(this.btn_agregarPedidoALaMesa_Click);
            // 
            // btn_nuevaMesa
            // 
            this.btn_nuevaMesa.Location = new System.Drawing.Point(653, 8);
            this.btn_nuevaMesa.Name = "btn_nuevaMesa";
            this.btn_nuevaMesa.Size = new System.Drawing.Size(100, 23);
            this.btn_nuevaMesa.TabIndex = 28;
            this.btn_nuevaMesa.Text = "Nueva mesa";
            this.btn_nuevaMesa.UseVisualStyleBackColor = true;
            this.btn_nuevaMesa.Click += new System.EventHandler(this.btn_nuevaMesa_Click);
            // 
            // btn_eliminarMesa
            // 
            this.btn_eliminarMesa.Location = new System.Drawing.Point(653, 33);
            this.btn_eliminarMesa.Name = "btn_eliminarMesa";
            this.btn_eliminarMesa.Size = new System.Drawing.Size(100, 23);
            this.btn_eliminarMesa.TabIndex = 29;
            this.btn_eliminarMesa.Text = "Eliminar Mesa";
            this.btn_eliminarMesa.UseVisualStyleBackColor = true;
            this.btn_eliminarMesa.Click += new System.EventHandler(this.btn_eliminarMesa_Click);
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 454);
            this.Controls.Add(this.btn_eliminarMesa);
            this.Controls.Add(this.btn_nuevaMesa);
            this.Controls.Add(this.btn_agregarPedidoALaMesa);
            this.Controls.Add(this.cmbBox_mesas);
            this.Controls.Add(this.btn_administrarUsuarios);
            this.Controls.Add(this.btn_cerrarRest);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_finalizar);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_comensales);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.txt_comensales);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_comida);
            this.Controls.Add(this.lbl_bebida);
            this.Controls.Add(this.cmbBox_bebida);
            this.Controls.Add(this.cmbBox_comida);
            this.Controls.Add(this.listb_Productos);
            this.Controls.Add(this.btn_agregarPedido);
            this.Name = "Restaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Restaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_agregarPedido;
        private ListBox listb_Productos;
        private ComboBox cmbBox_comida;
        private ComboBox cmbBox_bebida;
        private Label lbl_bebida;
        private Label lbl_comida;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_comensales;
        private Label lbl_para;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_comensales;
        private Label lbl_telefono;
        private Label lbl_finalizar;
        private Button btn_limpiar;
        private Button btn_cerrarRest;
        private Button btn_administrarUsuarios;
        private ComboBox cmbBox_mesas;
        private Button btn_agregarPedidoALaMesa;
        private Button btn_nuevaMesa;
        private Button btn_eliminarMesa;
    }
}