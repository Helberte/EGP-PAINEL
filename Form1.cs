using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EGP_PAINEL.Classes;
using EGP_PAINEL.Formularios;
using System.Resources;
using System.Collections;
using System.Data.SqlTypes;
using System.Net.NetworkInformation;

namespace EGP_PAINEL
{
    public partial class Form_principal : Form
    {
        form_cadastro_participante frm_cad_participante;
        form_cadastro_funcoes frm_cad_funcoes;
        form_cadastro_de_partido frm_cad_partido;
        Form_principal frm_principal;
        form_cadastro_camara frm_cad_camaras;
        form_cadastro_projeto frm_cad_pauta;
        Form_discusao frm_discusao;
        CultureInfo culture;
        List<GroupBox> groupBoxes = new List<GroupBox>();
        GroupBox group_Assunto_pauta;
        List<Button> botoes_discusao = new List<Button>();
        List<Button> botoes_encerrado = new List<Button>();
        //string[,] vt_informacoes_projeto;
        //ResXResourceWriter resourceWriter;
        string nomeResx = @".\Recursos.resx";

        //List


        // ESTUDAR
        // https://docs.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/features

        int aumentar_panel = 0;

        private bool inserir_projeto = false;
        public Form_principal()
        {            
            InitializeComponent();
            culture = new CultureInfo("pt-BR");
            this.AutoScroll = true;
            //resourceWriter = new ResXResourceWriter(nomeResx);

            using (ResXResourceWriter resourceWriter = new ResXResourceWriter(nomeResx))
            {
                resourceWriter.AddResource("GravouProjeto", "false");
            }            
        }

        private void Form_principal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Deseja realmente sair do EGP?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void cadastroDePartidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_cad_partido = new form_cadastro_de_partido();
            frm_cad_partido.ShowDialog();
        }

