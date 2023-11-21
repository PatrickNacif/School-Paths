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

namespace SchoolPaths
{
    public partial class AlunoCrud : Form
    {
        // Variáveis de parâmetros para armazenar usuário e senha.
        private string ParamUsuario;
        private string ParamSenha;

        // Construtor da classe AlunoCrud, recebe usuário e senha como parâmetros.
        public AlunoCrud(string usuario, string senha)
        {
            ParamUsuario = usuario;
            ParamSenha = senha;
            InitializeComponent();
        }

        // Conexão com o banco de dados SQL Server.
        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        // Método para limpar todos os campos da interface gráfica.
        public void LimparCampos()
        {
            // Limpa todos os campos do formulário.
            nomeAluno.Text = "";
            sobrenomeAluno.Text = "";
            dataNascimentoAluno.Text = "";
            cpfAluno.Text = "";
            rgAluno.Text = "";
            dddAluno.Text = "";
            telefoneAluno.Text = "";
            endereçoAluno.Text = "";
            numeroAluno.Text = "";
            bairroAluno.Text = "";
            cidadeAluno.Text = "";
            cepAluno.Text = "";
            ufAluno.Text = "";
            escolaAluno.Text = "";
            Sexo.Text = "";
        }

        // Método para verificar se todos os campos obrigatórios estão preenchidos.
        private bool CamposEstaoPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(nomeAluno.Text) ||
                string.IsNullOrWhiteSpace(sobrenomeAluno.Text) ||
                string.IsNullOrWhiteSpace(dataNascimentoAluno.Text) ||
                string.IsNullOrWhiteSpace(cpfAluno.Text) ||
                string.IsNullOrWhiteSpace(rgAluno.Text) ||
                string.IsNullOrWhiteSpace(dddAluno.Text) ||
                string.IsNullOrWhiteSpace(telefoneAluno.Text) ||
                string.IsNullOrWhiteSpace(endereçoAluno.Text) ||
                string.IsNullOrWhiteSpace(numeroAluno.Text) ||
                string.IsNullOrWhiteSpace(bairroAluno.Text) ||
                string.IsNullOrWhiteSpace(cidadeAluno.Text) ||
                string.IsNullOrWhiteSpace(cepAluno.Text) ||
                string.IsNullOrWhiteSpace(ufAluno.Text) ||
                string.IsNullOrWhiteSpace(escolaAluno.Text) ||
                string.IsNullOrWhiteSpace(Sexo.Text))
            {
                // Exibe mensagem de aviso se algum campo não estiver preenchido.
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Evento do botão "Cancelar" que volta para a tela de login.
        private void Cancelar_Click(object sender, EventArgs e)
        {
            login FrmMain = new login();
            FrmMain.Show();
            this.Hide();

        }

        // Evento do botão "Confirmar" que realiza a inserção de um novo aluno no banco de dados.
        private void Confirmar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos.
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }

            // Variável para armazenar o sexo do aluno.
            string sex = "";

            // Verifica qual opção de sexo foi selecionada.
            if (masculinoAluno.Checked)
            {
                sex = "Masculino";
            }
            else if (femininoAluno.Checked)
            {
                sex = "Feminino";
            }
            else
            {
                // Verifica qual opção de sexo foi selecionada.
                MessageBox.Show("Por favor, selecione uma opção de sexo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna se o sexo não foi selecionado.
            }

            try
            {
                con.Open();

                // Verifica se o CPF já está cadastrado no banco de dados.
                string strSQL = "Select cpf from aluno_db where cpf = '" + cpfAluno.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();

                if (dt.HasRows)
                {
                    MessageBox.Show("CPF já cadastrado!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dt.HasRows)
                {
                    if (!dt.IsClosed) { dt.Close(); }

                    // Insere os dados do aluno no banco de dados.
                    strSQL = "insert into aluno_db (nome, sobrenome, nascimento, cpf, rg, ddd, telefone, endereço, numero, bairro, cidade, cep, uf, escola, sexo)" +
                        "values (@nome,@sobrenome,@nascimento,@cpf,@rg,@ddd,@telefone,@endereço,@numero,@bairro,@cidade,@cep,@uf,@escola,@sexo);" +
                        "SELECT SCOPE_IDENTITY()";
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeAluno.Text;
                    cmd.Parameters.Add("@sobrenome", SqlDbType.VarChar).Value = sobrenomeAluno.Text;
                    cmd.Parameters.Add("@nascimento", SqlDbType.Char).Value = dataNascimentoAluno.Text;
                    cmd.Parameters.Add("@cpf", SqlDbType.Char).Value = cpfAluno.Text;
                    cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = rgAluno.Text;
                    cmd.Parameters.Add("@ddd", SqlDbType.Char).Value = dddAluno.Text;
                    cmd.Parameters.Add("@telefone", SqlDbType.Char).Value = telefoneAluno.Text;
                    cmd.Parameters.Add("@endereço", SqlDbType.VarChar).Value = endereçoAluno.Text;
                    cmd.Parameters.Add("@numero", SqlDbType.Char).Value = numeroAluno.Text;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairroAluno.Text;
                    cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidadeAluno.Text;
                    cmd.Parameters.Add("@cep", SqlDbType.Char).Value = cepAluno.Text;
                    cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = ufAluno.Text;
                    cmd.Parameters.Add("@escola", SqlDbType.VarChar).Value = escolaAluno.Text;
                    cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sex;

                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    // Executa a consulta e obtém o ID do aluno inserido.
                    int IdAlunoInserido = Convert.ToInt32(cmd.ExecuteScalar()); //pega o Id dos aluno



                    // Insere o novo usuário associado ao aluno no banco de dados.
                    string USUARIO_LOGIN = "INSERT INTO usuario_db (IdAluno, usuario, senha) VALUES (@IdAluno, @usuario, @senha)";
                    cmd = new SqlCommand(USUARIO_LOGIN, con);
                    cmd.Parameters.AddWithValue("@IdAluno", IdAlunoInserido);
                    cmd.Parameters.AddWithValue("@usuario", ParamUsuario);
                    cmd.Parameters.AddWithValue("@senha", ParamSenha);
                    cmd.ExecuteNonQuery();

                    // Exibe mensagem de sucesso.
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa os campos inseridos.
                    LimparCampos();

                    // Limpa os parâmetros do comando.
                    cmd.Parameters.Clear();

                    // Fecha a conexão com o banco de dados.
                    con.Close();


                    // Este trecho de código direciona o fluxo para a página de login.

                    // Cria uma instância do formulário de login.
                    login FrmMain = new login();

                    // Exibe o formulário de login.
                    FrmMain.Show();

                    // Oculta o formulário atual.
                    this.Hide();
                }
            }
            catch (Exception erro)
            {
                // Em caso de exceção, exibe uma caixa de mensagem com a mensagem de erro.
                MessageBox.Show(erro.Message);

                // Fecha a conexão (se houver uma conexão aberta).
                con.Close();
            }
        }
    }
}