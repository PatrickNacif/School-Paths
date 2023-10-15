using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            alunoMotorista FrmMain = new alunoMotorista();
            FrmMain.Show();
            this.Hide();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Salvo com Sucesso!");
            veiculo FrmMain = new veiculo();
            FrmMain.Show();
            this.Hide();
        }
    }
}
