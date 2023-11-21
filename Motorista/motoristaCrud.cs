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
using SchoolPaths.Veiculo;

namespace SchoolPaths
{
    public partial class MotoristaCrud : Form
    {
        // Parâmetros para armazenar informações de usuário e senha recebidas do formulário anterior.
        private string ParamUsuario;
        private string ParamSenha;

        // Construtor que recebe informações de usuário e senha.
        public MotoristaCrud(string usuario, string senha)
        {
            ParamUsuario = usuario;
            ParamSenha = senha;
            InitializeComponent();
        }

        // Construtor padrão necessário para inicialização do formulário.
        public MotoristaCrud()
        {
        }

        // Definição de objetos SqlConnection, SqlCommand e SqlDataReader.
        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        // Método para limpar todos os campos do formulário.
        public void LimparCampos()
        {
            nomeMotorista.Text = "";
            sobrenomeMotorista.Text = "";
            nascimentoMotorista.Text = "";
            cpfMotorista.Text = "";
            rgMotorista.Text = "";
            dddMotorista.Text = "";
            telefoneMotorista.Text = "";
            endereçoMotorista.Text = "";
            numeroMotorista.Text = "";
            bairroMotorista.Text = "";
            cidadeMotorista.Text = "";
            cepMotorista.Text = "";
            ufMotorista.Text = "";
            cnhMotorista.Text = "";
            primeiraCnhMotorista.Text = "";
            Sexo.Text = "";
        }

        // Método para verificar se todos os campos obrigatórios estão preenchidos.
        private bool CamposEstaoPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(nomeMotorista.Text) ||
                string.IsNullOrWhiteSpace(sobrenomeMotorista.Text) ||
                string.IsNullOrWhiteSpace(nascimentoMotorista.Text) ||
                string.IsNullOrWhiteSpace(cpfMotorista.Text) ||
                string.IsNullOrWhiteSpace(rgMotorista.Text) ||
                string.IsNullOrWhiteSpace(dddMotorista.Text) ||
                string.IsNullOrWhiteSpace(telefoneMotorista.Text) ||
                string.IsNullOrWhiteSpace(endereçoMotorista.Text) ||
                string.IsNullOrWhiteSpace(numeroMotorista.Text) ||
                string.IsNullOrWhiteSpace(bairroMotorista.Text) ||
                string.IsNullOrWhiteSpace(cidadeMotorista.Text) ||
                string.IsNullOrWhiteSpace(cepMotorista.Text) ||
                string.IsNullOrWhiteSpace(ufMotorista.Text) ||
                string.IsNullOrWhiteSpace(cnhMotorista.Text) ||
                string.IsNullOrWhiteSpace(primeiraCnhMotorista.Text) ||
                string.IsNullOrWhiteSpace(Sexo.Text))
            {
                // Exibe uma mensagem de aviso se algum campo obrigatório estiver em branco.
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Retorna o valor booleano true.
        }

