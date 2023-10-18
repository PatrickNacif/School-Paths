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
    public partial class motorista : Form
    {
        public motorista()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

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
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            alunoMotorista FrmMain = new alunoMotorista();
            FrmMain.Show();
            this.Hide();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }

            string sex = "";

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
                MessageBox.Show("Por favor, selecione uma opção de sexo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Retorna se o sexo não foi selecionado.
            }

            try
            {
                con.Open();
                string strSQL = "Select cpfMotorista from motorista_db where cpfMotorista  = '" + cpfMotorista.Text + "'";
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
                    strSQL = "insert into motorista_db (nomeMotorista, sobrenomeMotorista, nascimentoMotorista, cpfMotorista, rgMotorista, dddMotorista, telefoneMotorista, endereçoMotorista, numeroMotorista, bairroMotorista, cidadeMotorista, cepMotorista, ufMotorista, cnhMotorista, primeiracnhMotorista, sexo) " +
                        "values (@nomeMotorista,@sobrenomeMotorista,@nascimentoMotorista,@cpfMotorista,@rgMotorista,@dddMotorista,@telefoneMotorista,@endereçoMotorista," +
                        "@numeroMotorista,@bairroMotorista,@cidadeMotorista,@cepMotorista,@ufMotorista,@cnhMotorista,@primeiracnhMotorista,@sexo)";
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

                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    veiculo FrmMain = new veiculo();
                    FrmMain.Show();
                    this.Hide();
                    con.Close();

                    LimparCampos();
                    cmd.Parameters.Clear(); 
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.Close();
            }
        }
    }
}