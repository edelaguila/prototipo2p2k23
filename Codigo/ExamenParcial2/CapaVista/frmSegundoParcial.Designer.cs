
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tabla = new System.Windows.Forms.ComboBox();
            this.btn_datos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danny Alejandro Pérez Flores ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "0901-20-24632";
            // 
            // cmb_tabla
            // 
            this.cmb_tabla.FormattingEnabled = true;
            this.cmb_tabla.Location = new System.Drawing.Point(74, 172);
            this.cmb_tabla.Name = "cmb_tabla";
            this.cmb_tabla.Size = new System.Drawing.Size(233, 21);
            this.cmb_tabla.TabIndex = 2;
            this.cmb_tabla.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_datos
            // 
            this.btn_datos.Location = new System.Drawing.Point(625, 88);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(129, 23);
            this.btn_datos.TabIndex = 3;
            this.btn_datos.Text = "Cargar Datos";
            this.btn_datos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tabla: cursos";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(625, 117);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(129, 23);
            this.btn_ayuda.TabIndex = 5;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(625, 149);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(129, 23);
            this.btn_reportes.TabIndex = 6;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(625, 178);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(129, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // frmSegundoParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.cmb_tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSegundoParcial";
            this.Text = "frmSegundoParcial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tabla;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_salir;
    }
}