        // Manipulador de eventos para o clique no botão "Cancelar".
        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de login.
            login FrmMain = new login();
            FrmMain.Show(); // Exibe o formulário de login.
            this.Hide(); // Oculta o formulário atual.
        }

        // Manipulador de eventos para o clique no botão "Confirmar".
        private void Confirmar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios estão preenchidos.
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }
            
            string sex = "";

            // Verifica a opção de sexo escolhida.
            if (masculinoMotorista.Checked)
            {
                sex = "Masculino";
            }
            else if (femininoMotorista.Checked)
            {
                sex = "Feminino";
            }
            else
            {
                // Exibe uma mensagem se a opção de sexo não foi selecionada.
                MessageBox.Show("Por favor, selecione uma opção de sexo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna se o sexo não foi selecionado.
            }

            try
            {
                con.Open(); // Abre a conexão com o banco de dados.

                // Verifica se o CPF do motorista já está cadastrado no banco de dados.
                string strSQL = "Select cpfMotorista from motorista_db where cpfMotorista  = '" + cpfMotorista.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();

                if (dt.HasRows)
                {
                    // Exibe uma mensagem se o CPF já estiver cadastrado.
                    MessageBox.Show("CPF já cadastrado!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dt.HasRows)
                {
                    // Fecha o leitor de dados, pois será utilizado novamente.
                    if (!dt.IsClosed) { dt.Close(); }

                    // Query para inserir dados do motorista no banco de dados.
                    strSQL = "insert into motorista_db (nomeMotorista, sobrenomeMotorista, nascimentoMotorista, cpfMotorista, rgMotorista, dddMotorista, telefoneMotorista, endereçoMotorista, numeroMotorista, bairroMotorista, cidadeMotorista, cepMotorista, ufMotorista, cnhMotorista, primeiracnhMotorista, sexo) " +
                        "values (@nomeMotorista,@sobrenomeMotorista,@nascimentoMotorista,@cpfMotorista,@rgMotorista,@dddMotorista,@telefoneMotorista,@endereçoMotorista," +
                        "@numeroMotorista,@bairroMotorista,@cidadeMotorista,@cepMotorista,@ufMotorista,@cnhMotorista,@primeiracnhMotorista,@sexo);" +
                        "SELECT SCOPE_IDENTITY()";

                    // Define parâmetros para a inserção de dados do motorista.
                    cmd.Parameters.Add("@nomeMotorista", SqlDbType.VarChar).Value = nomeMotorista.Text;
                    cmd.Parameters.Add("@sobrenomeMotorista", SqlDbType.VarChar).Value = sobrenomeMotorista.Text;
                    cmd.Parameters.Add("@nascimentoMotorista", SqlDbType.Char).Value = nascimentoMotorista.Text;
                    cmd.Parameters.Add("@cpfMotorista", SqlDbType.Char).Value = cpfMotorista.Text;
                    cmd.Parameters.Add("@rgMotorista", SqlDbType.VarChar).Value = rgMotorista.Text;
                    cmd.Parameters.Add("@dddMotorista", SqlDbType.Char).Value = dddMotorista.Text;
                    cmd.Parameters.Add("@telefoneMotorista", SqlDbType.Char).Value = telefoneMotorista.Text;
                    cmd.Parameters.Add("@endereçoMotorista", SqlDbType.VarChar).Value = endereçoMotorista.Text;
                    cmd.Parameters.Add("@numeroMotorista", SqlDbType.Char).Value = numeroMotorista.Text;
                    cmd.Parameters.Add("@bairroMotorista", SqlDbType.VarChar).Value = bairroMotorista.Text;
                    cmd.Parameters.Add("@cidadeMotorista", SqlDbType.VarChar).Value = cidadeMotorista.Text;
                    cmd.Parameters.Add("@cepMotorista", SqlDbType.Char).Value = cepMotorista.Text;
                    cmd.Parameters.Add("@ufMotorista", SqlDbType.VarChar).Value = ufMotorista.Text;
                    cmd.Parameters.Add("@cnhMotorista", SqlDbType.VarChar).Value = cnhMotorista.Text;
                    cmd.Parameters.Add("@primeiraCnhMotorista", SqlDbType.VarChar).Value = primeiraCnhMotorista.Text;
                    cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sex;

                    // Executa a inserção e obtém o ID do motorista inserido.
                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    // Obtém o ID do motorista recém-inserido.
                    int IdMotoristaInserido = Convert.ToInt32(cmd.ExecuteScalar());

                    // Inserir o novo usuário associado ao motorista
                    string USUARIO_LOGIN = "INSERT INTO usuario_db (IdMotorista, usuario, senha) VALUES (@IdMotorista, @usuario, @senha)";
                    cmd = new SqlCommand(USUARIO_LOGIN, con);
                    cmd.Parameters.AddWithValue("@IdMotorista", IdMotoristaInserido);
                    cmd.Parameters.AddWithValue("@usuario", ParamUsuario);
                    cmd.Parameters.AddWithValue("@senha", ParamSenha);
                    cmd.ExecuteNonQuery();

                    // Exibe uma mensagem de sucesso.
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cria uma instância do formulário para manipulação de dados de veículo.
                    VeiculoCrud FrmMain = new VeiculoCrud();
                    FrmMain.Show(); // Exibe o formulário de veículo.
                    this.Hide(); // Oculta o formulário atual.

                    con.Close(); // Fecha a conexão com o banco de dados.

                    // Limpa os campos do formulário.
                    LimparCampos();

                    // Limpa os parâmetros do comando SQL.
                    cmd.Parameters.Clear();
                }

                con.Close(); // Fecha a conexão com o banco de dados em caso de erro.
            }
            catch (Exception erro)
            {
                // Exibe uma mensagem em caso de erro.
                MessageBox.Show(erro.Message);

                // Fecha a conexão com o banco de dados em caso de erro.
                con.Close();
            }
        }
    }
}