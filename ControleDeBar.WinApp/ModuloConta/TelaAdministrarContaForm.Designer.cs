namespace ControleDeBar.WinApp.ModuloConta
{
    partial class TelaAdministrarContaForm
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
            label2 = new Label();
            txtNumeroMesa = new TextBox();
            groupBox1 = new GroupBox();
            btnAdicionar = new Button();
            btnRemoverlist = new Button();
            listPedidos = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(319, 274);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(12, 274);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 16;
            label2.Text = "Mesa Nº:";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Enabled = false;
            txtNumeroMesa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroMesa.Location = new Point(77, 24);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(52, 23);
            txtNumeroMesa.TabIndex = 25;
            txtNumeroMesa.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(btnRemoverlist);
            groupBox1.Controls.Add(listPedidos);
            groupBox1.Location = new Point(-1, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 182);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DialogResult = DialogResult.Yes;
            btnAdicionar.Location = new Point(99, 25);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemoverlist
            // 
            btnRemoverlist.Location = new Point(12, 25);
            btnRemoverlist.Name = "btnRemoverlist";
            btnRemoverlist.Size = new Size(75, 23);
            btnRemoverlist.TabIndex = 9;
            btnRemoverlist.Text = "Remover";
            btnRemoverlist.UseVisualStyleBackColor = true;
            btnRemoverlist.Click += btnRemoverlist_Click;
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.Location = new Point(0, 56);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(408, 130);
            listPedidos.TabIndex = 4;
            // 
            // TelaAdministrarContaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 309);
            Controls.Add(groupBox1);
            Controls.Add(txtNumeroMesa);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAdministrarContaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administração de Conta";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtNumeroMesa;
        private GroupBox groupBox1;
        private Button btnAdicionar;
        private Button btnRemoverlist;
        private CheckedListBox listPedidos;
    }
}