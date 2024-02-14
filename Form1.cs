using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ejercicio8_tabla_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txt_num.Text);

            for (int i = 1; i <= 12; i++) 
            { 
                lst_Tabla_Multiplicar.Items.Add($"{numero} * {i} " + "= " + numero * i);

            }


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lst_Tabla_Multiplicar.Items.Clear();
        }
    }
}
