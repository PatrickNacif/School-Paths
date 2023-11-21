namespace SchoolPaths
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mostrarSenha = new System.Windows.Forms.CheckBox();
            this.cadastro = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SchoolPaths.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 532);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // mostrarSenha
            // 
            this.mostrarSenha.AutoSize = true;
            this.mostrarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(122)))), ((int)(((byte)(117)))));
            this.mostrarSenha.Font = new System.Drawing.Font("Exotc350 Bd BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarSenha.ForeColor = System.Drawing.Color.Black;
            this.mostrarSenha.Location = new System.Drawing.Point(659, 439);
            this.mostrarSenha.Name = "mostrarSenha";
            this.mostrarSenha.Size = new System.Drawing.Size(106, 19);
            this.mostrarSenha.TabIndex = 33;
            this.mostrarSenha.Text = "Mostrar Senha";
            this.mostrarSenha.UseVisualStyleBackColor = false;
            this.mostrarSenha.CheckedChanged += new System.EventHandler(this.MostrarSenha_CheckedChanged);
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cadastro.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastro.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.Location = new System.Drawing.Point(568, 468);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(99, 32);
            this.cadastro.TabIndex = 32;
            this.cadastro.Text = "Cadastro ";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(609, 395);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(156, 34);
            this.senha.TabIndex = 31;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(609, 351);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(156, 34);
            this.usuario.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(122)))), ((int)(((byte)(117)))));
            this.label4.Font = new System.Drawing.Font("Exotc350 Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(122)))), ((int)(((byte)(117)))));
            this.label3.Font = new System.Drawing.Font("Exotc350 Bd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Login";
            // 
            // acessar
            // 
            this.acessar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.acessar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acessar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessar.Location = new System.Drawing.Point(673, 468);
            this.acessar.Name = "acessar";
            this.acessar.Size = new System.Drawing.Size(92, 32);
            this.acessar.TabIndex = 27;
            this.acessar.Text = "Acessar";
            this.acessar.UseVisualStyleBackColor = false;
            this.acessar.Click += new System.EventHandler(this.Acessar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 532);
            this.Controls.Add(this.mostrarSenha);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acessar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox mostrarSenha;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acessar;
    }
}