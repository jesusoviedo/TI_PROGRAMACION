using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        //al dar clic en word
        private void but_word_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("J:\\Visual Studio 2015\\Projects\\AbrirPDF\\word.pdf");
            } catch (Exception ex)
            {
                Console.WriteLine("-----\nError\n" + ex.Message + "\n-----");
                MessageBox.Show(ex.Message+" Word ");
            }
        }

        //al dar clic en excel
        private void but_excel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("J:\\Visual Studio 2015\\Projects\\AbrirPDF\\excel.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----\nError\n" + ex.Message+"\n-----");
                MessageBox.Show(ex.Message + " Excel ");
            }
        }

        //al dar clic en powerpoint
        private void but_powerpoint_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("J:\\Visual Studio 2015\\Projects\\AbrirPDF\\powerpoint.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----\nError\n" + ex.Message + "\n-----");
                MessageBox.Show(ex.Message + " PowerPoint ");
            }
        }

        //al dar clic en onenote
        private void but_onenote_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("J:\\Visual Studio 2015\\Projects\\AbrirPDF\\onenote.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----\nError\n" + ex.Message + "\n-----");
                MessageBox.Show(ex.Message + " OneNote ");
            }
        }

        private void lin_soporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://support.office.com/");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----\nError\n" + ex.Message + "\n-----");
                MessageBox.Show(ex.Message + " OneNote ");
            }
        }
    }
}
