﻿using System;
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
    public partial class veiculo : Form
    {
        public veiculo()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            motorista FrmMain = new motorista();
            FrmMain.Show();
            this.Hide();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados do seu Veículo Salvo com Sucesso!");
        }
    }
}