        private void cadastroDeFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_funcoes = new form_cadastro_funcoes();
            frm_cad_funcoes.ShowDialog();
        }

        private void cadastroDeParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_participante = new form_cadastro_participante();
            frm_cad_participante.ShowDialog();
        }

        private void cadastroDeCâmarasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_cad_camaras = new form_cadastro_camara();
            frm_cad_camaras.ShowDialog();
        }

        private void Form_principal_Load_1(object sender, EventArgs e)
        {
            
            lbl_nome_camara.Font = new Font(FontFamily.GenericSerif, 30F, FontStyle.Regular);
            DateTimeFormatInfo info = culture.DateTimeFormat;


            frm_principal = this;
            panel_pauta_hoje.Top = 170;
            panel_pauta_hoje.Width = 1100;
            panel_pauta_hoje.Left = (frm_principal.Width / 2) - (panel_pauta_hoje.Width / 2);
            lbl_titulo_pauta.Text = "Pauta de hoje    " + DateTime.Now.ToString().Substring(0, 10) + "     -     " + culture.TextInfo.ToTitleCase(info.GetDayName(DateTime.Now.DayOfWeek)) + "    Hora   -   " + DateTime.Now.ToString().Substring(11);

            lbl_nome_camara.Top = 75;
            lbl_nome_camara.Left = (frm_principal.Width / 2) - (lbl_nome_camara.Width / 2);
            
        }        

        private void bt_inserir_projeto_Click(object sender, EventArgs e)
        {
            inserir_projeto = true;
            frm_cad_pauta = new form_cadastro_projeto();
            frm_cad_pauta.ShowDialog();
        }

        private void Insere_projeto(string sigla, string tipo, string ementa)
        {
           
            lbl_insira_assunto.Visible = false;

            panel_pauta_hoje.Height = groupBoxes.Count <= 0 ? 350 : panel_pauta_hoje.Height;
            
            // configura groupbox que contém os assuntos, diferentes assuntos

            group_Assunto_pauta = new GroupBox();
            group_Assunto_pauta.Size = new Size(panel_pauta_hoje.Width - 30, 200);
            group_Assunto_pauta.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            group_Assunto_pauta.RightToLeft = RightToLeft.No;
            group_Assunto_pauta.Text = sigla + " - " + tipo;

            // define a altura deste groupbox
            int y_group_assunto;
            y_group_assunto = (groupBoxes.Count <= 0) ? 60 : groupBoxes[groupBoxes.Count - 1].Top + groupBoxes[groupBoxes.Count - 1].Height + 3;

            group_Assunto_pauta.Location = new Point((panel_pauta_hoje.Width - group_Assunto_pauta.Width) / 2, y_group_assunto);


            // adiciona o novo grupo à lista de groups
            groupBoxes.Add(group_Assunto_pauta);

            //vt_informacoes_projeto = new string[groupBoxes.Count, 2];
           
            // adiciona o groupBox dentro do painel que contém o scrol, painel da pauta do dia


            this.panel_pauta_hoje.Controls.Add(groupBoxes[(groupBoxes.Count <= 0 ? 0 : groupBoxes.Count - 1)]);

            if (aumentar_panel < 2)
                panel_pauta_hoje.Height += groupBoxes.Count == 1 ? 0 : 170;

            Label lbl_ementa = new Label();

            lbl_ementa.Size = new Size(150, 24);
            lbl_ementa.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            lbl_ementa.Text = "Emenda";
            lbl_ementa.RightToLeft = RightToLeft.No;
            lbl_ementa.Location = new Point(5, 25);            
            groupBoxes[(groupBoxes.Count <= 0) ? 0 : groupBoxes.Count - 1].Controls.Add(lbl_ementa);


            Label lbl_texto_ementa = new Label();

            lbl_texto_ementa.Size = new Size(group_Assunto_pauta.Width - 10, group_Assunto_pauta.Height - lbl_ementa.Top - 70);
            lbl_texto_ementa.BackColor = Color.AliceBlue;
            lbl_texto_ementa.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            lbl_texto_ementa.Text = ementa;
            lbl_texto_ementa.RightToLeft = RightToLeft.No;
            lbl_texto_ementa.Location = new Point((group_Assunto_pauta.Width - lbl_texto_ementa.Width) / 2, 50);
            groupBoxes[(groupBoxes.Count <= 0) ? 0 : groupBoxes.Count - 1].Controls.Add(lbl_texto_ementa);


            Button bt_abrir_discussao = new Button();

            bt_abrir_discussao.Size = new Size(145, 30);
            bt_abrir_discussao.Text = "Abrir discução";
            bt_abrir_discussao.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            bt_abrir_discussao.BackColor = Color.Salmon;
            bt_abrir_discussao.Location = new Point(lbl_texto_ementa.Location.X, lbl_texto_ementa.Top + lbl_texto_ementa.Height + 7);
            bt_abrir_discussao.Tag = botoes_discusao.Count <= 0 ? 0 : botoes_discusao.Count;

            botoes_discusao.Add(bt_abrir_discussao); // adiciona cada botão em uma lista

            botoes_discusao[botoes_discusao.Count - 1].Click += Botoes_Click;

            groupBoxes[(groupBoxes.Count <= 0) ? 0 : groupBoxes.Count - 1].Controls.Add(bt_abrir_discussao);

            Button bt_encerrado = new Button();


            bt_encerrado.Size = new Size(145, 30);
            bt_encerrado.Text = "Encerrado";
            bt_encerrado.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            bt_encerrado.BackColor = Color.Salmon;
            bt_encerrado.Location = new Point(lbl_texto_ementa.Location.X + bt_abrir_discussao.Width + 3, lbl_texto_ementa.Top + lbl_texto_ementa.Height + 7);

            botoes_encerrado.Add(bt_encerrado);

            groupBoxes[(groupBoxes.Count <= 0) ? 0 : groupBoxes.Count - 1].Controls.Add(bt_encerrado);


            bt_inserir_projeto.Top = groupBoxes.Count <= 0 ? groupBoxes[0].Top + groupBoxes[0].Height + 15 : groupBoxes[groupBoxes.Count - 1].Top + groupBoxes[groupBoxes.Count - 1].Height + 15;
            bt_inserir_ata.Top = bt_inserir_projeto.Top;
            bt_leitura_ata.Top = bt_inserir_ata.Top;

            aumentar_panel += 1;            
        }

        private void Botoes_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            Discusao_votacao.Tag = (int) botao.Tag;

            frm_discusao = new Form_discusao();
            frm_discusao.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_discusao = new Form_discusao();
            frm_discusao.ShowDialog();
        }

        private void Form_principal_Activated(object sender, EventArgs e)
        {
            SortedList sorted = new SortedList();
            Cad_projeto projeto;
            if (this.inserir_projeto)
            {
                this.inserir_projeto = false;
                // é preciso verificar se a rotina de cadastro de projetos inseriu algum projeto no banco

                using (ResXResourceReader reader = new ResXResourceReader(nomeResx))
                {
                    foreach (DictionaryEntry item in reader)
                    {
                        if (((string) item.Key).StartsWith("GravouProjeto"))
                        {
                            if ((string) item.Value == "true") // se for true, é porque gravou um novo projeto
                            {

                                // lê o arquivo de recurso que contém o projeto

                                using (ResXResourceReader ler_projeto = new ResXResourceReader(@".\Cad_Projeto.resx"))
                                {
                                    foreach (DictionaryEntry proj in ler_projeto)
                                    {
                                        if (((string) proj.Key).StartsWith("p"))
                                        {
                                            sorted.Add(proj.Key, proj.Value);
                                        }
                                    }

                                    projeto = (Cad_projeto)sorted.GetByIndex(sorted.Count - 1);
                                }


                                this.Insere_projeto(projeto.Sigla, projeto.Tipo, projeto.Ementa);

                                using (ResXResourceWriter writer = new ResXResourceWriter(nomeResx))
                                {
                                    writer.AddResource("GravouProjeto", "false");
                                }
                            }
                        }
                    }
                }               
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
