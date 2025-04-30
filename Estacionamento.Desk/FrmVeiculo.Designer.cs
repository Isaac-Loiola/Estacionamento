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
            panel3 = new Panel();
            lblTipoVeiculo = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            cmbTipoVeiculo = new ComboBox();
            txtModelo = new TextBox();
            txtPlaca = new TextBox();
            btnRegistrar = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTipoVeiculo);
            panel3.Controls.Add(lblModelo);
            panel3.Controls.Add(lblPlaca);
            panel3.Controls.Add(cmbTipoVeiculo);
            panel3.Controls.Add(txtModelo);
            panel3.Controls.Add(txtPlaca);
            panel3.Location = new Point(315, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 382);
            panel3.TabIndex = 2;
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.Location = new Point(219, 257);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(89, 15);
            lblTipoVeiculo.TabIndex = 5;
            lblTipoVeiculo.Text = "Tipo do Veiculo";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(236, 164);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(245, 82);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "Placa";
            // 
            // cmbTipoVeiculo
            // 
            cmbTipoVeiculo.FormattingEnabled = true;
            cmbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipoVeiculo.Location = new Point(162, 275);
            cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            cmbTipoVeiculo.Size = new Size(204, 23);
            cmbTipoVeiculo.TabIndex = 2;
            cmbTipoVeiculo.SelectedIndexChanged += cmbTipoVeiculo_SelectedIndexChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(134, 182);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(257, 23);
            txtModelo.TabIndex = 1;
            txtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(162, 100);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(204, 23);
            txtPlaca.TabIndex = 0;
            txtPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(315, 507);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 50);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 676);
            Controls.Add(btnRegistrar);
            Controls.Add(panel3);
            Name = "FrmVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1";
            Load += CarsFast_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private ComboBox cmbTipoVeiculo;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private Label lblModelo;
        private Label lblPlaca;
        private Label lblTipoVeiculo;
        private Button btnRegistrar;
    }
}
