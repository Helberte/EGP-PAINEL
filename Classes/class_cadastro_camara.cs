using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EGP_PAINEL.Classes
{
    public class class_cadastro_camara
    {

        public String Serial_camara { get; private set; }

        Conexao conexao;

        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommandBuilder builder;

        SqlCommand cmd;
        SqlDataReader reader;

        public string Mensagem_Retorno { get; private set; }

        string comando;
         
        public class_cadastro_camara()
        {
            this.conexao = new Conexao();
        }


        public DataSet PreencheGrid(string consulta)
        {
            try
            {
                using (adapter = new SqlDataAdapter(consulta, conexao.Abre()))
                {
                    using (dataSet = new DataSet())
                    {
                        using (builder = new SqlCommandBuilder(adapter))
                        {
                            adapter.Fill(dataSet);
                            conexao.Fecha();
                            return dataSet;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                conexao.Fecha();
                MessageBox.Show("Erro Banco de Dados: " + e.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }        

        public bool Insert(string nome, 
                           string cnpj, 
                           string email,
                           string telefone,
                           string celular, 
                           byte[] imagem,
                           string cep,
                           string rua,
                           string numero,
                           string bairro,
                           string cidade)
        {
            bool retorno = false;
        
            comando = "exec usp_camara 'n', null, null, '" + nome + "'," +
                                                       "'" + cnpj + "', " +
                                                       "'" + email + "'," +
                                                       "'" + telefone + "'," +
                                                       "'" + celular + "', " +
                                                       "'" + imagem + "', " +
                                                       "'" + cep + "', " +
                                                       "'" + rua + "', " +
                                                       "'" + numero + "', " +
                                                       "'" + bairro + "', " +
                                                       "'" + cidade + "'";
            using (cmd = new SqlCommand())
            {
                try
                {
                    cmd.CommandText = comando;
                    cmd.CommandTimeout = 300;
                    cmd.Connection = conexao.Abre(); // retorna o objeto sqlconnection e já abre a conexão

                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader["result"].ToString() == "0")
                    {
                        this.Mensagem_Retorno = reader["message"].ToString();
                        retorno = false;
                    }
                    else if (reader["result"].ToString() == "1")
                    {
                        this.Serial_camara = reader["Id_camara"].ToString();
                        this.Mensagem_Retorno = "Cadastrado com sucesso!";
                        retorno = true;
                    }

                    conexao.Fecha();
                }
                catch (SqlException e)
                {
                    conexao.Fecha();
                    retorno = false;

                    this.Mensagem_Retorno = "Erro no banco: " + e.ToString();
                }
            }
            return retorno;
        }
    }
}
