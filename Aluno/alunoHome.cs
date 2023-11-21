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
    // Definição da classe alunoHome, que é um formulário
    public partial class alunoHome : Form
    {
        // Construtor da classe alunoHome
        public alunoHome()
        {
            // Inicializa os componentes do formulário
            InitializeComponent();
        }

        // Manipulador de evento para o clique no botão "Motoristas Cadastrados"
        private void MotoristasCadastrados_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário motoristaView
            MotoristaView FrmMain = new MotoristaView();
            
            // Mostra o formulário motoristaView
            FrmMain.Show();
            
            // Oculta o formulário atual (alunoHome)
            this.Hide();
        }

        // Manipulador de evento para o clique no botão "voltar"
        private void voltar_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário login
            login FrmMain = new login();
            
            // Mostra o formulário login
            FrmMain.Show();
            
            // Oculta o formulário atual (alunoHome)
            this.Hide();
        }
    }
}