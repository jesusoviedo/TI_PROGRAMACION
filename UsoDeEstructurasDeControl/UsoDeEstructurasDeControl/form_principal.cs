using System;
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
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        private void form_principal_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ocultar_Pantalla()
        {
            this.Hide();
        }

        private void mostrar_Pantalla()
        {
            this.Show();
        }

        private void but_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_list_dia_Click(object sender, EventArgs e)
        {
            //usando el try catch   
            try
            {
                ocultar_Pantalla();
                form_list_dias_meses FORM_LIST_DIA_MES = new form_list_dias_meses();
                FORM_LIST_DIA_MES.ShowDialog();
                mostrar_Pantalla();
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }          
        }

        private void but_cont_num_Click(object sender, EventArgs e)
        {
            //usando el try catch   
            try
            {
                ocultar_Pantalla();
                form_contar_numeros FORM_CONTAR_NUMEROS = new form_contar_numeros();
                FORM_CONTAR_NUMEROS.ShowDialog();
                mostrar_Pantalla();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void but_tra_meses_Click(object sender, EventArgs e)
        {
            //usando el try catch   
            try
            {
                ocultar_Pantalla();
                form_trad_dias FORM_TRAD_DIAS = new form_trad_dias();
                FORM_TRAD_DIAS.ShowDialog();
                mostrar_Pantalla();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }   
        }
    }
}
