using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraerDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuil = textBox1.Text;

            
            if (!cuil.Contains("-"))
            {
                MessageBox.Show("El CUIL debe contener '-' entre los números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cuil.Length == 13 && cuil[2] == '-' && cuil[11] == '-')
            {
                
                string dni = cuil.Substring(3, 8);
                MessageBox.Show($"El DNI extraído es: {dni}", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formato de CUIL inválido. Debe ser N-NNNNNNNN-N", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
