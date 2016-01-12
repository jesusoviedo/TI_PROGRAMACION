namespace UsoDeEstructurasDeControl
{
    partial class form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.but_salir = new System.Windows.Forms.Button();
            this.but_list_dia = new System.Windows.Forms.Button();
            this.but_tra_meses = new System.Windows.Forms.Button();
            this.but_cont_num = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_salir
            // 
            this.but_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_salir.Location = new System.Drawing.Point(7, 120);
            this.but_salir.Name = "but_salir";
            this.but_salir.Size = new System.Drawing.Size(261, 23);
            this.but_salir.TabIndex = 4;
            this.but_salir.Text = "Salir";
            this.but_salir.UseVisualStyleBackColor = false;
            this.but_salir.Click += new System.EventHandler(this.but_salir_Click);
            // 
            // but_list_dia
            // 
            this.but_list_dia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_list_dia.Location = new System.Drawing.Point(7, 14);
            this.but_list_dia.Name = "but_list_dia";
            this.but_list_dia.Size = new System.Drawing.Size(261, 23);
            this.but_list_dia.TabIndex = 1;
            this.but_list_dia.Text = "Listar días y meses";
            this.but_list_dia.UseVisualStyleBackColor = false;
            this.but_list_dia.Click += new System.EventHandler(this.but_list_dia_Click);
            // 
            // but_tra_meses
            // 
            this.but_tra_meses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_tra_meses.Location = new System.Drawing.Point(7, 43);
            this.but_tra_meses.Name = "but_tra_meses";
            this.but_tra_meses.Size = new System.Drawing.Size(261, 23);
            this.but_tra_meses.TabIndex = 2;
            this.but_tra_meses.Text = "Traducir dias";
            this.but_tra_meses.UseVisualStyleBackColor = false;
            this.but_tra_meses.Click += new System.EventHandler(this.but_tra_meses_Click);
            // 
            // but_cont_num
            // 
            this.but_cont_num.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_cont_num.Location = new System.Drawing.Point(7, 72);
            this.but_cont_num.Name = "but_cont_num";
            this.but_cont_num.Size = new System.Drawing.Size(261, 23);
            this.but_cont_num.TabIndex = 3;
            this.but_cont_num.Text = "Contar numeros";
            this.but_cont_num.UseVisualStyleBackColor = false;
            this.but_cont_num.Click += new System.EventHandler(this.but_cont_num_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::UsoDeEstructurasDeControl.Properties.Resources.Fondo_de_pantalla_Abstracto_90;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(277, 155);
            this.ControlBox = false;
            this.Controls.Add(this.but_cont_num);
            this.Controls.Add(this.but_tra_meses);
            this.Controls.Add(this.but_list_dia);
            this.Controls.Add(this.but_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uso de Estructura de Control";
            this.Load += new System.EventHandler(this.form_principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_salir;
        private System.Windows.Forms.Button but_list_dia;
        private System.Windows.Forms.Button but_tra_meses;
        private System.Windows.Forms.Button but_cont_num;
    }
}

