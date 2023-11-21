using System;

namespace SchoolPaths.Telas
{
    partial class UsuarioCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioCrud));
            this.confirmarSenhaCad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senhaCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IsAluno = new System.Windows.Forms.CheckBox();
            this.IsMotorista = new System.Windows.Forms.CheckBox();
            this.MostrarSenha = new System.Windows.Forms.CheckBox();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmarSenhaCad
            // 
            this.confirmarSenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarSenhaCad.Location = new System.Drawing.Point(165, 350);
            this.confirmarSenhaCad.Multiline = true;
            this.confirmarSenhaCad.Name = "confirmarSenhaCad";
            this.confirmarSenhaCad.PasswordChar = '*';
            this.confirmarSenhaCad.Size = new System.Drawing.Size(289, 29);
            this.confirmarSenhaCad.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 131;
            this.label1.Text = "Confirmar Senha:";
            // 
            // senhaCad
            // 
            this.senhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaCad.Location = new System.Drawing.Point(165, 277);
            this.senhaCad.Multiline = true;
            this.senhaCad.Name = "senhaCad";
            this.senhaCad.PasswordChar = '*';
            this.senhaCad.Size = new System.Drawing.Size(289, 29);
            this.senhaCad.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 129;
            this.label3.Text = "Senha:";
            // 
            // usuarioCad
            // 
            this.usuarioCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioCad.Location = new System.Drawing.Point(165, 206);
            this.usuarioCad.Multiline = true;
            this.usuarioCad.Name = "usuarioCad";
            this.usuarioCad.Size = new System.Drawing.Size(289, 29);
            this.usuarioCad.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 127;
            this.label2.Text = "Usuário:";
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.confirmar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.Location = new System.Drawing.Point(330, 465);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(124, 42);
            this.confirmar.TabIndex = 126;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SchoolPaths.Properties.Resources.Fundo_Azul2;
            this.pictureBox3.Location = new System.Drawing.Point(115, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(384, 347);
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 136;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // IsAluno
            // 
            this.IsAluno.AutoSize = true;
            this.IsAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.IsAluno.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAluno.ForeColor = System.Drawing.Color.Black;
            this.IsAluno.Location = new System.Drawing.Point(205, 419);
            this.IsAluno.Name = "IsAluno";
            this.IsAluno.Size = new System.Drawing.Size(75, 26);
            this.IsAluno.TabIndex = 137;
            this.IsAluno.Text = "Aluno";
            this.IsAluno.UseVisualStyleBackColor = false;
            this.IsAluno.Click += new System.EventHandler(this.Aluno_CheckedChanged);
            // 
            // IsMotorista
            // 
            this.IsMotorista.AutoSize = true;
            this.IsMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.IsMotorista.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMotorista.ForeColor = System.Drawing.Color.Black;
            this.IsMotorista.Location = new System.Drawing.Point(296, 419);
            this.IsMotorista.Name = "IsMotorista";
            this.IsMotorista.Size = new System.Drawing.Size(109, 26);
            this.IsMotorista.TabIndex = 138;
            this.IsMotorista.Text = "Motorista";
            this.IsMotorista.UseVisualStyleBackColor = false;
            this.IsMotorista.Click += new System.EventHandler(this.Motorista_CheckedChanged);
            // 
            // MostrarSenha
            // 
            this.MostrarSenha.AutoSize = true;
            this.MostrarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.MostrarSenha.Font = new System.Drawing.Font("Exotc350 Bd BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarSenha.ForeColor = System.Drawing.Color.Black;
            this.MostrarSenha.Location = new System.Drawing.Point(348, 394);
            this.MostrarSenha.Name = "MostrarSenha";
            this.MostrarSenha.Size = new System.Drawing.Size(106, 19);
            this.MostrarSenha.TabIndex = 139;
            this.MostrarSenha.Text = "Mostrar Senha";
            this.MostrarSenha.UseVisualStyleBackColor = false;
            this.MostrarSenha.CheckedChanged += new System.EventHandler(this.MostrarSenha_CheckedChanged_1);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(156, 465);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(124, 42);
            this.cancelar.TabIndex = 140;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // usuarioCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(627, 552);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.MostrarSenha);
            this.Controls.Add(this.IsMotorista);
            this.Controls.Add(this.IsAluno);
            this.Controls.Add(this.confirmarSenhaCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhaCad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuarioCad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usuarioCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuarioSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            throw new ImplementedException();
        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            throw new ImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox confirmarSenhaCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhaCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuarioCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox IsAluno;
        private System.Windows.Forms.CheckBox IsMotorista;
        private System.Windows.Forms.CheckBox MostrarSenha;
        private System.Windows.Forms.Button cancelar;
    }
}