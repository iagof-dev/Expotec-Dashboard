using Dashboard.Model;
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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario.name = txtNome.Text;
        }


    }
}
