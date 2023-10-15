namespace SchoolPaths
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.confirmar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.masculinoAluno = new System.Windows.Forms.RadioButton();
            this.femininoAluno = new System.Windows.Forms.RadioButton();
            this.dddAluno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.telefoneAluno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.escolaAluno = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numeroAluno = new System.Windows.Forms.TextBox();
            this.bairroAluno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cpfAluno = new System.Windows.Forms.TextBox();
            this.rgAluno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cidadeAluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ufAluno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cepAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endereçoAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sobrenomeAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataNascimentoAluno = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.Location = new System.Drawing.Point(438, 488);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(124, 42);
            this.confirmar.TabIndex = 13;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(273, 488);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(124, 42);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolPaths.Properties.Resources.Usuário;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 148);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // Sexo
            // 
            this.Sexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sexo.Controls.Add(this.masculinoAluno);
            this.Sexo.Controls.Add(this.femininoAluno);
            this.Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sexo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.Sexo.Location = new System.Drawing.Point(543, 378);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(254, 69);
            this.Sexo.TabIndex = 109;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo:";
            // 
            // masculinoAluno
            // 
            this.masculinoAluno.AutoSize = true;
            this.masculinoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masculinoAluno.Location = new System.Drawing.Point(24, 31);
            this.masculinoAluno.Name = "masculinoAluno";
            this.masculinoAluno.Size = new System.Drawing.Size(107, 24);
            this.masculinoAluno.TabIndex = 31;
            this.masculinoAluno.TabStop = true;
            this.masculinoAluno.Text = "Masculino";
            this.masculinoAluno.UseVisualStyleBackColor = true;
            // 
            // femininoAluno
            // 
            this.femininoAluno.AutoSize = true;
            this.femininoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femininoAluno.Location = new System.Drawing.Point(137, 31);
            this.femininoAluno.Name = "femininoAluno";
            this.femininoAluno.Size = new System.Drawing.Size(100, 24);
            this.femininoAluno.TabIndex = 32;
            this.femininoAluno.TabStop = true;
            this.femininoAluno.Text = "Feminino";
            this.femininoAluno.UseVisualStyleBackColor = true;
            // 
            // dddAluno
            // 
            this.dddAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dddAluno.Location = new System.Drawing.Point(540, 246);
            this.dddAluno.Multiline = true;
            this.dddAluno.Name = "dddAluno";
            this.dddAluno.Size = new System.Drawing.Size(50, 29);
            this.dddAluno.TabIndex = 108;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(536, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 22);
            this.label16.TabIndex = 107;
            this.label16.Text = "DDD:";
            // 
            // telefoneAluno
            // 
            this.telefoneAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneAluno.Location = new System.Drawing.Point(612, 246);
            this.telefoneAluno.Multiline = true;
            this.telefoneAluno.Name = "telefoneAluno";
            this.telefoneAluno.Size = new System.Drawing.Size(185, 29);
            this.telefoneAluno.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(621, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 22);
            this.label15.TabIndex = 105;
            this.label15.Text = "Telefone:";
            // 
            // escolaAluno
            // 
            this.escolaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolaAluno.Location = new System.Drawing.Point(27, 418);
            this.escolaAluno.Multiline = true;
            this.escolaAluno.Name = "escolaAluno";
            this.escolaAluno.Size = new System.Drawing.Size(459, 29);
            this.escolaAluno.TabIndex = 104;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 22);
            this.label14.TabIndex = 103;
            this.label14.Text = "Instituição de Ensino:";
            // 
            // numeroAluno
            // 
            this.numeroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAluno.Location = new System.Drawing.Point(484, 304);
            this.numeroAluno.Multiline = true;
            this.numeroAluno.Name = "numeroAluno";
            this.numeroAluno.Size = new System.Drawing.Size(78, 29);
            this.numeroAluno.TabIndex = 102;
            // 
            // bairroAluno
            // 
            this.bairroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroAluno.Location = new System.Drawing.Point(584, 304);
            this.bairroAluno.Multiline = true;
            this.bairroAluno.Name = "bairroAluno";
            this.bairroAluno.Size = new System.Drawing.Size(213, 29);
            this.bairroAluno.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(580, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 22);
            this.label12.TabIndex = 100;
            this.label12.Text = "Bairro:";
            // 
            // cpfAluno
            // 
            this.cpfAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfAluno.Location = new System.Drawing.Point(27, 247);
            this.cpfAluno.Multiline = true;
            this.cpfAluno.Name = "cpfAluno";
            this.cpfAluno.Size = new System.Drawing.Size(230, 29);
            this.cpfAluno.TabIndex = 99;
            // 
            // rgAluno
            // 
            this.rgAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgAluno.Location = new System.Drawing.Point(286, 246);
            this.rgAluno.Multiline = true;
            this.rgAluno.Name = "rgAluno";
            this.rgAluno.Size = new System.Drawing.Size(229, 29);
            this.rgAluno.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 97;
            this.label11.Text = "RG:";
            // 
            // cidadeAluno
            // 
            this.cidadeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeAluno.Location = new System.Drawing.Point(27, 361);
            this.cidadeAluno.Multiline = true;
            this.cidadeAluno.Name = "cidadeAluno";
            this.cidadeAluno.Size = new System.Drawing.Size(141, 29);
            this.cidadeAluno.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 95;
            this.label9.Text = "Cidade:";
            // 
            // ufAluno
            // 
            this.ufAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufAluno.FormattingEnabled = true;
            this.ufAluno.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.ufAluno.Location = new System.Drawing.Point(336, 358);
            this.ufAluno.Name = "ufAluno";
            this.ufAluno.Size = new System.Drawing.Size(61, 32);
            this.ufAluno.TabIndex = 94;
            this.ufAluno.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 93;
            this.label8.Text = "Nascimento :";
            // 
            // cepAluno
            // 
            this.cepAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepAluno.Location = new System.Drawing.Point(189, 361);
            this.cepAluno.Multiline = true;
            this.cepAluno.Name = "cepAluno";
            this.cepAluno.Size = new System.Drawing.Size(129, 29);
            this.cepAluno.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 91;
            this.label6.Text = "CEP:";
            // 
            // endereçoAluno
            // 
            this.endereçoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereçoAluno.Location = new System.Drawing.Point(27, 304);
            this.endereçoAluno.Multiline = true;
            this.endereçoAluno.Name = "endereçoAluno";
            this.endereçoAluno.Size = new System.Drawing.Size(433, 29);
            this.endereçoAluno.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 89;
            this.label7.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 88;
            this.label5.Text = "CPF:";
            // 
            // sobrenomeAluno
            // 
            this.sobrenomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobrenomeAluno.Location = new System.Drawing.Point(370, 191);
            this.sobrenomeAluno.Multiline = true;
            this.sobrenomeAluno.Name = "sobrenomeAluno";
            this.sobrenomeAluno.Size = new System.Drawing.Size(279, 29);
            this.sobrenomeAluno.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "Sobrenome:";
            // 
            // nomeAluno
            // 
            this.nomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAluno.Location = new System.Drawing.Point(27, 191);
            this.nomeAluno.Multiline = true;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(320, 29);
            this.nomeAluno.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nome:";
            // 
            // dataNascimentoAluno
            // 
            this.dataNascimentoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoAluno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimentoAluno.Location = new System.Drawing.Point(670, 189);
            this.dataNascimentoAluno.Name = "dataNascimentoAluno";
            this.dataNascimentoAluno.Size = new System.Drawing.Size(127, 29);
            this.dataNascimentoAluno.TabIndex = 110;
            this.dataNascimentoAluno.Value = new System.DateTime(2023, 9, 30, 17, 39, 0, 0);
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(826, 546);
            this.Controls.Add(this.dataNascimentoAluno);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.dddAluno);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.telefoneAluno);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.escolaAluno);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numeroAluno);
            this.Controls.Add(this.bairroAluno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cpfAluno);
            this.Controls.Add(this.rgAluno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cidadeAluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ufAluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cepAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endereçoAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sobrenomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.RadioButton masculinoAluno;
        private System.Windows.Forms.RadioButton femininoAluno;
        private System.Windows.Forms.TextBox dddAluno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox telefoneAluno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox escolaAluno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox numeroAluno;
        private System.Windows.Forms.TextBox bairroAluno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cpfAluno;
        private System.Windows.Forms.TextBox rgAluno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cidadeAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ufAluno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cepAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endereçoAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sobrenomeAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataNascimentoAluno;
    }
}