namespace Practica04_formularioIA_01
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
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Ape = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Lbl_Edad = new System.Windows.Forms.Label();
            this.Lbl_Alt = new System.Windows.Forms.Label();
            this.Txtb_Nom = new System.Windows.Forms.TextBox();
            this.Txtb_Ape = new System.Windows.Forms.TextBox();
            this.Txtb_Tel = new System.Windows.Forms.TextBox();
            this.Txtb_Edad = new System.Windows.Forms.TextBox();
            this.Txtb_Alt = new System.Windows.Forms.TextBox();
            this.Gpb_Genero = new System.Windows.Forms.GroupBox();
            this.Rbtn_Mas = new System.Windows.Forms.RadioButton();
            this.Rbtn_Fem = new System.Windows.Forms.RadioButton();
            this.Rbtn_Otro = new System.Windows.Forms.RadioButton();
            this.Btn_Grd = new System.Windows.Forms.Button();
            this.Btn_Lpr = new System.Windows.Forms.Button();
            this.Gpb_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(42, 49);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(59, 16);
            this.Lbl_Nom.TabIndex = 0;
            this.Lbl_Nom.Text = "Nombre:";
            this.Lbl_Nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Ape
            // 
            this.Lbl_Ape.AutoSize = true;
            this.Lbl_Ape.Location = new System.Drawing.Point(42, 83);
            this.Lbl_Ape.Name = "Lbl_Ape";
            this.Lbl_Ape.Size = new System.Drawing.Size(60, 16);
            this.Lbl_Ape.TabIndex = 1;
            this.Lbl_Ape.Text = "Apellido:";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Location = new System.Drawing.Point(42, 123);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Tel.TabIndex = 2;
            this.Lbl_Tel.Text = "Telefono:";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.Location = new System.Drawing.Point(42, 163);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(43, 16);
            this.Lbl_Edad.TabIndex = 3;
            this.Lbl_Edad.Text = "Edad:";
            // 
            // Lbl_Alt
            // 
            this.Lbl_Alt.AutoSize = true;
            this.Lbl_Alt.Location = new System.Drawing.Point(42, 203);
            this.Lbl_Alt.Name = "Lbl_Alt";
            this.Lbl_Alt.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Alt.TabIndex = 4;
            this.Lbl_Alt.Text = "Altura:";
            // 
            // Txtb_Nom
            // 
            this.Txtb_Nom.Location = new System.Drawing.Point(153, 49);
            this.Txtb_Nom.Name = "Txtb_Nom";
            this.Txtb_Nom.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Nom.TabIndex = 5;
            // 
            // Txtb_Ape
            // 
            this.Txtb_Ape.Location = new System.Drawing.Point(153, 83);
            this.Txtb_Ape.Name = "Txtb_Ape";
            this.Txtb_Ape.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Ape.TabIndex = 6;
            // 
            // Txtb_Tel
            // 
            this.Txtb_Tel.Location = new System.Drawing.Point(153, 123);
            this.Txtb_Tel.Name = "Txtb_Tel";
            this.Txtb_Tel.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Tel.TabIndex = 7;
            // 
            // Txtb_Edad
            // 
            this.Txtb_Edad.Location = new System.Drawing.Point(153, 163);
            this.Txtb_Edad.Name = "Txtb_Edad";
            this.Txtb_Edad.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Edad.TabIndex = 8;
            // 
            // Txtb_Alt
            // 
            this.Txtb_Alt.Location = new System.Drawing.Point(153, 203);
            this.Txtb_Alt.Name = "Txtb_Alt";
            this.Txtb_Alt.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Alt.TabIndex = 9;
            // 
            // Gpb_Genero
            // 
            this.Gpb_Genero.Controls.Add(this.Rbtn_Otro);
            this.Gpb_Genero.Controls.Add(this.Rbtn_Fem);
            this.Gpb_Genero.Controls.Add(this.Rbtn_Mas);
            this.Gpb_Genero.Location = new System.Drawing.Point(54, 283);
            this.Gpb_Genero.Name = "Gpb_Genero";
            this.Gpb_Genero.Size = new System.Drawing.Size(365, 100);
            this.Gpb_Genero.TabIndex = 10;
            this.Gpb_Genero.TabStop = false;
            this.Gpb_Genero.Text = "Genero";
            // 
            // Rbtn_Mas
            // 
            this.Rbtn_Mas.AutoSize = true;
            this.Rbtn_Mas.Location = new System.Drawing.Point(6, 46);
            this.Rbtn_Mas.Name = "Rbtn_Mas";
            this.Rbtn_Mas.Size = new System.Drawing.Size(89, 20);
            this.Rbtn_Mas.TabIndex = 0;
            this.Rbtn_Mas.TabStop = true;
            this.Rbtn_Mas.Text = "Masculino";
            this.Rbtn_Mas.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Fem
            // 
            this.Rbtn_Fem.AutoSize = true;
            this.Rbtn_Fem.Location = new System.Drawing.Point(124, 46);
            this.Rbtn_Fem.Name = "Rbtn_Fem";
            this.Rbtn_Fem.Size = new System.Drawing.Size(88, 20);
            this.Rbtn_Fem.TabIndex = 1;
            this.Rbtn_Fem.TabStop = true;
            this.Rbtn_Fem.Text = "Femenino";
            this.Rbtn_Fem.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Otro
            // 
            this.Rbtn_Otro.AutoSize = true;
            this.Rbtn_Otro.Location = new System.Drawing.Point(246, 46);
            this.Rbtn_Otro.Name = "Rbtn_Otro";
            this.Rbtn_Otro.Size = new System.Drawing.Size(53, 20);
            this.Rbtn_Otro.TabIndex = 2;
            this.Rbtn_Otro.TabStop = true;
            this.Rbtn_Otro.Text = "Otro";
            this.Rbtn_Otro.UseVisualStyleBackColor = true;
            // 
            // Btn_Grd
            // 
            this.Btn_Grd.Location = new System.Drawing.Point(95, 457);
            this.Btn_Grd.Name = "Btn_Grd";
            this.Btn_Grd.Size = new System.Drawing.Size(75, 23);
            this.Btn_Grd.TabIndex = 11;
            this.Btn_Grd.Text = "Guardar";
            this.Btn_Grd.UseVisualStyleBackColor = true;
            this.Btn_Grd.Click += new System.EventHandler(this.Btn_Grd_Click_1);
            // 
            // Btn_Lpr
            // 
            this.Btn_Lpr.Location = new System.Drawing.Point(249, 457);
            this.Btn_Lpr.Name = "Btn_Lpr";
            this.Btn_Lpr.Size = new System.Drawing.Size(75, 23);
            this.Btn_Lpr.TabIndex = 12;
            this.Btn_Lpr.Text = "Limpiar";
            this.Btn_Lpr.UseVisualStyleBackColor = true;
            this.Btn_Lpr.Click += new System.EventHandler(this.Btn_Lpr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 631);
            this.Controls.Add(this.Btn_Lpr);
            this.Controls.Add(this.Btn_Grd);
            this.Controls.Add(this.Gpb_Genero);
            this.Controls.Add(this.Txtb_Alt);
            this.Controls.Add(this.Txtb_Edad);
            this.Controls.Add(this.Txtb_Tel);
            this.Controls.Add(this.Txtb_Ape);
            this.Controls.Add(this.Txtb_Nom);
            this.Controls.Add(this.Lbl_Alt);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.Lbl_Ape);
            this.Controls.Add(this.Lbl_Nom);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Practica04_FormularioIA";
            this.Gpb_Genero.ResumeLayout(false);
            this.Gpb_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_Ape;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Edad;
        private System.Windows.Forms.Label Lbl_Alt;
        private System.Windows.Forms.TextBox Txtb_Nom;
        private System.Windows.Forms.TextBox Txtb_Ape;
        private System.Windows.Forms.TextBox Txtb_Tel;
        private System.Windows.Forms.TextBox Txtb_Edad;
        private System.Windows.Forms.TextBox Txtb_Alt;
        private System.Windows.Forms.GroupBox Gpb_Genero;
        private System.Windows.Forms.RadioButton Rbtn_Otro;
        private System.Windows.Forms.RadioButton Rbtn_Fem;
        private System.Windows.Forms.RadioButton Rbtn_Mas;
        private System.Windows.Forms.Button Btn_Grd;
        private System.Windows.Forms.Button Btn_Lpr;
    }
}

