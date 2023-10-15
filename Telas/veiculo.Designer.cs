namespace SchoolPaths
{
    partial class veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veiculo));
            this.modeloVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.placaVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.anoFabricVeiculo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.renavamVeiculo = new System.Windows.Forms.TextBox();
            this.chassiVeiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.corVeiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.potenciaVeiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combustivelVeiculo = new System.Windows.Forms.TextBox();
            this.capacidadeVeiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.marcaVeiculo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloVeiculo
            // 
            this.modeloVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloVeiculo.Location = new System.Drawing.Point(27, 266);
            this.modeloVeiculo.Multiline = true;
            this.modeloVeiculo.Name = "modeloVeiculo";
            this.modeloVeiculo.Size = new System.Drawing.Size(396, 29);
            this.modeloVeiculo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Modelo:";
            // 
            // placaVeiculo
            // 
            this.placaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaVeiculo.Location = new System.Drawing.Point(635, 266);
            this.placaVeiculo.Multiline = true;
            this.placaVeiculo.Name = "placaVeiculo";
            this.placaVeiculo.Size = new System.Drawing.Size(163, 29);
            this.placaVeiculo.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ano Fabricação:";
            // 
            // anoFabricVeiculo
            // 
            this.anoFabricVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoFabricVeiculo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.anoFabricVeiculo.Location = new System.Drawing.Point(27, 338);
            this.anoFabricVeiculo.Name = "anoFabricVeiculo";
            this.anoFabricVeiculo.Size = new System.Drawing.Size(127, 29);
            this.anoFabricVeiculo.TabIndex = 57;
            this.anoFabricVeiculo.Value = new System.DateTime(2023, 9, 30, 17, 39, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(438, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 59;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(273, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 58;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // renavamVeiculo
            // 
            this.renavamVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renavamVeiculo.Location = new System.Drawing.Point(27, 199);
            this.renavamVeiculo.Multiline = true;
            this.renavamVeiculo.Name = "renavamVeiculo";
            this.renavamVeiculo.Size = new System.Drawing.Size(280, 29);
            this.renavamVeiculo.TabIndex = 68;
            // 
            // chassiVeiculo
            // 
            this.chassiVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassiVeiculo.Location = new System.Drawing.Point(330, 199);
            this.chassiVeiculo.Multiline = true;
            this.chassiVeiculo.Name = "chassiVeiculo";
            this.chassiVeiculo.Size = new System.Drawing.Size(280, 29);
            this.chassiVeiculo.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Chassi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Renavam:";
            // 
            // corVeiculo
            // 
            this.corVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corVeiculo.Location = new System.Drawing.Point(635, 199);
            this.corVeiculo.Multiline = true;
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.Size = new System.Drawing.Size(163, 29);
            this.corVeiculo.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 22);
            this.label7.TabIndex = 69;
            this.label7.Text = "Cor:";
            // 
            // potenciaVeiculo
            // 
            this.potenciaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciaVeiculo.Location = new System.Drawing.Point(179, 338);
            this.potenciaVeiculo.Multiline = true;
            this.potenciaVeiculo.Name = "potenciaVeiculo";
            this.potenciaVeiculo.Size = new System.Drawing.Size(187, 29);
            this.potenciaVeiculo.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 71;
            this.label8.Text = "Potência:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(390, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 73;
            this.label9.Text = "Combustível:";
            // 
            // combustivelVeiculo
            // 
            this.combustivelVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combustivelVeiculo.Location = new System.Drawing.Point(394, 338);
            this.combustivelVeiculo.Multiline = true;
            this.combustivelVeiculo.Name = "combustivelVeiculo";
            this.combustivelVeiculo.Size = new System.Drawing.Size(187, 29);
            this.combustivelVeiculo.TabIndex = 74;
            // 
            // capacidadeVeiculo
            // 
            this.capacidadeVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacidadeVeiculo.Location = new System.Drawing.Point(607, 338);
            this.capacidadeVeiculo.Multiline = true;
            this.capacidadeVeiculo.Name = "capacidadeVeiculo";
            this.capacidadeVeiculo.Size = new System.Drawing.Size(191, 29);
            this.capacidadeVeiculo.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(603, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 22);
            this.label10.TabIndex = 75;
            this.label10.Text = "Capacidade:";
            // 
            // marcaVeiculo
            // 
            this.marcaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaVeiculo.Location = new System.Drawing.Point(452, 266);
            this.marcaVeiculo.Multiline = true;
            this.marcaVeiculo.Name = "marcaVeiculo";
            this.marcaVeiculo.Size = new System.Drawing.Size(158, 29);
            this.marcaVeiculo.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 77;
            this.label11.Text = "Marca:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolPaths.Properties.Resources.Bus;
            this.pictureBox1.Location = new System.Drawing.Point(584, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 132);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(838, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.marcaVeiculo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.capacidadeVeiculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combustivelVeiculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.potenciaVeiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.corVeiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.renavamVeiculo);
            this.Controls.Add(this.chassiVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.anoFabricVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placaVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modeloVeiculo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "veiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox modeloVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox placaVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker anoFabricVeiculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox renavamVeiculo;
        private System.Windows.Forms.TextBox chassiVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox corVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox potenciaVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox combustivelVeiculo;
        private System.Windows.Forms.TextBox capacidadeVeiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox marcaVeiculo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}