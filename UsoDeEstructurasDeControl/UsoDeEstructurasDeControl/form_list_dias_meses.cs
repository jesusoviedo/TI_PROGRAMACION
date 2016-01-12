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
    public partial class form_list_dias_meses : Form
    {
       
        public form_list_dias_meses()
        {
            InitializeComponent();
        }

        private void form_list_dias_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void listarDiasyMeses()
        {
            ArrayList dias = new ArrayList();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miércoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            dias.Add("Sábado");
            dias.Add("Domingo");

            String[] meses ={ "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //usando el for
            for (int i = 0; i < meses.Length; i++)
            {
                //usando el if
                if (i == 0)
                {
                    list_dias_meses.Items.Add("---Meses---");
                }

                list_dias_meses.Items.Add(meses[i]);
            }

            list_dias_meses.Items.Add("---Dias---");
            //usando el foreach
            foreach (var dia in dias)
            {
                list_dias_meses.Items.Add(dia);
            }
        }

        private void but_list_dia_mes_Click(object sender, EventArgs e)
        {
            list_dias_meses.Items.Clear();
            listarDiasyMeses();
        }
    }
}
