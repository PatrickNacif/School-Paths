namespace SchoolPaths.Telas
{
    partial class motoristaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motoristaHome));
            this.AlunosCadastrados = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AlunosCadastrados
            // 
            this.AlunosCadastrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(194)))), ((int)(((byte)(70)))));
            this.AlunosCadastrados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(194)))), ((int)(((byte)(70)))));
            this.AlunosCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlunosCadastrados.Font = new System.Drawing.Font("Exotc350 Bd BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlunosCadastrados.Location = new System.Drawing.Point(409, 151);
            this.AlunosCadastrados.Name = "AlunosCadastrados";
            this.AlunosCadastrados.Size = new System.Drawing.Size(224, 96);
            this.AlunosCadastrados.TabIndex = 151;
            this.AlunosCadastrados.Text = "Alunos";
            this.AlunosCadastrados.UseVisualStyleBackColor = false;
            this.AlunosCadastrados.Click += new System.EventHandler(this.AlunosCadastrados_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(194)))), ((int)(((byte)(70)))));
            this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(194)))), ((int)(((byte)(70)))));
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(22, 434);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(92, 32);
            this.voltar.TabIndex = 150;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SchoolPaths.Properties.Resources.Captura_de_tela_2023_10_26_120629;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(706, 488);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 153;
            this.pictureBox3.TabStop = false;
            // 
            // motoristaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 485);
            this.Controls.Add(this.AlunosCadastrados);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "motoristaHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "motorista";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AlunosCadastrados;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}