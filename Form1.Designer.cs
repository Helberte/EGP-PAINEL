
namespace EGP_PAINEL
{
    partial class Form_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCâmarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome_camara = new System.Windows.Forms.Label();
            this.bt_inserir_projeto = new System.Windows.Forms.Button();
            this.lbl_titulo_pauta = new System.Windows.Forms.Label();
            this.bt_inserir_ata = new System.Windows.Forms.Button();
            this.bt_leitura_ata = new System.Windows.Forms.Button();
            this.lbl_insira_assunto = new System.Windows.Forms.Label();
            this.panel_pauta_hoje = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel_pauta_hoje.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePartidosToolStripMenuItem,
            this.cadastroDeFunçõesToolStripMenuItem,
            this.cadastroDeParticipantesToolStripMenuItem,
            this.cadastroDeCâmarasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDePartidosToolStripMenuItem
            // 
            this.cadastroDePartidosToolStripMenuItem.Name = "cadastroDePartidosToolStripMenuItem";
            this.cadastroDePartidosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDePartidosToolStripMenuItem.Text = "Cadastro de Partidos";
            this.cadastroDePartidosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDePartidosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePartidosToolStripMenuItem_Click_1);
            // 
            // cadastroDeFunçõesToolStripMenuItem
            // 
            this.cadastroDeFunçõesToolStripMenuItem.Name = "cadastroDeFunçõesToolStripMenuItem";
            this.cadastroDeFunçõesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeFunçõesToolStripMenuItem.Text = "Cadastro de Funções";
            this.cadastroDeFunçõesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeFunçõesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFunçõesToolStripMenuItem_Click);
            // 
            // cadastroDeParticipantesToolStripMenuItem
            // 
            this.cadastroDeParticipantesToolStripMenuItem.Name = "cadastroDeParticipantesToolStripMenuItem";
            this.cadastroDeParticipantesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeParticipantesToolStripMenuItem.Text = "Cadastro de Participantes";
            this.cadastroDeParticipantesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeParticipantesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeParticipantesToolStripMenuItem_Click);
            // 
            // cadastroDeCâmarasToolStripMenuItem
            // 
            this.cadastroDeCâmarasToolStripMenuItem.Name = "cadastroDeCâmarasToolStripMenuItem";
            this.cadastroDeCâmarasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastroDeCâmarasToolStripMenuItem.Text = "Cadastro de Câmaras";
            this.cadastroDeCâmarasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroDeCâmarasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCâmarasToolStripMenuItem_Click_1);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.button5);
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(50, 263);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(762, 145);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Projeto de Lei";
            this.groupBox.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Encerrado";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Location = new System.Drawing.Point(22, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Abrir discussão";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(725, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lbl_nome_camara
            // 
            this.lbl_nome_camara.AutoSize = true;
            this.lbl_nome_camara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_camara.Location = new System.Drawing.Point(241, 40);
            this.lbl_nome_camara.Name = "lbl_nome_camara";
            this.lbl_nome_camara.Size = new System.Drawing.Size(384, 29);
            this.lbl_nome_camara.TabIndex = 7;
            this.lbl_nome_camara.Text = "Câmara   Municipal   de   Ji-Paraná";
            // 
            // bt_inserir_projeto
            // 
            this.bt_inserir_projeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir_projeto.Location = new System.Drawing.Point(22, 106);
            this.bt_inserir_projeto.Name = "bt_inserir_projeto";
            this.bt_inserir_projeto.Size = new System.Drawing.Size(142, 38);
            this.bt_inserir_projeto.TabIndex = 0;
            this.bt_inserir_projeto.Text = "Inserir Projeto";
            this.bt_inserir_projeto.UseVisualStyleBackColor = true;
            this.bt_inserir_projeto.Click += new System.EventHandler(this.bt_inserir_projeto_Click);
            // 
            // lbl_titulo_pauta
            // 
            this.lbl_titulo_pauta.AutoSize = true;
            this.lbl_titulo_pauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_pauta.Location = new System.Drawing.Point(23, 16);
            this.lbl_titulo_pauta.Name = "lbl_titulo_pauta";
            this.lbl_titulo_pauta.Size = new System.Drawing.Size(472, 24);
            this.lbl_titulo_pauta.TabIndex = 1;
            this.lbl_titulo_pauta.Text = "Pauta de hoje  26/11/2020 - Quinta-Feira      Hora: 11:26";
            // 
            // bt_inserir_ata
            // 
            this.bt_inserir_ata.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_inserir_ata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir_ata.Location = new System.Drawing.Point(172, 106);
            this.bt_inserir_ata.Name = "bt_inserir_ata";
            this.bt_inserir_ata.Size = new System.Drawing.Size(136, 38);
            this.bt_inserir_ata.TabIndex = 2;
            this.bt_inserir_ata.Text = "Inserir Ata";
            this.bt_inserir_ata.UseVisualStyleBackColor = true;
            // 
            // bt_leitura_ata
            // 
            this.bt_leitura_ata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_leitura_ata.Location = new System.Drawing.Point(314, 106);
            this.bt_leitura_ata.Name = "bt_leitura_ata";
            this.bt_leitura_ata.Size = new System.Drawing.Size(150, 38);
            this.bt_leitura_ata.TabIndex = 3;
            this.bt_leitura_ata.Text = "Fazer Leitura da Ata";
            this.bt_leitura_ata.UseVisualStyleBackColor = true;
            // 
            // lbl_insira_assunto
            // 
            this.lbl_insira_assunto.AutoSize = true;
            this.lbl_insira_assunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insira_assunto.Location = new System.Drawing.Point(22, 55);
            this.lbl_insira_assunto.Name = "lbl_insira_assunto";
            this.lbl_insira_assunto.Size = new System.Drawing.Size(600, 31);
            this.lbl_insira_assunto.TabIndex = 4;
            this.lbl_insira_assunto.Text = "Insira um novo assunto ou proposta a ser votada";
            // 
            // panel_pauta_hoje
            // 
            this.panel_pauta_hoje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_pauta_hoje.AutoScroll = true;
            this.panel_pauta_hoje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pauta_hoje.Controls.Add(this.lbl_insira_assunto);
            this.panel_pauta_hoje.Controls.Add(this.bt_leitura_ata);
            this.panel_pauta_hoje.Controls.Add(this.bt_inserir_ata);
            this.panel_pauta_hoje.Controls.Add(this.lbl_titulo_pauta);
            this.panel_pauta_hoje.Controls.Add(this.bt_inserir_projeto);
            this.panel_pauta_hoje.Location = new System.Drawing.Point(50, 81);
            this.panel_pauta_hoje.Name = "panel_pauta_hoje";
            this.panel_pauta_hoje.Size = new System.Drawing.Size(762, 176);
            this.panel_pauta_hoje.TabIndex = 8;
            // 
            // Form_principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 458);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel_pauta_hoje);
            this.Controls.Add(this.lbl_nome_camara);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form_principal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EGP - SISTEMA DE AUTOMAÇÃO DE VOTAÇÕES PLENÁRIAS | CÂMARA MUNICIPAL DE JI-PARANÁ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form_principal_Activated);
            this.Load += new System.EventHandler(this.Form_principal_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_principal_KeyPress_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panel_pauta_hoje.ResumeLayout(false);
            this.panel_pauta_hoje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeParticipantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCâmarasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nome_camara;
        private System.Windows.Forms.Button bt_inserir_projeto;
        private System.Windows.Forms.Label lbl_titulo_pauta;
        private System.Windows.Forms.Button bt_inserir_ata;
        private System.Windows.Forms.Button bt_leitura_ata;
        private System.Windows.Forms.Label lbl_insira_assunto;
        private System.Windows.Forms.Panel panel_pauta_hoje;
    }
}

