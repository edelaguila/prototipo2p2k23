
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
            this.Btn_cargardatos = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btm_reporte = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_cargardatos
            // 
            this.Btn_cargardatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_cargardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Btn_cargardatos.Location = new System.Drawing.Point(628, 40);
            this.Btn_cargardatos.Name = "Btn_cargardatos";
            this.Btn_cargardatos.Size = new System.Drawing.Size(141, 34);
            this.Btn_cargardatos.TabIndex = 1;
            this.Btn_cargardatos.Text = "Cargar Datos";
            this.Btn_cargardatos.UseVisualStyleBackColor = false;
            this.Btn_cargardatos.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_ayuda.Location = new System.Drawing.Point(628, 91);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(141, 29);
            this.btn_ayuda.TabIndex = 2;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // btm_reporte
            // 
            this.btm_reporte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btm_reporte.Location = new System.Drawing.Point(628, 142);
            this.btm_reporte.Name = "btm_reporte";
            this.btm_reporte.Size = new System.Drawing.Size(141, 29);
            this.btm_reporte.TabIndex = 3;
            this.btm_reporte.Text = "Reporte";
            this.btm_reporte.UseVisualStyleBackColor = false;
            this.btm_reporte.Click += new System.EventHandler(this.btm_reporte_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salir.Location = new System.Drawing.Point(628, 192);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(141, 29);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Julia Rashell López Cifuentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "0901-20-5910";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabla: Jornadas";
            // 
            // frmSegundoParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btm_reporte);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.Btn_cargardatos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmSegundoParcial";
            this.Text = "frmSegundoParcial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_cargardatos;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btm_reporte;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}