using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.LinkLabel;
using System.Xml;

namespace SchoolPaths.Telas
{
    public partial class UsuarioCrud : Form
    {
        // Construtor do formulário.
        public UsuarioCrud()
        {
            InitializeComponent(); // Inicializa os componentes definidos no formulário.
        }

        // Definição de objetos SqlConnection, SqlCommand e SqlDataAdapter.
        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        // Método para limpar os campos do formulário.
        public void LimparCampos()
        {
            senhaCad.Text = "";
            confirmarSenhaCad.Text = "";
            IsAluno.Checked = false;
            IsMotorista.Checked = false;
        }

        // Manipulador de eventos para o clique no botão de confirmação.
        private void Confirmar_Click(object sender, EventArgs e)
        {
            // Verifica se ambas as opções (ALUNO/MOTORISTA) estão selecionadas ao mesmo tempo.
            if (IsAluno.Checked && IsMotorista.Checked)
            {
                // Verifica se ambas as opções (ALUNO/MOTORISTA) estão selecionadas ao mesmo tempo.
                MessageBox.Show("Selecione apenas uma opção (ALUNO/MOTORISTA) para cadastro", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Limpa os campos do formulário.    
                LimparCampos();

                return; // Retorna se os dois campos aluno e motorista, estiverem selecionados ao mesmo tempo.


            }

            // Verifica se nenhuma opção (ALUNO/MOTORISTA) está selecionada.
            if ( !IsAluno.Checked && !IsMotorista.Checked)
                {
                // Exibe uma mensagem de aviso se nenhuma opção for selecionada.
                MessageBox.Show("Por favor, selecione uma opção (ALUNO/MOTORISTA) para cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return; // Retorna se o campo aluno ou motorista não foi selecionado.
                }

            // Verifica se o usuário, senha ou campo de confirmação de senha está em branco.
            if (usuarioCad.Text == "" || senhaCad.Text == "" || confirmarSenhaCad.Text == "")
            {
                // Exibe uma mensagem de aviso se algum dos campos estiver em branco.
                MessageBox.Show("Usuário, senha ou campo de confirmação de senha em branco! Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna se o usuário, senha ou campo de confirmação de senha estiver em branco.
            }

            // Verifica se as senhas digitadas coincidem.
            if (confirmarSenhaCad.Text != senhaCad.Text)
            {
                // Exibe mensagens de erro se as senhas não coincidirem.
                MessageBox.Show("As senhas não conferem!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Tente Novamente!");
                senhaCad.Text = "";
                confirmarSenhaCad.Text = "";
                senhaCad.Focus();

                // Retorna se um dos campos está vazio.
                return; 
            }

            try
            {
                // Abre a conexão com o banco de dados.
                con.Open();

                // Verificar se o usuário já existe
                string verificarUsuarioQuery = "SELECT COUNT(*) FROM usuario_db WHERE usuario = @usuario";
                SqlCommand verificarCmd = new SqlCommand(verificarUsuarioQuery, con);
                verificarCmd.Parameters.AddWithValue("@usuario", usuarioCad.Text);
                int usuarioExistente = (int)verificarCmd.ExecuteScalar();

                // Exibe uma mensagem se o usuário já existir.
                if (usuarioExistente > 0)
                {
                    MessageBox.Show("Usuário já existe! Escolha um nome de usuário diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; // Retorna se o usuário já existe.
                }

                // Abre o formulário correspondente com base na opção selecionada (ALUNO/MOTORISTA).
                if (IsAluno.Checked)
                {
                    AlunoCrud FrmMain = new AlunoCrud(usuarioCad.Text, senhaCad.Text);
                    FrmMain.Show(); // Exibe o formulário para manipulação de dados de aluno.
                    this.Hide(); // Oculta o formulário atual.
                }
                else if (IsMotorista.Checked)
                {
                    MotoristaCrud FrmMain = new MotoristaCrud(usuarioCad.Text, senhaCad.Text);
                    FrmMain.Show(); // Exibe o formulário para manipulação de dados de motorista.
                    this.Hide(); // Oculta o formulário atual.
                }
            }
            catch (Exception erro)
            {
                // Captura e exibe mensagens de erro durante a execução do bloco try.
                string ErroMessage = erro.Message;
                MessageBox.Show(ErroMessage);
                return;
            }
            finally
            {
                // Fecha a conexão com o banco de dados no bloco finally para garantir que seja fechada independentemente do resultado.
                con.Close(); 
            }
        }

        // Manipulador de eventos para a caixa de seleção mostrar/ocultar a senha.
        private void MostrarSenha_CheckedChanged_1(object sender, EventArgs e)
        {
            // Se a caixa de seleção estiver marcada, mostra a senha substituindo os caracteres por '\u0000' (nulo).
            if (MostrarSenha.Checked)
            {
                senhaCad.PasswordChar = '\u0000';
                confirmarSenhaCad.PasswordChar = '\u0000';
            }

            // Se a caixa de seleção estiver desmarcada, oculta a senha substituindo os caracteres por '*'.
            else
            {
                senhaCad.PasswordChar = '*';
                confirmarSenhaCad.PasswordChar = '*';
            }
        }

        // Manipuladores de eventos para a seleção das opções ALUNO/MOTORISTA.
        private void Motorista_CheckedChanged(object sender, EventArgs e)
        {
            IsMotorista.Checked = true; // Marca a opção "Motorista" como selecionada.
            IsAluno.Checked = false; // Desmarca a opção "Aluno".
        }

        // Manipulador de eventos para a seleção da opção "Aluno" no formulário.
        private void Aluno_CheckedChanged(object sender, EventArgs e)
        {
            IsAluno.Checked = true; // Marca a opção "Aluno" como selecionada.
            IsMotorista.Checked = false; // Desmarca a opção "Motorista".
        }

        // Manipulador de eventos para o clique no botão de cancelamento.
        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de login.
            login FrmMain = new login();

            // Exibe o formulário de login.
            FrmMain.Show();

            // Oculta o formulário atual.
            this.Hide();
        }
    }
}



