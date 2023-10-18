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
    public partial class veiculo : Form
    {
        public veiculo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PATRICK;Initial Catalog=schoolPaths;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        private bool CamposEstaoPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(renavamVeiculo.Text) ||
            string.IsNullOrWhiteSpace(chassiVeiculo.Text) ||
            string.IsNullOrWhiteSpace(corVeiculo.Text) ||
            string.IsNullOrWhiteSpace(modeloVeiculo.Text) ||
            string.IsNullOrWhiteSpace(marcaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(placaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(anoFabricVeiculo.Text) ||
            string.IsNullOrWhiteSpace(potenciaVeiculo.Text) ||
            string.IsNullOrWhiteSpace(combustivelVeiculo.Text) ||
            string.IsNullOrWhiteSpace(capacidadeVeiculo.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void LimparCampos() 
        {
            renavamVeiculo.Text = "";
            chassiVeiculo.Text = "";
            corVeiculo.Text = "";
            modeloVeiculo.Text = "";
            marcaVeiculo.Text = "";
            placaVeiculo.Text = "";
            anoFabricVeiculo.Text = "";
            potenciaVeiculo.Text = "";
            combustivelVeiculo.Text = "";
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            motorista FrmMain = new motorista();
            FrmMain.Show();
            this.Hide();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!CamposEstaoPreenchidos())
            {
                return; // Retorna se os campos não estiverem preenchidos.
            }

            try
            {
                con.Open();
                string strSQL = "Select renavam from veiculo_db where renavam  = '" + renavamVeiculo.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = strSQL;
                dt = cmd.ExecuteReader();

                if (dt.HasRows)
                {
                    MessageBox.Show("Renavam já cadastrado!", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dt.HasRows)
                {
                    if (!dt.IsClosed) { dt.Close(); }
                    strSQL = "insert into veiculo_db (renavam, chassi, cor, modelo, marca, placa, anofabric, potencia, combustivel, capacidade) " +
                        "values (@renavam,@chassi,@cor,@modelo,@marca,@placa,@anofabric,@potencia,@combustivel, @capacidade)";
                    cmd.Parameters.Add("@renavam", SqlDbType.VarChar).Value = renavamVeiculo.Text;
                    cmd.Parameters.Add("@chassi", SqlDbType.VarChar).Value = chassiVeiculo.Text;
                    cmd.Parameters.Add("@cor", SqlDbType.Char).Value = corVeiculo.Text;
                    cmd.Parameters.Add("@modelo", SqlDbType.Char).Value = modeloVeiculo.Text;
                    cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = marcaVeiculo.Text;
                    cmd.Parameters.Add("@placa", SqlDbType.Char).Value = placaVeiculo.Text;
                    cmd.Parameters.Add("@anofabric", SqlDbType.Char).Value = anoFabricVeiculo.Text;
                    cmd.Parameters.Add("@potencia", SqlDbType.VarChar).Value = potenciaVeiculo.Text;
                    cmd.Parameters.Add("@combustivel", SqlDbType.Char).Value = combustivelVeiculo.Text;
                    cmd.Parameters.Add("@capacidade", SqlDbType.VarChar).Value = capacidadeVeiculo.Text;

                    cmd.Connection = con;
                    cmd.CommandText = strSQL;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

