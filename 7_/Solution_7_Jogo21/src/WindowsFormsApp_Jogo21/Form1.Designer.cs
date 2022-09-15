namespace WindowsFormsApp_Jogo21
{
    partial class Jogo21
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo21));
            this.btnPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.tbPlayer1Info = new System.Windows.Forms.TextBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.tbPlayer2Info = new System.Windows.Forms.TextBox();
            this.btnComputador = new System.Windows.Forms.Button();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.tbScoreBoard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(103, 145);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(86, 39);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "JOGAR";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sua Pontuação:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "JOGO DO 21";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbPlayer1.Controls.Add(this.tbPlayer1Info);
            this.gbPlayer1.Controls.Add(this.btnPlayer1);
            this.gbPlayer1.Controls.Add(this.tbPlayer1);
            this.gbPlayer1.Location = new System.Drawing.Point(33, 220);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(200, 199);
            this.gbPlayer1.TabIndex = 4;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player1";
            // 
            // tbPlayer1Info
            // 
            this.tbPlayer1Info.Enabled = false;
            this.tbPlayer1Info.Location = new System.Drawing.Point(6, 20);
            this.tbPlayer1Info.Multiline = true;
            this.tbPlayer1Info.Name = "tbPlayer1Info";
            this.tbPlayer1Info.Size = new System.Drawing.Size(181, 135);
            this.tbPlayer1Info.TabIndex = 10;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(112, 161);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer1.TabIndex = 1;
            this.btnPlayer1.Text = "OK";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(6, 162);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(100, 22);
            this.tbPlayer1.TabIndex = 0;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbPlayer2.Controls.Add(this.tbPlayer2Info);
            this.gbPlayer2.Controls.Add(this.btnComputador);
            this.gbPlayer2.Controls.Add(this.tbPlayer2);
            this.gbPlayer2.Location = new System.Drawing.Point(569, 220);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(200, 199);
            this.gbPlayer2.TabIndex = 5;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player2 (PC)";
            // 
            // tbPlayer2Info
            // 
            this.tbPlayer2Info.Enabled = false;
            this.tbPlayer2Info.Location = new System.Drawing.Point(6, 20);
            this.tbPlayer2Info.Multiline = true;
            this.tbPlayer2Info.Name = "tbPlayer2Info";
            this.tbPlayer2Info.Size = new System.Drawing.Size(181, 135);
            this.tbPlayer2Info.TabIndex = 11;
            // 
            // btnComputador
            // 
            this.btnComputador.Enabled = false;
            this.btnComputador.Location = new System.Drawing.Point(112, 162);
            this.btnComputador.Name = "btnComputador";
            this.btnComputador.Size = new System.Drawing.Size(75, 23);
            this.btnComputador.TabIndex = 3;
            this.btnComputador.Text = "OK";
            this.btnComputador.UseVisualStyleBackColor = true;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Enabled = false;
            this.tbPlayer2.Location = new System.Drawing.Point(6, 162);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.ReadOnly = true;
            this.tbPlayer2.Size = new System.Drawing.Size(100, 22);
            this.tbPlayer2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_Jogo21.Properties.Resources.idade_para_jogos_de_azar__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gbResultados
            // 
            this.gbResultados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbResultados.Controls.Add(this.cb3);
            this.gbResultados.Controls.Add(this.cb2);
            this.gbResultados.Controls.Add(this.cb1);
            this.gbResultados.Controls.Add(this.tbScoreBoard);
            this.gbResultados.Controls.Add(this.btnPlay);
            this.gbResultados.Location = new System.Drawing.Point(252, 220);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(298, 199);
            this.gbResultados.TabIndex = 6;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultado";
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Enabled = false;
            this.cb3.Location = new System.Drawing.Point(6, 110);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(89, 20);
            this.cb3.TabIndex = 5;
            this.cb3.Text = "Rodada 3";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Enabled = false;
            this.cb2.Location = new System.Drawing.Point(6, 84);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(89, 20);
            this.cb2.TabIndex = 4;
            this.cb2.Text = "Rodada 2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Enabled = false;
            this.cb1.Location = new System.Drawing.Point(6, 58);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(89, 20);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "Rodada 1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // tbScoreBoard
            // 
            this.tbScoreBoard.Location = new System.Drawing.Point(6, 30);
            this.tbScoreBoard.Name = "tbScoreBoard";
            this.tbScoreBoard.Size = new System.Drawing.Size(279, 22);
            this.tbScoreBoard.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pontuação (PC):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Jogo21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jogo21";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnComputador;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.TextBox tbScoreBoard;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlayer1Info;
        private System.Windows.Forms.TextBox tbPlayer2Info;
    }
}

