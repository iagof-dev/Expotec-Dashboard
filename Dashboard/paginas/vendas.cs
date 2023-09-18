using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.paginas
{
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        private void btn_AddVenda_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && txt_valor.Text.Length <= 2)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
