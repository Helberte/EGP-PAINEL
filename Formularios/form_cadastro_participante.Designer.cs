namespace EGP_PAINEL.Formularios
{
    partial class form_cadastro_participante
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_info_pessoais = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.btFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox_endereco = new System.Windows.Forms.GroupBox();
            this.maskNumero = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.pictureBox_foto = new System.Windows.Forms.PictureBox();
            this.groupBox_atribuicoes = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPartido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboFuncao = new System.Windows.Forms.ComboBox();
            this.groupBox_movel = new System.Windows.Forms.GroupBox();
            this.maskSenha = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btConcluido = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_info_pessoais.SuspendLayout();
            this.groupBox_endereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).BeginInit();
            this.groupBox_atribuicoes.SuspendLayout();
            this.groupBox_movel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_info_pessoais
            // 
            this.groupBox_info_pessoais.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox_info_pessoais.Controls.Add(this.label12);
            this.groupBox_info_pessoais.Controls.Add(this.maskCelular);
            this.groupBox_info_pessoais.Controls.Add(this.btFoto);
            this.groupBox_info_pessoais.Controls.Add(this.label4);
            this.groupBox_info_pessoais.Controls.Add(this.txtEmail);
            this.groupBox_info_pessoais.Controls.Add(this.comboSexo);
            this.groupBox_info_pessoais.Controls.Add(this.label3);
            this.groupBox_info_pessoais.Controls.Add(this.maskCpf);
            this.groupBox_info_pessoais.Controls.Add(this.label2);
            this.groupBox_info_pessoais.Controls.Add(this.label1);
            this.groupBox_info_pessoais.Controls.Add(this.txtNome);
            this.groupBox_info_pessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_info_pessoais.Location = new System.Drawing.Point(205, 67);
            this.groupBox_info_pessoais.Name = "groupBox_info_pessoais";
            this.groupBox_info_pessoais.Size = new System.Drawing.Size(519, 135);
            this.groupBox_info_pessoais.TabIndex = 0;
            this.groupBox_info_pessoais.TabStop = false;
            this.groupBox_info_pessoais.Text = "Informações pessoais";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(231, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Celular";
            // 
            // maskCelular
            // 
            this.maskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCelular.Location = new System.Drawing.Point(235, 98);
            this.maskCelular.Mask = "(00) 0 0000-0000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(143, 22);
            this.maskCelular.TabIndex = 4;
            // 
            // btFoto
            // 
            this.btFoto.Location = new System.Drawing.Point(389, 97);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(121, 24);
            this.btFoto.TabIndex = 5;
            this.btFoto.Text = "Foto";
            this.btFoto.UseVisualStyleBackColor = true;
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(7, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "2";
            // 
            // comboSexo
            // 
            this.comboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefinido"});
            this.comboSexo.Location = new System.Drawing.Point(389, 41);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 24);
            this.comboSexo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // maskCpf
            // 
            this.maskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCpf.Location = new System.Drawing.Point(234, 42);
            this.maskCpf.Mask = "000,000,000-00";
            this.maskCpf.Name = "maskCpf";
            this.maskCpf.Size = new System.Drawing.Size(145, 22);
            this.maskCpf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "1";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // groupBox_endereco
            // 
            this.groupBox_endereco.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox_endereco.Controls.Add(this.maskNumero);
            this.groupBox_endereco.Controls.Add(this.label7);
            this.groupBox_endereco.Controls.Add(this.label6);
            this.groupBox_endereco.Controls.Add(this.label5);
            this.groupBox_endereco.Controls.Add(this.txtBairro);
            this.groupBox_endereco.Controls.Add(this.txtRua);
            this.groupBox_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_endereco.Location = new System.Drawing.Point(12, 217);
            this.groupBox_endereco.Name = "groupBox_endereco";
            this.groupBox_endereco.Size = new System.Drawing.Size(711, 71);
            this.groupBox_endereco.TabIndex = 8;
            this.groupBox_endereco.TabStop = false;
            this.groupBox_endereco.Text = "Endereço";
            // 
            // maskNumero
            // 
            this.maskNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskNumero.Location = new System.Drawing.Point(313, 33);
            this.maskNumero.Mask = "0000000000";
            this.maskNumero.Name = "maskNumero";
            this.maskNumero.Size = new System.Drawing.Size(109, 22);
            this.maskNumero.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bairro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rua";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(457, 33);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(244, 22);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.Tag = "4";
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(15, 33);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(269, 22);
            this.txtRua.TabIndex = 6;
            this.txtRua.Tag = "3";
            // 
            // pictureBox_foto
            // 
            this.pictureBox_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_foto.Location = new System.Drawing.Point(12, 29);
            this.pictureBox_foto.Name = "pictureBox_foto";
            this.pictureBox_foto.Size = new System.Drawing.Size(187, 173);
            this.pictureBox_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_foto.TabIndex = 9;
            this.pictureBox_foto.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_foto, "Pressione \"Delete\" para excluir");
            this.pictureBox_foto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_foto_MouseDown);
            this.pictureBox_foto.MouseEnter += new System.EventHandler(this.pictureBox_foto_MouseEnter);
            this.pictureBox_foto.MouseLeave += new System.EventHandler(this.pictureBox_foto_MouseLeave);
            // 
            // groupBox_atribuicoes
            // 
            this.groupBox_atribuicoes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox_atribuicoes.Controls.Add(this.button2);
            this.groupBox_atribuicoes.Controls.Add(this.button1);
            this.groupBox_atribuicoes.Controls.Add(this.label9);
            this.groupBox_atribuicoes.Controls.Add(this.comboPartido);
            this.groupBox_atribuicoes.Controls.Add(this.label8);
            this.groupBox_atribuicoes.Controls.Add(this.comboFuncao);
            this.groupBox_atribuicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_atribuicoes.Location = new System.Drawing.Point(12, 294);
            this.groupBox_atribuicoes.Name = "groupBox_atribuicoes";
            this.groupBox_atribuicoes.Size = new System.Drawing.Size(399, 84);
            this.groupBox_atribuicoes.TabIndex = 10;
            this.groupBox_atribuicoes.TabStop = false;
            this.groupBox_atribuicoes.Text = "Atribuições";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Partido";
            // 
            // comboPartido
            // 
            this.comboPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPartido.FormattingEnabled = true;
            this.comboPartido.Items.AddRange(new object[] {
            "PT",
            "PMDB",
            "PSOL",
            "PCDOB",
            "REPUBLICANOS",
            "PARTDO VERDE"});
            this.comboPartido.Location = new System.Drawing.Point(200, 37);
            this.comboPartido.Name = "comboPartido";
            this.comboPartido.Size = new System.Drawing.Size(161, 24);
            this.comboPartido.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Função";
            // 
            // comboFuncao
            // 
            this.comboFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncao.FormattingEnabled = true;
            this.comboFuncao.Items.AddRange(new object[] {
            "Vereador",
            "Secritário",
            "Presidente"});
            this.comboFuncao.Location = new System.Drawing.Point(15, 37);
            this.comboFuncao.Name = "comboFuncao";
            this.comboFuncao.Size = new System.Drawing.Size(145, 24);
            this.comboFuncao.TabIndex = 9;
            // 
            // groupBox_movel
            // 
            this.groupBox_movel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox_movel.Controls.Add(this.maskSenha);
            this.groupBox_movel.Controls.Add(this.label11);
            this.groupBox_movel.Controls.Add(this.txtLogin);
            this.groupBox_movel.Controls.Add(this.label10);
            this.groupBox_movel.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_movel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_movel.Location = new System.Drawing.Point(417, 294);
            this.groupBox_movel.Name = "groupBox_movel";
            this.groupBox_movel.Size = new System.Drawing.Size(307, 84);
            this.groupBox_movel.TabIndex = 11;
            this.groupBox_movel.TabStop = false;
            this.groupBox_movel.Text = "Móvel";
            // 
            // maskSenha
            // 
            this.maskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskSenha.Location = new System.Drawing.Point(177, 36);
            this.maskSenha.Mask = "00000000";
            this.maskSenha.Name = "maskSenha";
            this.maskSenha.PasswordChar = '*';
            this.maskSenha.Size = new System.Drawing.Size(119, 22);
            this.maskSenha.TabIndex = 12;
            this.maskSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskSenha.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Senha";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(7, 36);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(163, 22);
            this.txtLogin.TabIndex = 11;
            this.txtLogin.Tag = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Login";
            // 
            // btConcluido
            // 
            this.btConcluido.Location = new System.Drawing.Point(594, 29);
            this.btConcluido.Name = "btConcluido";
            this.btConcluido.Size = new System.Drawing.Size(129, 32);
            this.btConcluido.TabIndex = 12;
            this.btConcluido.Text = "Concluído";
            this.btConcluido.UseVisualStyleBackColor = true;
            this.btConcluido.Click += new System.EventHandler(this.btConcluido_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Excluir foto";
            // 
            // form_cadastro_participante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 391);
            this.Controls.Add(this.btConcluido);
            this.Controls.Add(this.groupBox_movel);
            this.Controls.Add(this.groupBox_atribuicoes);
            this.Controls.Add(this.pictureBox_foto);
            this.Controls.Add(this.groupBox_endereco);
            this.Controls.Add(this.groupBox_info_pessoais);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_cadastro_participante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Participantes";
            this.Deactivate += new System.EventHandler(this.form_cadastro_participante_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_cadastro_participante_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_cadastro_participante_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_cadastro_participante_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_cadastro_participante_KeyPress);
            this.groupBox_info_pessoais.ResumeLayout(false);
            this.groupBox_info_pessoais.PerformLayout();
            this.groupBox_endereco.ResumeLayout(false);
            this.groupBox_endereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).EndInit();
            this.groupBox_atribuicoes.ResumeLayout(false);
            this.groupBox_atribuicoes.PerformLayout();
            this.groupBox_movel.ResumeLayout(false);
            this.groupBox_movel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_info_pessoais;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btFoto;
        private System.Windows.Forms.PictureBox pictureBox_foto;
        private System.Windows.Forms.GroupBox groupBox_atribuicoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPartido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboFuncao;
        private System.Windows.Forms.GroupBox groupBox_movel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btConcluido;
        private System.Windows.Forms.MaskedTextBox maskSenha;
        private System.Windows.Forms.MaskedTextBox maskNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}