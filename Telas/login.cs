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

namespace SchoolPaths
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Acessar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "select * from usuario_db where usuario= '" + usuario.Text + "'and senha='" + senha.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Seja Bem-Vindo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                alunoMotorista FrmMain = new alunoMotorista();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha/Usuário Invalidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Tente Novamente!");
                usuario.Text = "";
                senha.Text = "";
                usuario.Focus();
            }
        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(mostrarSenha.Checked)
            {
                senha.PasswordChar = '\0';
            }
            else
            {
                senha.PasswordChar = '*';
            }
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            new UsuarioSenha().Show();
            this.Hide();
        }
    }
}