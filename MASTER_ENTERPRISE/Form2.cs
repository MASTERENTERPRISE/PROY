using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTER_ENTERPRISE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuenta = textBox1.Text;
            string password = textBox2.Text;
            if (cuenta == "admin" && password == "123456")
            {
                MessageBox.Show("BIENVENIDO SEÑOR GERENTE");
                Form menu_ad = new Form3();
                menu_ad.ShowDialog();
            }
            else
            {   if (cuenta == "admin" && password == "1234")
                {
                    MessageBox.Show("BIENVENIDO SEÑORITA SECRETARIA");
                    Form menu_ad = new Form3();
                    menu_ad.ShowDialog();
                }
                else {
                    MessageBox.Show("Error!!! Cuenta o Password incorrecto");
                }
            }
        }
    }
}
