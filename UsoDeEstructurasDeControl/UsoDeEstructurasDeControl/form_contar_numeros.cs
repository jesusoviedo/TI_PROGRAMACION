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
    public partial class form_contar_numeros : Form
    {
        public form_contar_numeros()
        {
            InitializeComponent();
        }

        private void form_contar_numeros_Load(object sender, EventArgs e)
        {
            tex_numero.Text = "";
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void but_con_numeros_Click(object sender, EventArgs e)
        {
            list_con_numeros.Items.Clear();
            //usando el if
            if (tex_numero.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero");
            } else
            {
                //usando el try catch
                try
                {
                    int lim_max = Convert.ToInt32(tex_numero.Text);
                    int lim_min = 0;
                    //usando el while
                    while (lim_min <= lim_max)
                    {
                        list_con_numeros.Items.Add(lim_min);
                        lim_min++;
                    }

                    //usando el do while
                    //do
                    //{
                    //    list_con_numeros.Items.Add(lim_min);
                    //    lim_min++;
                    //} while (lim_min <= lim_max);

                }
                catch (Exception err)
                {
                    MessageBox.Show("Debe ingresar un numero entero valido");
                    Console.WriteLine("ERRO \n"+err.Message);
                }
            }
        }
    }
}
