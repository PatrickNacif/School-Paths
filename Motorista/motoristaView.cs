using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPaths.Telas
{
    // Esta classe representa um formulário de visualização de informações de motoristas.
    public partial class MotoristaView : Form
    {
        // Construtor padrão que inicializa o formulário.
        public MotoristaView()
        {
            InitializeComponent();
        }

        // Manipulador de eventos para o clique no botão "Voltar".
        private void Voltar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário principal para alunos.
            alunoHome FrmMain = new alunoHome();
            FrmMain.Show(); // Exibe o formulário principal para alunos.
            this.Hide(); // Oculta o formulário atual.
        }

        // Manipulador de eventos para o clique no botão "Buscar".
        private void Buscar_Click(object sender, EventArgs e)
        {
            // Cria uma nova conexão com o banco de dados.
            SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");

            // Limpa a listagem de motoristas.
            motoristaTable.Items.Clear(); // limpa a listagem. 

            try
            {
                con.Open(); // Abre conexão com banco de dados. 

                // Executa uma consulta SQL para obter informações de motoristas com base na pesquisa.
                SqlCommand cmd = new SqlCommand("SELECT nomeMotorista  + ' ' + sobrenomeMotorista  AS NomeCompleto, telefoneMotorista , cidadeMotorista FROM motorista_db WHERE nomeMotorista+' '+sobrenomeMotorista LIKE '%" + pesquisarMotorista.Text + "%' OR '"+ pesquisarMotorista.Text +"' = ''", con);

                // Executa a consulta e lê os resultados.
                SqlDataReader dt = cmd.ExecuteReader();

                // Preenche a tabela de motoristas com os resultados da consulta.
                while (dt.Read())
                {
                    var item1 = motoristaTable.Items.Add(dt["NomeCompleto"].ToString());
                    item1.SubItems.Add(dt["telefoneMotorista"].ToString());
                    item1.SubItems.Add(dt["cidadeMotorista"].ToString());
                }

                // Fecha a conexão com o banco de dados.
                con.Close();
            }
            catch (Exception erro)
            {
                // Exibe uma mensagem de erro em caso de exceção.
                MessageBox.Show(erro.Message);

                // Fecha a conexão com o banco de dados em caso de exceção.
                con.Close();
            }
        }

    }
}
