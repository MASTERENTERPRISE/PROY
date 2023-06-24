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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form list_pedido = new Form5();
            list_pedido.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form list_trabaj = new Form6();
            list_trabaj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ingr_egre = new Form7();
            ingr_egre.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form reportar= new Form8();
            reportar.ShowDialog();
        }
    }
}
