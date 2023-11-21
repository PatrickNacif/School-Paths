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
    public partial class login : Form
    {
        // Propriedade privada para verificar se o usuário é um "Aluno" (estudante).
        public bool IsAluno { get; private set; }

        // Construtor para o formulário de login.
        public login()
        {
            InitializeComponent(); // Inicializa os componentes definidos no formulário.
        }

        // Manipulador de eventos para o clique no botão.
        private void Acessar_Click(object sender, EventArgs e)
        {
            // String de conexão com o banco de dados.
            string connectionString = @"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True";

            // Consulta SQL para selecionar o usuário com base no nome de usuário e senha.
            string query = "SELECT * FROM usuario_db WHERE usuario = @Usuario AND senha = @Senha";

            // Declaração 'using' para garantir a correta eliminação dos objetos SqlConnection e SqlCommand.
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open(); // Abre a conexão com o banco de dados.

                    // Define parâmetros para a consulta SQL.
                    cmd.Parameters.AddWithValue("@Usuario", usuario.Text);
                    cmd.Parameters.AddWithValue("@Senha", senha.Text);

                    // Declaração 'using' para ler dados do banco de dados.
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Verifica se o usuário é um aluno.
                            if (!dr.IsDBNull(4))
                            {
                                // Exibe uma mensagem de boas-vindas e mostra o formulário principal do aluno.
                                MessageBox.Show("Seja Bem-Vindo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                alunoHome FrmMain = new alunoHome();
                                FrmMain.Show();
                                this.Hide();
                            }
                            // Verifica se o usuário é um motorista.
                            else if (!dr.IsDBNull(3))
                            {
                                // Exibe uma mensagem de boas-vindas e mostra o formulário principal do motorista.
                                MessageBox.Show("Seja Bem-Vindo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                motoristaHome FrmMain = new motoristaHome();

                                // Mostra o formulário motoristaHome
                                FrmMain.Show();

                                // Oculta o formulário de login atual.
                                this.Hide(); 
                            }
                        }
                        else
                        {
                            // Exibe mensagens de erro para nome de usuário/senha inválidos.
                            MessageBox.Show("Senha/Usuário Inválidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show("Tente Novamente!");
                            usuario.Text = "";
                            senha.Text = "";
                            usuario.Focus();
                        }
                    }
                }
            }
        }

        // Manipulador de eventos para a caixa de seleção mostrar/ocultar a senha.
        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Mostra ou oculta a senha com base no estado da caixa de seleção.
            if (mostrarSenha.Checked)
            {
                senha.PasswordChar = '\0'; // Mostra a senha.
            }
            else
            {
                senha.PasswordChar = '*'; // Oculta a senha.
            }
        }

        // Manipulador de eventos para o clique no botão para abrir o formulário de registro de usuário.
        private void Cadastro_Click(object sender, EventArgs e)
        {
            // Mostra o formulário de registro de usuário.
            new UsuarioCrud().Show(); 

            // Oculta o formulário de login atual.
            this.Hide(); 
        }
    }
}