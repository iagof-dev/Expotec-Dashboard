namespace Dashboard.paginas
{
    partial class vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGrafico = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddVenda = new System.Windows.Forms.Button();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrafico
            // 
            this.dgvGrafico.AllowUserToAddRows = false;
            this.dgvGrafico.AllowUserToDeleteRows = false;
            this.dgvGrafico.AllowUserToOrderColumns = true;
            this.dgvGrafico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.valor,
            this.data});
            this.dgvGrafico.Location = new System.Drawing.Point(17, 25);
            this.dgvGrafico.Name = "dgvGrafico";
            this.dgvGrafico.ReadOnly = true;
            this.dgvGrafico.Size = new System.Drawing.Size(404, 220);
            this.dgvGrafico.TabIndex = 0;
            // 
            // produto
            // 
            this.produto.HeaderText = "produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // btn_AddVenda
            // 
            this.btn_AddVenda.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddVenda.Location = new System.Drawing.Point(189, 303);
            this.btn_AddVenda.Name = "btn_AddVenda";
            this.btn_AddVenda.Size = new System.Drawing.Size(101, 47);
            this.btn_AddVenda.TabIndex = 1;
            this.btn_AddVenda.Text = "Adicionar venda";
            this.btn_AddVenda.UseVisualStyleBackColor = true;
            this.btn_AddVenda.Click += new System.EventHandler(this.btn_AddVenda_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.Location = new System.Drawing.Point(189, 262);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(181, 20);
            this.dtpicker.TabIndex = 2;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(17, 262);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(166, 20);
            this.txt_produto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(17, 303);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(166, 20);
            this.txt_valor.TabIndex = 5;
            this.txt_valor.Text = "R$";
            this.txt_valor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_valor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            // 
            // btn_Remover
            // 
            this.btn_Remover.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.Location = new System.Drawing.Point(305, 303);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(113, 47);
            this.btn_Remover.TabIndex = 8;
            this.btn_Remover.Text = "Remover Venda";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(576, 389);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.btn_AddVenda);
            this.Controls.Add(this.dgvGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vendas";
            this.Text = "vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrafico;
        private System.Windows.Forms.Button btn_AddVenda;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button btn_Remover;
    }
}