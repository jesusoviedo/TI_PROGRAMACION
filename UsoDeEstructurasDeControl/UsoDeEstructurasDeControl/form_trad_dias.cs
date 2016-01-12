using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoDeEstructurasDeControl
{
    public partial class form_trad_dias : Form
    {
        public form_trad_dias()
        {
            InitializeComponent();
        }

        private void form_trad_dias_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            radioButton_mond.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void but_tra_dias_Click(object sender, EventArgs e)
        {
            string seleccion=String.Empty;
            tex_resultado.Clear();
            //usando el foreach
            foreach (Control ctrl in grou_dias.Controls)
            {
                //usando el if
                if (ctrl is RadioButton)
                {
                    RadioButton radio = ctrl as RadioButton;
             
                    if (radio.Checked)
                    {
                        seleccion = radio.Text;
                        break;
                    }
                }
            }

            //usando el switch
            switch (seleccion)
            {
                case "MONDAY":
                    tex_resultado.Text= "LUNES";
                    break;

                case "TUESDAY":
                    tex_resultado.Text = "MARTES";
                    break;

                case "WEDNESDAY":
                    tex_resultado.Text = "MIÉRCOLES";
                    break;

                case "THURSDAY":
                    tex_resultado.Text = "JUEVES";
                    break;

                case "FRIDAY":
                    tex_resultado.Text = "VIERNES";
                    break;

                case "SATURDAY":
                    tex_resultado.Text = "SÁBADO";
                    break;

                case "SUNDAY":
                    tex_resultado.Text = "DOMINGO";
                    break;
            }
        }
    }
}
