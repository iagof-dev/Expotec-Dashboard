﻿using System;
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
        int produtos;
        double valores;
        DateTime datas;

        public vendas()
        {
            InitializeComponent();
        }

        private void btn_AddVenda_Click(object sender, EventArgs e)
        {
            dgvGrafico.Rows.Add(txt_produto.Text, txt_valor.Text, dtpicker.Text);

            MessageBox.Show("Item inserido com sucesso!", ": D",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (dgvGrafico.RowCount > 0)
            {
                dgvGrafico.Rows.RemoveAt(dgvGrafico.CurrentRow.Index);

                MessageBox.Show("Item removido da compra", "Remoção",
                                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvGrafico.Text = dgvGrafico.RowCount.ToString("C");
            }
        }
    }
}
