namespace Estacionamento.Win
{
    partial class FrmEntradaSaida
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
            panel1 = new Panel();
            lblTipoVeiculo = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            cmbTipoVeiculo = new ComboBox();
            txtModelo = new TextBox();
            txtPlaca = new TextBox();
            panel2 = new Panel();
            txtSaida = new TextBox();
            txtIdVeiculo = new TextBox();
            txtDataEntrada = new TextBox();
            txtModeloSaida = new TextBox();
            txtPlacaSaida = new TextBox();
            btnRegistrar = new Button();
            txtBuscar = new TextBox();
            btnSaida = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTipoVeiculo);
            panel1.Controls.Add(lblModelo);
            panel1.Controls.Add(lblPlaca);
            panel1.Controls.Add(cmbTipoVeiculo);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(txtPlaca);
            panel1.Location = new Point(71, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 437);
            panel1.TabIndex = 0;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Location = new Point(145, 265);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(89, 15);
            lblTipoVeiculo.TabIndex = 11;
            lblTipoVeiculo.Text = "Tipo do Veiculo";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(162, 172);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 10;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(171, 90);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 9;
            lblPlaca.Text = "Placa";
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipoVeiculo.Location = new Point(88, 283);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(204, 23);
            cmbTipoVeiculo.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(60, 190);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(257, 23);
            txtModelo.TabIndex = 7;
            txtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(88, 108);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(204, 23);
            txtPlaca.TabIndex = 6;
            txtPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSaida);
            panel2.Controls.Add(txtIdVeiculo);
            panel2.Controls.Add(txtDataEntrada);
            panel2.Controls.Add(txtModeloSaida);
            panel2.Controls.Add(txtPlacaSaida);
            panel2.Location = new Point(570, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 437);
            panel2.TabIndex = 1;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(180, 356);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(204, 23);
            txtSaida.TabIndex = 4;
            // 
            // txtIdVeiculo
            // 
            txtIdVeiculo.BackColor = SystemColors.Control;
            txtIdVeiculo.Location = new Point(519, 3);
            txtIdVeiculo.Name = "txtIdVeiculo";
            txtIdVeiculo.Size = new Size(17, 23);
            txtIdVeiculo.TabIndex = 3;
            txtIdVeiculo.Visible = false;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Location = new Point(180, 283);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(204, 23);
            txtDataEntrada.TabIndex = 2;
            txtDataEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // txtModeloSaida
            // 
            txtModeloSaida.Location = new Point(152, 190);
            txtModeloSaida.Name = "txtModeloSaida";
            txtModeloSaida.Size = new Size(257, 23);
            txtModeloSaida.TabIndex = 1;
            txtModeloSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlacaSaida
            // 
            txtPlacaSaida.Location = new Point(180, 108);
            txtPlacaSaida.Name = "txtPlacaSaida";
            txtPlacaSaida.Size = new Size(204, 23);
            txtPlacaSaida.TabIndex = 0;
            txtPlacaSaida.TextAlign = HorizontalAlignment.Center;
            txtPlacaSaida.TextChanged += textBox1_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(159, 554);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 50);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(750, 82);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(197, 23);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(767, 554);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(173, 50);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Saída";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // FrmEntradaSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(btnSaida);
            Controls.Add(txtBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmEntradaSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEntradaSaida";
            Load += FrmEntradaSaida_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTipoVeiculo;
        private Label lblModelo;
        private Label lblPlaca;
        private ComboBox cmbTipoVeiculo;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private Button btnRegistrar;
        private TextBox txtBuscar;
        private TextBox txtModeloSaida;
        private TextBox txtPlacaSaida;
        private Button btnSaida;
        private TextBox txtDataEntrada;
        private TextBox txtIdVeiculo;
        private TextBox txtSaida;
    }
}