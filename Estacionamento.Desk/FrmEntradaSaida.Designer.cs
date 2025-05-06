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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaSaida));
            panel1 = new Panel();
            cmbTipoVeiculo = new ComboBox();
            txtModelo = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtPlaca = new TextBox();
            pictureBox1 = new PictureBox();
            lblTipoVeiculo = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            panel2 = new Panel();
            txtDataEntrada = new TextBox();
            txtDataSaida = new TextBox();
            txtValor = new TextBox();
            txtModeloSaida = new TextBox();
            txtPlacaSaida = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblvalor = new Label();
            lblDataSaida = new Label();
            lblDataEntrada = new Label();
            label2 = new Label();
            txtIdVeiculo = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            txtBuscar = new TextBox();
            btnSaida = new Button();
            panel3 = new Panel();
            btnHistorico = new Button();
            btnVeiculo = new Button();
            btnEntradaSaida = new Button();
            panel4 = new Panel();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(cmbTipoVeiculo);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtPlaca);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTipoVeiculo);
            panel1.Controls.Add(lblModelo);
            panel1.Controls.Add(lblPlaca);
            panel1.Location = new Point(130, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 437);
            panel1.TabIndex = 0;
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.BackColor = Color.FromArgb(230, 230, 230);
            cmbTipoVeiculo.FlatStyle = FlatStyle.Flat;
            cmbTipoVeiculo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipoVeiculo.Location = new Point(42, 338);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(235, 24);
            cmbTipoVeiculo.TabIndex = 17;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(230, 230, 230);
            txtModelo.BorderStyle = BorderStyle.None;
            txtModelo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtModelo.Location = new Point(42, 210);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(235, 16);
            txtModelo.TabIndex = 16;
            txtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(32, 326);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(254, 50);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(32, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 50);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(230, 230, 230);
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtPlaca.Location = new Point(42, 84);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(235, 16);
            txtPlaca.TabIndex = 13;
            txtPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(32, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTipoVeiculo.Location = new Point(100, 301);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(132, 20);
            lblTipoVeiculo.TabIndex = 11;
            lblTipoVeiculo.Text = "Tipo do Veiculo";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblModelo.Location = new Point(131, 169);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(67, 20);
            lblModelo.TabIndex = 10;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.Location = new Point(136, 42);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(53, 20);
            lblPlaca.TabIndex = 9;
            lblPlaca.Text = "Placa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(txtDataEntrada);
            panel2.Controls.Add(txtDataSaida);
            panel2.Controls.Add(txtValor);
            panel2.Controls.Add(txtModeloSaida);
            panel2.Controls.Add(txtPlacaSaida);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lblvalor);
            panel2.Controls.Add(lblDataSaida);
            panel2.Controls.Add(lblDataEntrada);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtIdVeiculo);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(535, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 437);
            panel2.TabIndex = 1;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.BackColor = Color.FromArgb(230, 230, 230);
            txtDataEntrada.BorderStyle = BorderStyle.None;
            txtDataEntrada.Enabled = false;
            txtDataEntrada.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtDataEntrada.Location = new Point(30, 272);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(219, 16);
            txtDataEntrada.TabIndex = 16;
            txtDataEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDataSaida
            // 
            txtDataSaida.BackColor = Color.FromArgb(230, 230, 230);
            txtDataSaida.BorderStyle = BorderStyle.None;
            txtDataSaida.Enabled = false;
            txtDataSaida.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtDataSaida.Location = new Point(335, 272);
            txtDataSaida.Name = "txtDataSaida";
            txtDataSaida.Size = new Size(219, 16);
            txtDataSaida.TabIndex = 16;
            txtDataSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(230, 230, 230);
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Enabled = false;
            txtValor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtValor.Location = new Point(181, 390);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(219, 16);
            txtValor.TabIndex = 16;
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtModeloSaida
            // 
            txtModeloSaida.BackColor = Color.FromArgb(230, 230, 230);
            txtModeloSaida.BorderStyle = BorderStyle.None;
            txtModeloSaida.Enabled = false;
            txtModeloSaida.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtModeloSaida.Location = new Point(182, 158);
            txtModeloSaida.Name = "txtModeloSaida";
            txtModeloSaida.Size = new Size(219, 16);
            txtModeloSaida.TabIndex = 16;
            txtModeloSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlacaSaida
            // 
            txtPlacaSaida.BackColor = Color.FromArgb(230, 230, 230);
            txtPlacaSaida.BorderStyle = BorderStyle.None;
            txtPlacaSaida.Enabled = false;
            txtPlacaSaida.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtPlacaSaida.Location = new Point(182, 65);
            txtPlacaSaida.Name = "txtPlacaSaida";
            txtPlacaSaida.Size = new Size(219, 16);
            txtPlacaSaida.TabIndex = 16;
            txtPlacaSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Left;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(15, 255);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(254, 50);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Left;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(319, 255);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(254, 50);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Left;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(164, 372);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(254, 50);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Left;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.Location = new Point(164, 141);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(254, 50);
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Left;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(164, 49);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(254, 50);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblvalor.Location = new Point(263, 347);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(51, 20);
            lblvalor.TabIndex = 13;
            lblvalor.Text = "Valor";
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDataSaida.Location = new Point(386, 233);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(124, 20);
            lblDataSaida.TabIndex = 12;
            lblDataSaida.Text = "Data de Saida";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblDataEntrada.Location = new Point(65, 233);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(142, 20);
            lblDataEntrada.TabIndex = 11;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(254, 116);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Modelo";
            // 
            // txtIdVeiculo
            // 
            txtIdVeiculo.BackColor = SystemColors.Control;
            txtIdVeiculo.Location = new Point(531, 22);
            txtIdVeiculo.Name = "txtIdVeiculo";
            txtIdVeiculo.Size = new Size(42, 23);
            txtIdVeiculo.TabIndex = 3;
            txtIdVeiculo.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(263, 24);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 9;
            label1.Text = "Placa";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(209, 577);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 50);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtBuscar.Location = new Point(892, 95);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(216, 16);
            txtBuscar.TabIndex = 5;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnSaida
            // 
            btnSaida.BackColor = Color.Transparent;
            btnSaida.BackgroundImage = (Image)resources.GetObject("btnSaida.BackgroundImage");
            btnSaida.FlatAppearance.BorderSize = 0;
            btnSaida.FlatStyle = FlatStyle.Flat;
            btnSaida.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnSaida.ForeColor = Color.White;
            btnSaida.Location = new Point(746, 577);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(173, 50);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Saida";
            btnSaida.UseVisualStyleBackColor = false;
            btnSaida.Click += btnSaida_Click;
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
            panel3.TabIndex = 7;
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
            btnVeiculo.Click += btnVeiculo_Click;
            // 
            // btnEntradaSaida
            // 
            btnEntradaSaida.BackgroundImage = (Image)resources.GetObject("btnEntradaSaida.BackgroundImage");
            btnEntradaSaida.Enabled = false;
            btnEntradaSaida.FlatAppearance.BorderSize = 0;
            btnEntradaSaida.FlatStyle = FlatStyle.Flat;
            btnEntradaSaida.Location = new Point(0, 134);
            btnEntradaSaida.Name = "btnEntradaSaida";
            btnEntradaSaida.Size = new Size(75, 65);
            btnEntradaSaida.TabIndex = 9;
            btnEntradaSaida.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(76, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1087, 57);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Left;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.Location = new Point(874, 78);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(254, 50);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // FrmEntradaSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnSaida);
            Controls.Add(txtBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox9);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEntradaSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VagaFy";
            Load += FrmEntradaSaida_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTipoVeiculo;
        private Label lblModelo;
        private Label lblPlaca;
        private Button btnRegistrar;
        private TextBox txtBuscar;
        private Button btnSaida;
        private TextBox txtIdVeiculo;
        private Label label1;
        private Label lblvalor;
        private Label lblDataSaida;
        private Label lblDataEntrada;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Button btnHistorico;
        private Button btnVeiculo;
        private Button btnEntradaSaida;
        private PictureBox pictureBox1;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ComboBox cmbTipoVeiculo;
        private PictureBox pictureBox4;
        private TextBox txtPlacaSaida;
        private TextBox txtDataEntrada;
        private TextBox txtDataSaida;
        private TextBox txtValor;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TextBox txtModeloSaida;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}