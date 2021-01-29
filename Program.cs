using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Net.NetworkInformation;
using EGP_PAINEL.Classes;

namespace EGP_PAINEL
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ArquivoConexao arquivo = new ArquivoConexao();

            if (arquivo.LerArquivo())
            {
                try
                {
                    var ping = new Ping();
                    var resposta = ping.Send(arquivo.Ip, 3);


                    if ((resposta != null) && (resposta.Status == IPStatus.Success))
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form_principal());
                    }
                    else
                    {
                        MessageBox.Show("Servidor não encontrado," +
                            " aplicação não será iniciada.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problemas na inicialização: " + e.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }              
        }
    }
}
