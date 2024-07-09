namespace ControleDeBar.WinApp
{
    partial class TelaPrincipalForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            garcomMenuItem = new ToolStripMenuItem();
            produtoMenuItem = new ToolStripMenuItem();
            mesaMenuItem = new ToolStripMenuItem();
            contaMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnContasAbertas = new ToolStripButton();
            btnFecharConta = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            btnCadastroPedido = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { garcomMenuItem, produtoMenuItem, mesaMenuItem, contaMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // garcomMenuItem
            // 
            garcomMenuItem.Name = "garcomMenuItem";
            garcomMenuItem.Size = new Size(131, 24);
            garcomMenuItem.Text = "Garçom";
            garcomMenuItem.Click += garcomMenuItem_Click;
            // 
            // produtoMenuItem
            // 
            produtoMenuItem.Name = "produtoMenuItem";
            produtoMenuItem.Size = new Size(131, 24);
            produtoMenuItem.Text = "Produto";
            produtoMenuItem.Click += produtoMenuItem_Click;
            // 
            // mesaMenuItem
            // 
            mesaMenuItem.Name = "mesaMenuItem";
            mesaMenuItem.Size = new Size(131, 24);
            mesaMenuItem.Text = "Mesa";
            mesaMenuItem.Click += mesaMenuItem_Click;
            // 
            // contaMenuItem
            // 
            contaMenuItem.Name = "contaMenuItem";
            contaMenuItem.Size = new Size(131, 24);
            contaMenuItem.Text = "Conta";
            contaMenuItem.Click += contaMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 515);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator2, btnCadastroPedido, btnContasAbertas, btnFecharConta, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = WinApp.Properties.Resources.btnAdicionarItens;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = WinApp.Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = WinApp.Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnContasAbertas
            // 
            btnContasAbertas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnContasAbertas.Enabled = false;
            btnContasAbertas.Image = WinApp.Properties.Resources.btnContas;
            btnContasAbertas.ImageScaling = ToolStripItemImageScaling.None;
            btnContasAbertas.ImageTransparentColor = Color.Magenta;
            btnContasAbertas.Name = "btnContasAbertas";
            btnContasAbertas.Padding = new Padding(5);
            btnContasAbertas.Size = new Size(37, 38);
            btnContasAbertas.Click += btnContas_Click;
            // 
            // btnFecharConta
            // 
            btnFecharConta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFecharConta.Enabled = false;
            btnFecharConta.Image = WinApp.Properties.Resources.btnFecharConta;
            btnFecharConta.ImageScaling = ToolStripItemImageScaling.None;
            btnFecharConta.ImageTransparentColor = Color.Magenta;
            btnFecharConta.Name = "btnFecharConta";
            btnFecharConta.Padding = new Padding(5);
            btnFecharConta.Size = new Size(37, 38);
            btnFecharConta.Click += btnFecharConta_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 446);
            pnlRegistros.TabIndex = 3;
            // 
            // btnCadastroPedido
            // 
            btnCadastroPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCadastroPedido.Enabled = false;
            btnCadastroPedido.Image = WinApp.Properties.Resources.Info2;
            btnCadastroPedido.ImageScaling = ToolStripItemImageScaling.None;
            btnCadastroPedido.ImageTransparentColor = Color.DarkOrchid;
            btnCadastroPedido.Name = "btnCadastroPedido";
            btnCadastroPedido.Padding = new Padding(5);
            btnCadastroPedido.Size = new Size(38, 38);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem garcomMenuItem;
        private ToolStripMenuItem produtoMenuItem;
        private object Properties;
        private ToolStripMenuItem mesaMenuItem;
        private ToolStripButton btnContasAbertas;
        private ToolStripButton btnFecharConta;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem contaMenuItem;
        private ToolStripButton btnCadastroPedido;
    }
}
