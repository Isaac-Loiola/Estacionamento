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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(570, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 437);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 0;
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
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(767, 554);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(173, 50);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Saída";
            btnSaida.UseVisualStyleBackColor = true;
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
            Text = "FrmEntradaSaida";
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSaida;
    }
}