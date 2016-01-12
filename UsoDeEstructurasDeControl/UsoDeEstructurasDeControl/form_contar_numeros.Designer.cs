namespace UsoDeEstructurasDeControl
{
    partial class form_contar_numeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_contar_numeros));
            this.list_con_numeros = new System.Windows.Forms.ListBox();
            this.but_con_numeros = new System.Windows.Forms.Button();
            this.tex_numero = new System.Windows.Forms.TextBox();
            this.lab_comentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_con_numeros
            // 
            this.list_con_numeros.FormattingEnabled = true;
            this.list_con_numeros.Location = new System.Drawing.Point(12, 76);
            this.list_con_numeros.Name = "list_con_numeros";
            this.list_con_numeros.Size = new System.Drawing.Size(261, 173);
            this.list_con_numeros.TabIndex = 4;
            // 
            // but_con_numeros
            // 
            this.but_con_numeros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_con_numeros.Location = new System.Drawing.Point(12, 16);
            this.but_con_numeros.Name = "but_con_numeros";
            this.but_con_numeros.Size = new System.Drawing.Size(261, 23);
            this.but_con_numeros.TabIndex = 3;
            this.but_con_numeros.Text = "Contar Numeros";
            this.but_con_numeros.UseVisualStyleBackColor = false;
            this.but_con_numeros.Click += new System.EventHandler(this.but_con_numeros_Click);
            // 
            // tex_numero
            // 
            this.tex_numero.Location = new System.Drawing.Point(187, 50);
            this.tex_numero.Name = "tex_numero";
            this.tex_numero.Size = new System.Drawing.Size(86, 20);
            this.tex_numero.TabIndex = 3;
            // 
            // lab_comentario
            // 
            this.lab_comentario.BackColor = System.Drawing.Color.Transparent;
            this.lab_comentario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_comentario.Location = new System.Drawing.Point(13, 49);
            this.lab_comentario.Name = "lab_comentario";
            this.lab_comentario.Size = new System.Drawing.Size(86, 20);
            this.lab_comentario.TabIndex = 2;
            this.lab_comentario.Text = "Desde 0 hasta ";
            this.lab_comentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_contar_numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsoDeEstructurasDeControl.Properties.Resources.Fondo_de_pantalla_Abstracto_90;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lab_comentario);
            this.Controls.Add(this.tex_numero);
            this.Controls.Add(this.list_con_numeros);
            this.Controls.Add(this.but_con_numeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_contar_numeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_contar_numeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_con_numeros;
        private System.Windows.Forms.Button but_con_numeros;
        private System.Windows.Forms.TextBox tex_numero;
        private System.Windows.Forms.Label lab_comentario;
    }
}