namespace WindowsFormsApp_8
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviarP = new System.Windows.Forms.Button();
            this.tbNameP = new System.Windows.Forms.TextBox();
            this.tbSnameP = new System.Windows.Forms.TextBox();
            this.tbAgeP = new System.Windows.Forms.TextBox();
            this.tbDateP = new System.Windows.Forms.TextBox();
            this.tbAdressP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSnameR = new System.Windows.Forms.TextBox();
            this.tbNameR = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIdR = new System.Windows.Forms.TextBox();
            this.tbProLaboreD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSnameD = new System.Windows.Forms.TextBox();
            this.tbNameD = new System.Windows.Forms.TextBox();
            this.btnDismissD = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereco";
            // 
            // btnEnviarP
            // 
            this.btnEnviarP.Location = new System.Drawing.Point(203, 243);
            this.btnEnviarP.Name = "btnEnviarP";
            this.btnEnviarP.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarP.TabIndex = 5;
            this.btnEnviarP.Text = "Enviar";
            this.btnEnviarP.UseVisualStyleBackColor = true;
            this.btnEnviarP.Click += new System.EventHandler(this.btnEnviarP_Click);
            // 
            // tbNameP
            // 
            this.tbNameP.Location = new System.Drawing.Point(184, 70);
            this.tbNameP.Name = "tbNameP";
            this.tbNameP.Size = new System.Drawing.Size(128, 22);
            this.tbNameP.TabIndex = 6;
            // 
            // tbSnameP
            // 
            this.tbSnameP.Location = new System.Drawing.Point(184, 103);
            this.tbSnameP.Name = "tbSnameP";
            this.tbSnameP.Size = new System.Drawing.Size(128, 22);
            this.tbSnameP.TabIndex = 7;
            // 
            // tbAgeP
            // 
            this.tbAgeP.Location = new System.Drawing.Point(184, 138);
            this.tbAgeP.Name = "tbAgeP";
            this.tbAgeP.Size = new System.Drawing.Size(128, 22);
            this.tbAgeP.TabIndex = 8;
            // 
            // tbDateP
            // 
            this.tbDateP.Location = new System.Drawing.Point(184, 169);
            this.tbDateP.Name = "tbDateP";
            this.tbDateP.ReadOnly = true;
            this.tbDateP.Size = new System.Drawing.Size(128, 22);
            this.tbDateP.TabIndex = 9;
            // 
            // tbAdressP
            // 
            this.tbAdressP.Location = new System.Drawing.Point(184, 204);
            this.tbAdressP.Name = "tbAdressP";
            this.tbAdressP.Size = new System.Drawing.Size(128, 22);
            this.tbAdressP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pessoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 38);
            this.label7.TabIndex = 23;
            this.label7.Text = "Recepcionista";
            // 
            // tbSnameR
            // 
            this.tbSnameR.Location = new System.Drawing.Point(516, 139);
            this.tbSnameR.Name = "tbSnameR";
            this.tbSnameR.Size = new System.Drawing.Size(128, 22);
            this.tbSnameR.TabIndex = 19;
            // 
            // tbNameR
            // 
            this.tbNameR.Location = new System.Drawing.Point(516, 106);
            this.tbNameR.Name = "tbNameR";
            this.tbNameR.Size = new System.Drawing.Size(128, 22);
            this.tbNameR.TabIndex = 18;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(521, 167);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(123, 23);
            this.btnQuery.TabIndex = 17;
            this.btnQuery.Text = "Agendar Consulta";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sobrenome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // tbIdR
            // 
            this.tbIdR.Location = new System.Drawing.Point(516, 75);
            this.tbIdR.Name = "tbIdR";
            this.tbIdR.Size = new System.Drawing.Size(128, 22);
            this.tbIdR.TabIndex = 25;
            // 
            // tbProLaboreD
            // 
            this.tbProLaboreD.Location = new System.Drawing.Point(516, 280);
            this.tbProLaboreD.Name = "tbProLaboreD";
            this.tbProLaboreD.Size = new System.Drawing.Size(128, 22);
            this.tbProLaboreD.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "ProLabore";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(478, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 38);
            this.label10.TabIndex = 31;
            this.label10.Text = "Diretor";
            // 
            // tbSnameD
            // 
            this.tbSnameD.Location = new System.Drawing.Point(516, 344);
            this.tbSnameD.Name = "tbSnameD";
            this.tbSnameD.Size = new System.Drawing.Size(128, 22);
            this.tbSnameD.TabIndex = 30;
            // 
            // tbNameD
            // 
            this.tbNameD.Location = new System.Drawing.Point(516, 311);
            this.tbNameD.Name = "tbNameD";
            this.tbNameD.Size = new System.Drawing.Size(128, 22);
            this.tbNameD.TabIndex = 29;
            // 
            // btnDismissD
            // 
            this.btnDismissD.Location = new System.Drawing.Point(521, 372);
            this.btnDismissD.Name = "btnDismissD";
            this.btnDismissD.Size = new System.Drawing.Size(123, 23);
            this.btnDismissD.TabIndex = 28;
            this.btnDismissD.Text = "Demitir";
            this.btnDismissD.UseVisualStyleBackColor = true;
            this.btnDismissD.Click += new System.EventHandler(this.btnDismissD_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Sobrenome";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(410, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbProLaboreD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSnameD);
            this.Controls.Add(this.tbNameD);
            this.Controls.Add(this.btnDismissD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbIdR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSnameR);
            this.Controls.Add(this.tbNameR);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAdressP);
            this.Controls.Add(this.tbDateP);
            this.Controls.Add(this.tbAgeP);
            this.Controls.Add(this.tbSnameP);
            this.Controls.Add(this.tbNameP);
            this.Controls.Add(this.btnEnviarP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviarP;
        private System.Windows.Forms.TextBox tbNameP;
        private System.Windows.Forms.TextBox tbSnameP;
        private System.Windows.Forms.TextBox tbAgeP;
        private System.Windows.Forms.TextBox tbDateP;
        private System.Windows.Forms.TextBox tbAdressP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSnameR;
        private System.Windows.Forms.TextBox tbNameR;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIdR;
        private System.Windows.Forms.TextBox tbProLaboreD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSnameD;
        private System.Windows.Forms.TextBox tbNameD;
        private System.Windows.Forms.Button btnDismissD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

