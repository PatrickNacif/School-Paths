using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPaths.Telas
{
    // Classe que representa um formulário para a tela inicial do motorista.
    public partial class motoristaHome : Form
    {
        // Construtor padrão que inicializa o formulário.
        public motoristaHome()
        {
            InitializeComponent();
        }

        // Manipulador de eventos para o clique no botão "Voltar".
        private void Voltar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de login.
            login FrmMain = new login(); // Exibe o formulário de login.
            FrmMain.Show(); // Exibe o formulário de login.
            this.Hide(); // Oculta o formulário atual.
        }

        // Manipulador de eventos para o clique no botão "Alunos Cadastrados".
        private void AlunosCadastrados_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de visualização de alunos.
            alunoView FrmMain = new alunoView();
            FrmMain.Show(); // Exibe o formulário de visualização de alunos.
            this.Hide(); // Oculta o formulário atual.
        }
    }
}
