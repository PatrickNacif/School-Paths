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

namespace SchoolPaths
{
    public partial class UsuarioSenha : Form
    {
        public UsuarioSenha()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection (@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();             

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if(usuarioCad.Text==""&& senhaCad.Text=="")
            {
                MessageBox.Show("Senha/Usuário Errada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Tente Novamente!");
            }

            else if(confirmarSenhaCad.Text == senhaCad.Text)
            {
                con.Open();
                string USUARIO_LOGIN = "insert into usuario_db values('" + usuarioCad.Text + "','" + senhaCad.Text + "')";
                cmd = new SqlCommand(USUARIO_LOGIN, con);
                cmd.ExecuteReader();
                con.Close();
                usuarioCad.Text = ""; senhaCad.Text = ""; confirmarSenhaCad.Text = "";
                MessageBox.Show("Usuário Criado com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Seja Bem-Vindo!");
                login FrmMain = new login();
                FrmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("As Senhas Não Conferem!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Tente Novamente!");
                senhaCad.Text = "";
                confirmarSenhaCad.Text = "";
                senhaCad.Focus();   
            }
        }
        
        private void Cancelar_Click(object sender, EventArgs e)
        {
            login FrmMain = new login();
            FrmMain.Show();
            this.Hide();
        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarSenha.Checked)
            {
                senhaCad.PasswordChar = '\u0000';
                confirmarSenhaCad.PasswordChar = '\u0000';
            }
            else
            {
                senhaCad.PasswordChar = '*';
                confirmarSenhaCad.PasswordChar = '*';
            }
        }
    }
}
