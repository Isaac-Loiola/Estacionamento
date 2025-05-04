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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            dgvVeiculos = new DataGridView();
            clmPlaca = new DataGridViewTextBoxColumn();
            clmModelo = new DataGridViewTextBoxColumn();
            clmTipoVeiculo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnHistorico = new Button();
            btnVeiculo = new Button();
            btnEntradaSaida = new Button();
            panel4 = new Panel();
            pictureBox9 = new PictureBox();
            txtBuscar = new TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold);
            dgvVeiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVeiculos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Mont Heavy DEMO", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Columns.AddRange(new DataGridViewColumn[] { clmPlaca, clmModelo, clmTipoVeiculo });
            dgvVeiculos.Location = new Point(25, 26);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersVisible = false;
            dgvVeiculos.Size = new Size(962, 453);
            dgvVeiculos.TabIndex = 0;
            dgvVeiculos.CellContentClick += dgvVeiculos_CellContentClick;
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
            btnHistorico.BackgroundImage = (Image)resources.GetObject("btnHistorico.BackgroundImage");
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Location = new Point(0, 506);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(75, 65);
            btnHistorico.TabIndex = 11;
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnVeiculo
            // 
            btnVeiculo.BackgroundImage = (Image)resources.GetObject("btnVeiculo.BackgroundImage");
            btnVeiculo.FlatAppearance.BorderSize = 0;
            btnVeiculo.FlatStyle = FlatStyle.Flat;
            btnVeiculo.Location = new Point(0, 322);
            btnVeiculo.Name = "btnVeiculo";
            btnVeiculo.Size = new Size(75, 65);
            btnVeiculo.TabIndex = 10;
            btnVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnEntradaSaida
            // 
            btnEntradaSaida.BackgroundImage = (Image)resources.GetObject("btnEntradaSaida.BackgroundImage");
            btnEntradaSaida.FlatAppearance.BorderSize = 0;
            btnEntradaSaida.FlatStyle = FlatStyle.Flat;
            btnEntradaSaida.Location = new Point(0, 134);
            btnEntradaSaida.Name = "btnEntradaSaida";
            btnEntradaSaida.Size = new Size(75, 65);
            btnEntradaSaida.TabIndex = 9;
            btnEntradaSaida.UseVisualStyleBackColor = true;
            btnEntradaSaida.Click += btnEntradaSaida_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(76, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1087, 57);
            panel4.TabIndex = 9;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Left;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.Location = new Point(875, 83);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(254, 50);
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Mont Heavy DEMO", 10F, FontStyle.Bold);
            txtBuscar.Location = new Point(890, 99);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(223, 19);
            txtBuscar.TabIndex = 17;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.KeyDown += txtBuscar_KeyDown_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mont Heavy DEMO", 15F, FontStyle.Bold);
            label1.Location = new Point(124, 92);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 18;
            label1.Text = "Veiculos Estacionados";
            // 
            // FrmVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox9);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FrmVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarsFast";
            Load += CarsFast_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvVeiculos;
        private DataGridViewTextBoxColumn clmPlaca;
        private DataGridViewTextBoxColumn clmModelo;
        private DataGridViewTextBoxColumn clmTipoVeiculo;
        private Panel panel1;
        private Button btnHistorico;
        private Button btnVeiculo;
        private Button btnEntradaSaida;
        private Panel panel4;
        private PictureBox pictureBox9;
        private TextBox txtBuscar;
        private Label label1;
    }
}
