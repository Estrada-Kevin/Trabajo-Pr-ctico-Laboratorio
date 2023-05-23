namespace Trabajo_Practico___Kevin_Estrada
{
    partial class Recibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibo));
            this.lbl_agradecimiento = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.lbl_costoFinal = new System.Windows.Forms.Label();
            this.listBox_detallesCompra = new System.Windows.Forms.ListBox();
            this.btn_propina = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_agradecimiento
            // 
            this.lbl_agradecimiento.AutoSize = true;
            this.lbl_agradecimiento.Font = new System.Drawing.Font("Sitka Small Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_agradecimiento.Location = new System.Drawing.Point(27, 9);
            this.lbl_agradecimiento.Name = "lbl_agradecimiento";
            this.lbl_agradecimiento.Size = new System.Drawing.Size(305, 39);
            this.lbl_agradecimiento.TabIndex = 0;
            this.lbl_agradecimiento.Text = "Gracias por su visita";
            this.lbl_agradecimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Font = new System.Drawing.Font("Pristina", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreCliente.Location = new System.Drawing.Point(112, 60);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(129, 27);
            this.lbl_nombreCliente.TabIndex = 1;
            this.lbl_nombreCliente.Text = "Nombre del cliente";
            // 
            // lbl_costoFinal
            // 
            this.lbl_costoFinal.AutoSize = true;
            this.lbl_costoFinal.Location = new System.Drawing.Point(236, 224);
            this.lbl_costoFinal.Name = "lbl_costoFinal";
            this.lbl_costoFinal.Size = new System.Drawing.Size(64, 15);
            this.lbl_costoFinal.TabIndex = 2;
            this.lbl_costoFinal.Text = "Costo final";
            this.lbl_costoFinal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBox_detallesCompra
            // 
            this.listBox_detallesCompra.FormattingEnabled = true;
            this.listBox_detallesCompra.ItemHeight = 15;
            this.listBox_detallesCompra.Location = new System.Drawing.Point(27, 90);
            this.listBox_detallesCompra.Name = "listBox_detallesCompra";
            this.listBox_detallesCompra.Size = new System.Drawing.Size(311, 124);
            this.listBox_detallesCompra.TabIndex = 3;
            // 
            // btn_propina
            // 
            this.btn_propina.Location = new System.Drawing.Point(12, 220);
            this.btn_propina.Name = "btn_propina";
            this.btn_propina.Size = new System.Drawing.Size(109, 23);
            this.btn_propina.TabIndex = 4;
            this.btn_propina.Text = "Dejar Propina";
            this.btn_propina.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(123, 220);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_propina);
            this.Controls.Add(this.listBox_detallesCompra);
            this.Controls.Add(this.lbl_costoFinal);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.lbl_agradecimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_agradecimiento;
        private Label lbl_nombreCliente;
        private Label lbl_costoFinal;
        private ListBox listBox_detallesCompra;
        private Button btn_propina;
        private Button btn_salir;
    }
}