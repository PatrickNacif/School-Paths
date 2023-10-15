namespace SchoolPaths
{
    partial class alunoMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alunoMotorista));
            this.aluno = new System.Windows.Forms.Button();
            this.motorista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aluno
            // 
            this.aluno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.aluno.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aluno.Font = new System.Drawing.Font("Exotc350 Bd BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aluno.Location = new System.Drawing.Point(136, 348);
            this.aluno.Name = "aluno";
            this.aluno.Size = new System.Drawing.Size(197, 84);
            this.aluno.TabIndex = 6;
            this.aluno.Text = "Aluno";
            this.aluno.UseVisualStyleBackColor = false;
            this.aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // motorista
            // 
            this.motorista.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.motorista.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorista.Font = new System.Drawing.Font("Exotc350 Bd BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorista.Location = new System.Drawing.Point(403, 156);
            this.motorista.Name = "motorista";
            this.motorista.Size = new System.Drawing.Size(311, 88);
            this.motorista.TabIndex = 5;
            this.motorista.Text = "Motorista";
            this.motorista.UseVisualStyleBackColor = false;
            this.motorista.Click += new System.EventHandler(this.Motorista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SchoolPaths.Properties.Resources.Registro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 547);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(12, 503);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(92, 32);
            this.voltar.TabIndex = 19;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // alunoMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 547);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.aluno);
            this.Controls.Add(this.motorista);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "alunoMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alunoMotorista";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aluno;
        private System.Windows.Forms.Button motorista;
        private System.Windows.Forms.Button voltar;
    }
}