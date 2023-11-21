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
using SchoolPaths.Telas;

namespace SchoolPaths.Veiculo
{
    // Classe que representa um formulário para realizar operações CRUD em veículos.
    public partial class VeiculoCrud : Form
    {
        // Construtor padrão que inicializa o formulário.
        public VeiculoCrud()
        {
            InitializeComponent();
        }

        // Conexão com o banco de dados.
        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");

        // Comando SQL para execução no banco de dados.
        SqlCommand cmd = new SqlCommand();

        // DataReader para armazenar resultados de consultas SQL.
        SqlDataReader dt;

        // Método que verifica se todos os campos obrigatórios estão preenchidos.
        private bool CamposEstaoPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(renavamVeiculo.Text) ||
            string.IsNullOrWhiteSpace(chassiVeiculo.Text) ||
            string.IsNullOrWhiteSpace(corVeiculo.Text) ||
            string.IsNullOrWhiteSpace(modeloVeiculo.Text) ||
            string.IsNullOrWhiteSpace(marcaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(placaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(anoFabricVeiculo.Text) ||
            string.IsNullOrWhiteSpace(potenciaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(combustivelVeiculo.Text) ||
            string.IsNullOrWhiteSpace(capacidadeVeiculo.Text))
            {
                // Exibe uma mensagem de aviso se algum campo obrigatório estiver em branco.
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Retorna false para indicar que a validação falhou, ou seja, algum campo obrigatório está em branco.
                return false;
            }

            // Se todos os campos estiverem preenchidos, retorna true indicando que a validação foi bem-sucedida.
            return true;
        }

        // Método para limpar os campos do formulário.
        public void LimparCampos()
        {
            renavamVeiculo.Text = "";
            chassiVeiculo.Text = "";
            corVeiculo.Text = "";
            modeloVeiculo.Text = "";
            marcaVeiculo.Text = "";
            placaVeiculo.Text = "";
            anoFabricVeiculo.Text = "";
            potenciaVeiculo.Text = "";
            combustivelVeiculo.Text = "";
        }

        // Manipulador de eventos para o clique no botão "Confirmar".
        private void Confirmar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos.
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }

            try
            {
                // Abre a conexão com o banco de dados.
                con.Open();

                // Verifica se o Renavam já está cadastrado.
                string strSQL = "Select renavam from veiculo_db where renavam  = '" + renavamVeiculo.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();

                if (dt.HasRows)
                {
                    // Exibe uma mensagem se o Renavam já estiver cadastrado.
                    MessageBox.Show("Renavam já cadastrado!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dt.HasRows)
                {
                    // Insere os dados do veículo no banco de dados.
                    if (!dt.IsClosed) { dt.Close(); }
                    strSQL = "insert into veiculo_db (renavam, chassi, cor, modelo, marca, placa, anofabric, potencia, combustivel, capacidade) " +
                        "values (@renavam,@chassi,@cor,@modelo,@marca,@placa,@anofabric,@potencia,@combustivel, @capacidade)";
                    cmd.Parameters.Add("@renavam", SqlDbType.VarChar).Value = renavamVeiculo.Text;
                    cmd.Parameters.Add("@chassi", SqlDbType.VarChar).Value = chassiVeiculo.Text;
                    cmd.Parameters.Add("@cor", SqlDbType.Char).Value = corVeiculo.Text;
                    cmd.Parameters.Add("@modelo", SqlDbType.Char).Value = modeloVeiculo.Text;
                    cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = marcaVeiculo.Text;
                    cmd.Parameters.Add("@placa", SqlDbType.Char).Value = placaVeiculo.Text;
                    cmd.Parameters.Add("@anofabric", SqlDbType.Char).Value = anoFabricVeiculo.Text;
                    cmd.Parameters.Add("@potencia", SqlDbType.VarChar).Value = potenciaVeiculo.Text;
                    cmd.Parameters.Add("@combustivel", SqlDbType.Char).Value = combustivelVeiculo.Text;
                    cmd.Parameters.Add("@capacidade", SqlDbType.VarChar).Value = capacidadeVeiculo.Text;

                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    // Executa o comando SQL para inserir o veículo no banco de dados.
                    cmd.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso.
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // Oculta o formulário atual.
                    con.Close(); // Fecha a conexão com o banco de dados.

                    // Limpa os campos do formulário.
                    LimparCampos();

                    // Limpa os parâmetros do comando SQL.
                    cmd.Parameters.Clear();
                }
            }

            catch (Exception erro)
            {
                // Exibe uma mensagem de erro em caso de exceção.
                MessageBox.Show(erro.Message);

                // Fecha a conexão com o banco de dados em caso de exceção.
                con.Close();
            }

            // Cria uma instância do formulário de login.
            login FrmMain = new login();

            // Exibe o formulário de login.
            FrmMain.Show();

            // Oculta o formulário atual.
            this.Hide();
        }

        // Manipulador de eventos para o clique no botão "Cancelar".
        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de cadastro de motorista.
            MotoristaCrud FrmMain = new MotoristaCrud();
            FrmMain.Show(); // Exibe o formulário de cadastro de motorista.
            this.Hide(); // Oculta o formulário atual.
        }
    }
}
