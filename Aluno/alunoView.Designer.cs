namespace SchoolPaths.Telas
{
    partial class alunoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alunoView));
            this.alunoTable = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Escola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.pesquisarAluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // alunoTable
            // 
            this.alunoTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.alunoTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Nascimento,
            this.Escola,
            this.Cidade});
            this.alunoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoTable.GridLines = true;
            this.alunoTable.HideSelection = false;
            this.alunoTable.Location = new System.Drawing.Point(12, 77);
            this.alunoTable.Name = "alunoTable";
            this.alunoTable.Size = new System.Drawing.Size(816, 399);
            this.alunoTable.TabIndex = 0;
            this.alunoTable.UseCompatibleStateImageBehavior = false;
            this.alunoTable.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // Nascimento
            // 
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.Width = 202;
            // 
            // Escola
            // 
            this.Escola.Text = "Escola";
            this.Escola.Width = 175;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 233;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 50);
            this.label6.TabIndex = 67;
            this.label6.Text = "Lista de Alunos:";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(353, 487);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(124, 42);
            this.voltar.TabIndex = 68;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(741, 20);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(87, 31);
            this.Buscar.TabIndex = 69;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // pesquisarAluno
            // 
            this.pesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarAluno.Location = new System.Drawing.Point(442, 20);
            this.pesquisarAluno.Multiline = true;
            this.pesquisarAluno.Name = "pesquisarAluno";
            this.pesquisarAluno.Size = new System.Drawing.Size(301, 31);
            this.pesquisarAluno.TabIndex = 75;
            // 
            // alunoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(840, 545);
            this.Controls.Add(this.pesquisarAluno);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alunoTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "alunoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alunoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView alunoTable;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader Escola;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox pesquisarAluno;
    }
}