namespace Estacionamento.Win
{
    partial class FrmHistorico
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvHistorico = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnHistorico = new Button();
            btnVeiculo = new Button();
            btnEntradaSaida = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvHistorico);
            panel1.Location = new Point(124, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 496);
            panel1.TabIndex = 0;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorico.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvHistorico.Location = new Point(25, 26);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.Size = new Size(962, 453);
            dgvHistorico.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Data de entrada";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data de Saida";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 209;
            // 
            // Column4
            // 
            Column4.HeaderText = "Data de Entrada";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Valor";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnHistorico);
            panel3.Controls.Add(btnVeiculo);
            panel3.Controls.Add(btnEntradaSaida);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 676);
            panel3.TabIndex = 8;
            // 
            // btnHistorico
            // 
            btnHistorico.Enabled = false;
            btnHistorico.Location = new Point(0, 506);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(75, 65);
            btnHistorico.TabIndex = 11;
            btnHistorico.UseVisualStyleBackColor = true;
            // 
            // btnVeiculo
            // 
            btnVeiculo.Location = new Point(0, 322);
            btnVeiculo.Name = "btnVeiculo";
            btnVeiculo.Size = new Size(75, 65);
            btnVeiculo.TabIndex = 10;
            btnVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnEntradaSaida
            // 
            btnEntradaSaida.Location = new Point(0, 134);
            btnEntradaSaida.Name = "btnEntradaSaida";
            btnEntradaSaida.Size = new Size(75, 65);
            btnEntradaSaida.TabIndex = 9;
            btnEntradaSaida.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(76, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1087, 57);
            panel4.TabIndex = 9;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmHistorico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHistorico";
            Load += FrmHistorico_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvHistorico;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;
        private Button btnHistorico;
        private Button btnVeiculo;
        private Button btnEntradaSaida;
        private Panel panel4;
    }
}