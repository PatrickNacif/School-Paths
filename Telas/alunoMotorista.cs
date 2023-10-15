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
    public partial class alunoMotorista : Form
    {
        public alunoMotorista()
        {
            InitializeComponent();
        }       
        private void Motorista_Click(object sender, EventArgs e)
        {
            motorista FrmMain = new motorista();
            FrmMain.Show();
            this.Hide();
        }

        private void Aluno_Click(object sender, EventArgs e)
        {
            Aluno FrmMain = new Aluno();
            FrmMain.Show();
            this.Hide();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            login FrmMain = new login();
            FrmMain.Show();
            this.Hide();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }
    }
}
