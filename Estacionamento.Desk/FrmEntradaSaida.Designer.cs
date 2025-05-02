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
            txtValor = new TextBox();
            lblvalor = new Label();
            lblDataSaida = new Label();
            lblDataEntrada = new Label();
            txtSaida = new TextBox();
            label2 = new Label();
            txtIdVeiculo = new TextBox();
            label1 = new Label();
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
            lblTipoVeiculo.Location = new Point(150, 309);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(89, 15);
            lblTipoVeiculo.TabIndex = 11;
            lblTipoVeiculo.Text = "Tipo do Veiculo";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(168, 177);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 10;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(170, 50);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 9;
            lblPlaca.Text = "Placa";
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipoVeiculo.Location = new Point(87, 327);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(204, 23);
            cmbTipoVeiculo.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(87, 195);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(204, 23);
            txtModelo.TabIndex = 7;
            txtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(87, 68);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(204, 23);
            txtPlaca.TabIndex = 6;
            txtPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtValor);
            panel2.Controls.Add(lblvalor);
            panel2.Controls.Add(lblDataSaida);
            panel2.Controls.Add(lblDataEntrada);
            panel2.Controls.Add(txtSaida);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtIdVeiculo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtDataEntrada);
            panel2.Controls.Add(txtModeloSaida);
            panel2.Controls.Add(txtPlacaSaida);
            panel2.Location = new Point(570, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 437);
            panel2.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(198, 402);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(134, 23);
            txtValor.TabIndex = 14;
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Location = new Point(250, 384);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(33, 15);
            lblvalor.TabIndex = 13;
            lblvalor.Text = "Valor";
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Location = new Point(367, 239);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(78, 15);
            lblDataSaida.TabIndex = 12;
            lblDataSaida.Text = "Data de Saída";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Location = new Point(91, 239);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(90, 15);
            lblDataEntrada.TabIndex = 11;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // txtSaida
            // 
            txtSaida.Enabled = false;
            txtSaida.Location = new Point(303, 257);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(204, 23);
            txtSaida.TabIndex = 4;
            txtSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 139);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 10;
            label2.Text = "Modelo";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 31);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Placa";
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Enabled = false;
            txtDataEntrada.Location = new Point(27, 257);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(204, 23);
            txtDataEntrada.TabIndex = 2;
            txtDataEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // txtModeloSaida
            // 
            txtModeloSaida.Location = new Point(162, 157);
            txtModeloSaida.Name = "txtModeloSaida";
            txtModeloSaida.Size = new Size(204, 23);
            txtModeloSaida.TabIndex = 1;
            txtModeloSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlacaSaida
            // 
            txtPlacaSaida.Location = new Point(162, 49);
            txtPlacaSaida.Name = "txtPlacaSaida";
            txtPlacaSaida.Size = new Size(204, 23);
            txtPlacaSaida.TabIndex = 0;
            txtPlacaSaida.TextAlign = HorizontalAlignment.Center;
            txtPlacaSaida.TextChanged += textBox1_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(168, 554);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 50);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(912, 85);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(197, 23);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(750, 554);
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
        private Label label1;
        private TextBox txtValor;
        private Label lblvalor;
        private Label lblDataSaida;
        private Label lblDataEntrada;
        private Label label2;
    }
}