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
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        public void LimparCampos()
        {
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
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }

            string sex = "";

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
                MessageBox.Show("Por favor, selecione uma opção de sexo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna se o sexo não foi selecionado.
            }

            try
            {
                con.Open();
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
                    strSQL = "insert into aluno_db (nome, sobrenome, nascimento, cpf, rg, ddd, telefone, endereço, numero, bairro, cidade, cep, uf, escola, sexo) " +
                        "values (@nome,@sobrenome,@nascimento,@cpf,@rg,@ddd,@telefone,@endereço,@numero,@bairro,@cidade,@cep,@uf,@escola,@sexo)";
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

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    cmd.Parameters.Clear();
                    con.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            alunoMotorista FrmMain = new alunoMotorista();
            FrmMain.Show();
            this.Hide();
        }
    }
}