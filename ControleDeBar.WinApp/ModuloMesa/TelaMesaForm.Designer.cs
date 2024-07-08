namespace ControleDeBar.WinApp.ModuloMesa
{
    partial class TelaMesaForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbConta = new ComboBox();
            label4 = new Label();
            txtNumero = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtNumero).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(319, 117);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(12, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(95, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 19;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 66);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 16;
            label2.Text = "Mesa Nº:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 15;
            label1.Text = "Id:";
            // 
            // cmbConta
            // 
            cmbConta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConta.FormattingEnabled = true;
            cmbConta.Location = new Point(263, 62);
            cmbConta.Name = "cmbConta";
            cmbConta.Size = new Size(81, 23);
            cmbConta.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 66);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 22;
            label4.Text = "Conta:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(95, 64);
            txtNumero.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(52, 23);
            txtNumero.TabIndex = 1;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 152);
            Controls.Add(txtNumero);
            Controls.Add(cmbConta);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Mesa";
            ((System.ComponentModel.ISupportInitialize)txtNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private ComboBox cmbConta;
        private Label label4;
        private NumericUpDown txtNumero;
    }
}