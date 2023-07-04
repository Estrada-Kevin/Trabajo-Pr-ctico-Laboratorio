namespace Trabajo_Practico___Kevin_Estrada
{
    partial class Informes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informes));
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_json = new System.Windows.Forms.Button();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(29, 12);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(125, 23);
            this.btn_csv.TabIndex = 0;
            this.btn_csv.Text = "Guardar como CSV";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // btn_json
            // 
            this.btn_json.Location = new System.Drawing.Point(29, 41);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(125, 23);
            this.btn_json.TabIndex = 1;
            this.btn_json.Text = "Guardar como JSON";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // btn_PDF
            // 
            this.btn_PDF.Location = new System.Drawing.Point(29, 70);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(125, 23);
            this.btn_PDF.TabIndex = 2;
            this.btn_PDF.Text = "Guardar como PDF";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(29, 99);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(184, 133);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_json);
            this.Controls.Add(this.btn_csv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_csv;
        private Button btn_json;
        private Button btn_PDF;
        private Button btn_salir;
    }
}