namespace Estacionamento.Desk
{
    partial class FrmVeiculo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            dgvVeiculos = new DataGridView();
            clmPlaca = new DataGridViewTextBoxColumn();
            clmModelo = new DataGridViewTextBoxColumn();
            clmTipoVeiculo = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            btnHistorico = new Button();
            btnVeiculo = new Button();
            btnEntradaSaida = new Button();
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvVeiculos);
            panel3.Location = new Point(124, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(1005, 496);
            panel3.TabIndex = 2;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVeiculos.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Columns.AddRange(new DataGridViewColumn[] { clmPlaca, clmModelo, clmTipoVeiculo });
            dgvVeiculos.Location = new Point(25, 26);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersVisible = false;
            dgvVeiculos.Size = new Size(962, 453);
            dgvVeiculos.TabIndex = 0;
            // 
            // clmPlaca
            // 
            clmPlaca.HeaderText = "Placa";
            clmPlaca.Name = "clmPlaca";
            clmPlaca.ReadOnly = true;
            clmPlaca.Width = 320;
            // 
            // clmModelo
            // 
            clmModelo.HeaderText = "Modelo";
            clmModelo.Name = "clmModelo";
            clmModelo.ReadOnly = true;
            clmModelo.Width = 319;
            // 
            // clmTipoVeiculo
            // 
            clmTipoVeiculo.HeaderText = "Tipo";
            clmTipoVeiculo.Name = "clmTipoVeiculo";
            clmTipoVeiculo.ReadOnly = true;
            clmTipoVeiculo.Width = 320;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(895, 110);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(234, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnHistorico);
            panel1.Controls.Add(btnVeiculo);
            panel1.Controls.Add(btnEntradaSaida);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(76, 676);
            panel1.TabIndex = 8;
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
            btnVeiculo.Enabled = false;
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
            // FrmVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(panel3);
            Name = "FrmVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarsFast";
            Load += CarsFast_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvVeiculos;
        private DataGridViewTextBoxColumn clmPlaca;
        private DataGridViewTextBoxColumn clmModelo;
        private DataGridViewTextBoxColumn clmTipoVeiculo;
        private TextBox txtBuscar;
        private Panel panel1;
        private Button btnHistorico;
        private Button btnVeiculo;
        private Button btnEntradaSaida;
        private Panel panel4;
    }
}
