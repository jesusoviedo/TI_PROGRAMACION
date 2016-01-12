namespace UsoDeEstructurasDeControl
{
    partial class form_list_dias_meses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_list_dias_meses));
            this.but_list_dia_mes = new System.Windows.Forms.Button();
            this.list_dias_meses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // but_list_dia_mes
            // 
            this.but_list_dia_mes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_list_dia_mes.Location = new System.Drawing.Point(12, 12);
            this.but_list_dia_mes.Name = "but_list_dia_mes";
            this.but_list_dia_mes.Size = new System.Drawing.Size(261, 23);
            this.but_list_dia_mes.TabIndex = 1;
            this.but_list_dia_mes.Text = "Listar Días y Meses";
            this.but_list_dia_mes.UseVisualStyleBackColor = false;
            this.but_list_dia_mes.Click += new System.EventHandler(this.but_list_dia_mes_Click);
            // 
            // list_dias_meses
            // 
            this.list_dias_meses.FormattingEnabled = true;
            this.list_dias_meses.Location = new System.Drawing.Point(12, 41);
            this.list_dias_meses.Name = "list_dias_meses";
            this.list_dias_meses.Size = new System.Drawing.Size(261, 199);
            this.list_dias_meses.TabIndex = 2;
            // 
            // form_list_dias_meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsoDeEstructurasDeControl.Properties.Resources.Fondo_de_pantalla_Abstracto_90;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.list_dias_meses);
            this.Controls.Add(this.but_list_dia_mes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_list_dias_meses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_list_dias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_list_dia_mes;
        private System.Windows.Forms.ListBox list_dias_meses;
    }
}