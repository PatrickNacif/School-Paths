namespace SchoolPaths.Telas
{
    partial class MotoristaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoristaView));
            this.motoristaTable = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Buscar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pesquisarMotorista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // motoristaTable
            // 
            this.motoristaTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.motoristaTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Telefone,
            this.Cidade});
            this.motoristaTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motoristaTable.GridLines = true;
            this.motoristaTable.HideSelection = false;
            this.motoristaTable.Location = new System.Drawing.Point(13, 73);
            this.motoristaTable.Name = "motoristaTable";
            this.motoristaTable.Size = new System.Drawing.Size(816, 408);
            this.motoristaTable.TabIndex = 70;
            this.motoristaTable.UseCompatibleStateImageBehavior = false;
            this.motoristaTable.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 360;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 242;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 212;
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(741, 17);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(87, 29);
            this.Buscar.TabIndex = 73;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
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
            this.voltar.TabIndex = 72;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 50);
            this.label6.TabIndex = 71;
            this.label6.Text = "Lista de Motoristas:";
            // 
            // pesquisarMotorista
            // 
            this.pesquisarMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarMotorista.Location = new System.Drawing.Point(444, 17);
            this.pesquisarMotorista.Multiline = true;
            this.pesquisarMotorista.Name = "pesquisarMotorista";
            this.pesquisarMotorista.Size = new System.Drawing.Size(301, 29);
            this.pesquisarMotorista.TabIndex = 74;
            // 
            // motoristaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.pesquisarMotorista);
            this.Controls.Add(this.motoristaTable);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "motoristaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "motoristaView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView motoristaTable;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pesquisarMotorista;
        private System.Windows.Forms.ColumnHeader Cidade;
    }
}