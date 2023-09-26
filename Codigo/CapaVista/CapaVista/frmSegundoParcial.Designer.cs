
namespace CapaVista
{
    partial class frmSegundoParcial
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
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_ayudas = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(553, 55);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(111, 23);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar Datos";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_ayudas
            // 
            this.btn_ayudas.Location = new System.Drawing.Point(553, 100);
            this.btn_ayudas.Name = "btn_ayudas";
            this.btn_ayudas.Size = new System.Drawing.Size(111, 23);
            this.btn_ayudas.TabIndex = 1;
            this.btn_ayudas.Text = "Ayudas";
            this.btn_ayudas.UseVisualStyleBackColor = true;
            this.btn_ayudas.Click += new System.EventHandler(this.btn_ayudas_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(553, 146);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(111, 23);
            this.btn_reportes.TabIndex = 2;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(553, 188);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(111, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carol Cecilia Chuy Escobar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0901-20-1381";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla: Estudiante";
            // 
            // Dgv_consulta
            // 
            this.Dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consulta.Location = new System.Drawing.Point(39, 176);
            this.Dgv_consulta.Name = "Dgv_consulta";
            this.Dgv_consulta.Size = new System.Drawing.Size(466, 135);
            this.Dgv_consulta.TabIndex = 7;
            // 
            // frmSegundoParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 363);
            this.Controls.Add(this.Dgv_consulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_ayudas);
            this.Controls.Add(this.btn_cargar);
            this.Name = "frmSegundoParcial";
            this.Text = "frmSegundoParcial";
            this.Load += new System.EventHandler(this.frmSegundoParcial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_ayudas;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_consulta;
    }
}