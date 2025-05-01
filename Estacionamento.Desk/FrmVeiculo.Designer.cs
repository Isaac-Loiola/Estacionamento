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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel3 = new Panel();
            dgvVeiculos = new DataGridView();
            clmPlaca = new DataGridViewTextBoxColumn();
            clmModelo = new DataGridViewTextBoxColumn();
            clmTipoVeiculo = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvVeiculos);
            panel3.Location = new Point(80, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(1005, 496);
            panel3.TabIndex = 2;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVeiculos.BackgroundColor = Color.White;
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
            // FrmVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(panel3);
            Name = "FrmVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarsFast";
            Load += CarsFast_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvVeiculos;
        private DataGridViewTextBoxColumn clmPlaca;
        private DataGridViewTextBoxColumn clmModelo;
        private DataGridViewTextBoxColumn clmTipoVeiculo;
    }
}
