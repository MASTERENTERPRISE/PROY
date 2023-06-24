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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t SU PEDIDO FUE RESEPCIONADO EXITOSAMENTE \n\t GRACIAS POR PREFERIRNOS EN SU COMPRA");
            Close();
        }
    }
}
