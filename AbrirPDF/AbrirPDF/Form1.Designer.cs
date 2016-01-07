namespace AbrirPDF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_word = new System.Windows.Forms.Button();
            this.but_excel = new System.Windows.Forms.Button();
            this.but_powerpoint = new System.Windows.Forms.Button();
            this.but_onenote = new System.Windows.Forms.Button();
            this.lin_soporte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // but_word
            // 
            this.but_word.Location = new System.Drawing.Point(50, 37);
            this.but_word.Name = "but_word";
            this.but_word.Size = new System.Drawing.Size(142, 23);
            this.but_word.TabIndex = 0;
            this.but_word.Text = "Word 2016";
            this.but_word.UseVisualStyleBackColor = true;
            this.but_word.Click += new System.EventHandler(this.but_word_Click);
            // 
            // but_excel
            // 
            this.but_excel.Location = new System.Drawing.Point(50, 66);
            this.but_excel.Name = "but_excel";
            this.but_excel.Size = new System.Drawing.Size(142, 23);
            this.but_excel.TabIndex = 1;
            this.but_excel.Text = "Excel 2016";
            this.but_excel.UseVisualStyleBackColor = true;
            this.but_excel.Click += new System.EventHandler(this.but_excel_Click);
            // 
            // but_powerpoint
            // 
            this.but_powerpoint.Location = new System.Drawing.Point(50, 95);
            this.but_powerpoint.Name = "but_powerpoint";
            this.but_powerpoint.Size = new System.Drawing.Size(142, 23);
            this.but_powerpoint.TabIndex = 2;
            this.but_powerpoint.Text = "PowerPoint 2016";
            this.but_powerpoint.UseVisualStyleBackColor = true;
            this.but_powerpoint.Click += new System.EventHandler(this.but_powerpoint_Click);
            // 
            // but_onenote
            // 
            this.but_onenote.Location = new System.Drawing.Point(50, 124);
            this.but_onenote.Name = "but_onenote";
            this.but_onenote.Size = new System.Drawing.Size(142, 23);
            this.but_onenote.TabIndex = 3;
            this.but_onenote.Text = "OneNote 2016";
            this.but_onenote.UseVisualStyleBackColor = true;
            this.but_onenote.Click += new System.EventHandler(this.but_onenote_Click);
            // 
            // lin_soporte
            // 
            this.lin_soporte.AutoSize = true;
            this.lin_soporte.Location = new System.Drawing.Point(180, 156);
            this.lin_soporte.Name = "lin_soporte";
            this.lin_soporte.Size = new System.Drawing.Size(44, 13);
            this.lin_soporte.TabIndex = 4;
            this.lin_soporte.TabStop = true;
            this.lin_soporte.Text = "Soporte";
            this.lin_soporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lin_soporte_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 178);
            this.Controls.Add(this.lin_soporte);
            this.Controls.Add(this.but_onenote);
            this.Controls.Add(this.but_powerpoint);
            this.Controls.Add(this.but_excel);
            this.Controls.Add(this.but_word);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office 2016";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_word;
        private System.Windows.Forms.Button but_excel;
        private System.Windows.Forms.Button but_powerpoint;
        private System.Windows.Forms.Button but_onenote;
        private System.Windows.Forms.LinkLabel lin_soporte;
    }
}

