using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolPaths.Telas
{
    public partial class alunoView : Form
    {
        public alunoView()
        {
            InitializeComponent();
        }     

        // Manipulador de evento para o clique no botão "voltar"
        private void Voltar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário motoristaHome
            motoristaHome FrmMain = new motoristaHome();
            
            // Mostra o formulário motoristaHome
            FrmMain.Show();
            
            // Oculta o formulário atual (alunoView)
            this.Hide();
        }

        // Manipulador de evento para o clique no botão "Buscar"
        private void Buscar_Click(object sender, EventArgs e)
        {
            // Cria uma SqlConnection usando uma string de conexão
            SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");

            // Limpa os itens em alunoTable (assumindo que seja um ListView ou controle semelhante)
            alunoTable.Items.Clear();

            try
            {
                // Abre a conexão com o banco de dados
                con.Open();

                // Cria um SqlCommand para executar uma consulta SQL
                SqlCommand cmd = new SqlCommand("SELECT nome +' '+ sobrenome AS NomeCompleto, cpf, nascimento, escola, cidade FROM aluno_db WHERE nome+' '+sobrenome LIKE '%" + pesquisarAluno.Text + "%' OR '" + pesquisarAluno.Text + "' = ''", con);

                // Executa a consulta e obtém um SqlDataReader
                SqlDataReader dt = cmd.ExecuteReader();

                // Loop pelos resultados e adiciona-os a alunoTable (assumindo que seja um ListView ou controle semelhante)
                while (dt.Read())
                {
                    // Adiciona as colunas a alunoTable
                    var item1 = alunoTable.Items.Add(dt["NomeCompleto"].ToString());
                    item1.SubItems.Add(dt["nascimento"].ToString());
                    item1.SubItems.Add(dt["escola"].ToString());
                    item1.SubItems.Add(dt["cidade"].ToString());
                }

                // Fecha a conexão com o banco de dados
                con.Close();
            }
            catch (Exception erro)
            {
                // Exibe uma mensagem de erro se ocorrer uma exceção
                MessageBox.Show(erro.Message);
                
                // Fecha a conexão com o banco de dados
                con.Close();
            }
        }
    }
}

