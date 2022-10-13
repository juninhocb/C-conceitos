namespace WindowsFormsApp_Main
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
            this.lbContato = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btAddCompr = new System.Windows.Forms.Button();
            this.cbContatoCompr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.dgDadosContato = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cbContatoACtt = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNmr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btAddCtt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lbDadosContato = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btAlterarCompr = new System.Windows.Forms.Button();
            this.cbEstadoCompr = new System.Windows.Forms.ComboBox();
            this.cbComprCompr = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btBuscarConsulta = new System.Windows.Forms.Button();
            this.cbComprConsulta = new System.Windows.Forms.ComboBox();
            this.cbContatoConsulta = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btExcluirCtt = new System.Windows.Forms.Button();
            this.cbContatoExc = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dgDadosCompr = new System.Windows.Forms.DataGridView();
            this.lbDadosCompromisso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompromissoExc = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosContato)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosCompr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContato.ForeColor = System.Drawing.Color.White;
            this.lbContato.Location = new System.Drawing.Point(44, 23);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(258, 32);
            this.lbContato.TabIndex = 1;
            this.lbContato.Text = "Adicionar Contato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(373, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(336, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Adicionar Compromisso";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mtbDataFinal);
            this.panel2.Controls.Add(this.mtbDataInicial);
            this.panel2.Controls.Add(this.btAddCompr);
            this.panel2.Controls.Add(this.cbContatoCompr);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.tbDescricao);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbTitulo);
            this.panel2.Location = new System.Drawing.Point(374, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 283);
            this.panel2.TabIndex = 2;
            // 
            // mtbDataFinal
            // 
            this.mtbDataFinal.Location = new System.Drawing.Point(243, 113);
            this.mtbDataFinal.Mask = "00/00/0000";
            this.mtbDataFinal.Name = "mtbDataFinal";
            this.mtbDataFinal.Size = new System.Drawing.Size(82, 22);
            this.mtbDataFinal.TabIndex = 22;
            // 
            // mtbDataInicial
            // 
            this.mtbDataInicial.Location = new System.Drawing.Point(82, 114);
            this.mtbDataInicial.Mask = "00/00/0000";
            this.mtbDataInicial.Name = "mtbDataInicial";
            this.mtbDataInicial.Size = new System.Drawing.Size(82, 22);
            this.mtbDataInicial.TabIndex = 21;
            this.mtbDataInicial.TextChanged += new System.EventHandler(this.mtbDataInicial_TextChanged);
            // 
            // btAddCompr
            // 
            this.btAddCompr.Location = new System.Drawing.Point(134, 220);
            this.btAddCompr.Name = "btAddCompr";
            this.btAddCompr.Size = new System.Drawing.Size(89, 34);
            this.btAddCompr.TabIndex = 20;
            this.btAddCompr.Text = "Adicionar";
            this.btAddCompr.UseVisualStyleBackColor = true;
            this.btAddCompr.Click += new System.EventHandler(this.btAddCompr_Click);
            // 
            // cbContatoCompr
            // 
            this.cbContatoCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoCompr.FormattingEnabled = true;
            this.cbContatoCompr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbContatoCompr.Location = new System.Drawing.Point(82, 155);
            this.cbContatoCompr.Name = "cbContatoCompr";
            this.cbContatoCompr.Size = new System.Drawing.Size(243, 24);
            this.cbContatoCompr.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(3, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Contato";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(169, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Data Final";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(3, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "Data Inicial";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(82, 43);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(243, 54);
            this.tbDescricao.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(3, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Descricao";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(3, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Titulo";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(82, 9);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(243, 22);
            this.tbTitulo.TabIndex = 2;
            // 
            // dgDadosContato
            // 
            this.dgDadosContato.BackgroundColor = System.Drawing.Color.Tomato;
            this.dgDadosContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadosContato.Location = new System.Drawing.Point(739, 23);
            this.dgDadosContato.Name = "dgDadosContato";
            this.dgDadosContato.RowHeadersWidth = 51;
            this.dgDadosContato.RowTemplate.Height = 24;
            this.dgDadosContato.Size = new System.Drawing.Size(1043, 332);
            this.dgDadosContato.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(78, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Alterar Contato";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.cbContatoACtt);
            this.panel4.Controls.Add(this.label46);
            this.panel4.Location = new System.Drawing.Point(12, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 136);
            this.panel4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbContatoACtt
            // 
            this.cbContatoACtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoACtt.FormattingEnabled = true;
            this.cbContatoACtt.Location = new System.Drawing.Point(70, 40);
            this.cbContatoACtt.Name = "cbContatoACtt";
            this.cbContatoACtt.Size = new System.Drawing.Size(229, 24);
            this.cbContatoACtt.TabIndex = 21;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label46.Location = new System.Drawing.Point(5, 46);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 16);
            this.label46.TabIndex = 2;
            this.label46.Text = "Contato";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(70, 9);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(255, 22);
            this.tbNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(165, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(214, 43);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(111, 22);
            this.tbCelular.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "CEP";
            // 
            // tbEstado
            // 
            this.tbEstado.Enabled = false;
            this.tbEstado.Location = new System.Drawing.Point(69, 78);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(89, 22);
            this.tbEstado.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Enabled = false;
            this.tbCidade.Location = new System.Drawing.Point(70, 113);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(89, 22);
            this.tbCidade.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(165, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bairro";
            // 
            // tbBairro
            // 
            this.tbBairro.Enabled = false;
            this.tbBairro.Location = new System.Drawing.Point(214, 78);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(111, 22);
            this.tbBairro.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(165, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nmr";
            // 
            // tbNmr
            // 
            this.tbNmr.Location = new System.Drawing.Point(214, 110);
            this.tbNmr.Name = "tbNmr";
            this.tbNmr.Size = new System.Drawing.Size(111, 22);
            this.tbNmr.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rua";
            // 
            // tbRua
            // 
            this.tbRua.Enabled = false;
            this.tbRua.Location = new System.Drawing.Point(70, 149);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(255, 22);
            this.tbRua.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(70, 178);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 22);
            this.tbEmail.TabIndex = 18;
            // 
            // btAddCtt
            // 
            this.btAddCtt.Location = new System.Drawing.Point(125, 220);
            this.btAddCtt.Name = "btAddCtt";
            this.btAddCtt.Size = new System.Drawing.Size(89, 34);
            this.btAddCtt.TabIndex = 19;
            this.btAddCtt.Text = "Adicionar";
            this.btAddCtt.UseVisualStyleBackColor = true;
            this.btAddCtt.Click += new System.EventHandler(this.btAddCtt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mtbCep);
            this.panel1.Controls.Add(this.btAddCtt);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbRua);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbNmr);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCelular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 283);
            this.panel1.TabIndex = 0;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(70, 43);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(89, 22);
            this.mtbCep.TabIndex = 20;
            this.mtbCep.TextChanged += new System.EventHandler(this.mtbCep_TextChanged);
            // 
            // lbDadosContato
            // 
            this.lbDadosContato.AutoSize = true;
            this.lbDadosContato.BackColor = System.Drawing.Color.Tomato;
            this.lbDadosContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDadosContato.ForeColor = System.Drawing.Color.White;
            this.lbDadosContato.Location = new System.Drawing.Point(746, 33);
            this.lbDadosContato.Name = "lbDadosContato";
            this.lbDadosContato.Size = new System.Drawing.Size(216, 32);
            this.lbDadosContato.TabIndex = 7;
            this.lbDadosContato.Text = "Dados Contato";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btAlterarCompr);
            this.panel3.Controls.Add(this.cbEstadoCompr);
            this.panel3.Controls.Add(this.cbComprCompr);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(374, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 136);
            this.panel3.TabIndex = 24;
            // 
            // btAlterarCompr
            // 
            this.btAlterarCompr.Location = new System.Drawing.Point(125, 86);
            this.btAlterarCompr.Name = "btAlterarCompr";
            this.btAlterarCompr.Size = new System.Drawing.Size(89, 34);
            this.btAlterarCompr.TabIndex = 20;
            this.btAlterarCompr.Text = "Alterar";
            this.btAlterarCompr.UseVisualStyleBackColor = true;
            this.btAlterarCompr.Click += new System.EventHandler(this.btAlterarCompr_Click);
            // 
            // cbEstadoCompr
            // 
            this.cbEstadoCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCompr.FormattingEnabled = true;
            this.cbEstadoCompr.Location = new System.Drawing.Point(96, 43);
            this.cbEstadoCompr.Name = "cbEstadoCompr";
            this.cbEstadoCompr.Size = new System.Drawing.Size(229, 24);
            this.cbEstadoCompr.TabIndex = 22;
            // 
            // cbComprCompr
            // 
            this.cbComprCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComprCompr.FormattingEnabled = true;
            this.cbComprCompr.Location = new System.Drawing.Point(96, 7);
            this.cbComprCompr.Name = "cbComprCompr";
            this.cbComprCompr.Size = new System.Drawing.Size(229, 24);
            this.cbComprCompr.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(3, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "Compromisso";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(3, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Estado";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(389, 344);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(302, 32);
            this.label22.TabIndex = 23;
            this.label22.Text = "Estado Compromisso";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btBuscarConsulta);
            this.panel5.Controls.Add(this.cbComprConsulta);
            this.panel5.Controls.Add(this.cbContatoConsulta);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Location = new System.Drawing.Point(12, 555);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 136);
            this.panel5.TabIndex = 24;
            // 
            // btBuscarConsulta
            // 
            this.btBuscarConsulta.Location = new System.Drawing.Point(125, 86);
            this.btBuscarConsulta.Name = "btBuscarConsulta";
            this.btBuscarConsulta.Size = new System.Drawing.Size(89, 34);
            this.btBuscarConsulta.TabIndex = 20;
            this.btBuscarConsulta.Text = "Consultar";
            this.btBuscarConsulta.UseVisualStyleBackColor = true;
            this.btBuscarConsulta.Click += new System.EventHandler(this.btBuscarConsulta_Click);
            // 
            // cbComprConsulta
            // 
            this.cbComprConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComprConsulta.Enabled = false;
            this.cbComprConsulta.FormattingEnabled = true;
            this.cbComprConsulta.Location = new System.Drawing.Point(96, 43);
            this.cbComprConsulta.Name = "cbComprConsulta";
            this.cbComprConsulta.Size = new System.Drawing.Size(229, 24);
            this.cbComprConsulta.TabIndex = 22;
            // 
            // cbContatoConsulta
            // 
            this.cbContatoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoConsulta.FormattingEnabled = true;
            this.cbContatoConsulta.Location = new System.Drawing.Point(96, 7);
            this.cbContatoConsulta.Name = "cbContatoConsulta";
            this.cbContatoConsulta.Size = new System.Drawing.Size(229, 24);
            this.cbContatoConsulta.TabIndex = 21;
            this.cbContatoConsulta.SelectedIndexChanged += new System.EventHandler(this.cbContatoConsulta_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(5, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 16);
            this.label23.TabIndex = 20;
            this.label23.Text = "Compromisso";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(19, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Contato";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(116, 520);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 32);
            this.label25.TabIndex = 23;
            this.label25.Text = "Consulta";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Tomato;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.cbCompromissoExc);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.btExcluirCtt);
            this.panel6.Controls.Add(this.cbContatoExc);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Location = new System.Drawing.Point(374, 555);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 136);
            this.panel6.TabIndex = 26;
            // 
            // btExcluirCtt
            // 
            this.btExcluirCtt.Location = new System.Drawing.Point(125, 86);
            this.btExcluirCtt.Name = "btExcluirCtt";
            this.btExcluirCtt.Size = new System.Drawing.Size(89, 34);
            this.btExcluirCtt.TabIndex = 20;
            this.btExcluirCtt.Text = "Exlcuir";
            this.btExcluirCtt.UseVisualStyleBackColor = true;
            this.btExcluirCtt.Click += new System.EventHandler(this.btExcluirCtt_Click);
            // 
            // cbContatoExc
            // 
            this.cbContatoExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoExc.FormattingEnabled = true;
            this.cbContatoExc.Location = new System.Drawing.Point(97, 7);
            this.cbContatoExc.Name = "cbContatoExc";
            this.cbContatoExc.Size = new System.Drawing.Size(228, 24);
            this.cbContatoExc.TabIndex = 21;
            this.cbContatoExc.SelectedIndexChanged += new System.EventHandler(this.cbContatoExc_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(3, 15);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 16);
            this.label26.TabIndex = 2;
            this.label26.Text = "Contato";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(483, 520);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 32);
            this.label27.TabIndex = 25;
            this.label27.Text = "Excluir";
            // 
            // dgDadosCompr
            // 
            this.dgDadosCompr.BackgroundColor = System.Drawing.Color.Tomato;
            this.dgDadosCompr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadosCompr.Location = new System.Drawing.Point(739, 370);
            this.dgDadosCompr.Name = "dgDadosCompr";
            this.dgDadosCompr.RowHeadersWidth = 51;
            this.dgDadosCompr.RowTemplate.Height = 24;
            this.dgDadosCompr.Size = new System.Drawing.Size(1043, 321);
            this.dgDadosCompr.TabIndex = 27;
            // 
            // lbDadosCompromisso
            // 
            this.lbDadosCompromisso.AutoSize = true;
            this.lbDadosCompromisso.BackColor = System.Drawing.Color.Tomato;
            this.lbDadosCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDadosCompromisso.ForeColor = System.Drawing.Color.White;
            this.lbDadosCompromisso.Location = new System.Drawing.Point(746, 383);
            this.lbDadosCompromisso.Name = "lbDadosCompromisso";
            this.lbDadosCompromisso.Size = new System.Drawing.Size(294, 32);
            this.lbDadosCompromisso.TabIndex = 28;
            this.lbDadosCompromisso.Text = "Dados Compromisso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Compromisso";
            // 
            // cbCompromissoExc
            // 
            this.cbCompromissoExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompromissoExc.Enabled = false;
            this.cbCompromissoExc.FormattingEnabled = true;
            this.cbCompromissoExc.Location = new System.Drawing.Point(97, 43);
            this.cbCompromissoExc.Name = "cbCompromissoExc";
            this.cbCompromissoExc.Size = new System.Drawing.Size(228, 24);
            this.cbCompromissoExc.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1794, 713);
            this.Controls.Add(this.lbDadosCompromisso);
            this.Controls.Add(this.dgDadosCompr);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbDadosContato);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgDadosContato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbContato);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosContato)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosCompr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbContato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAddCompr;
        private System.Windows.Forms.ComboBox cbContatoCompr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.DataGridView dgDadosContato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNmr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btAddCtt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbContatoACtt;
        private System.Windows.Forms.Label lbDadosContato;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btAlterarCompr;
        private System.Windows.Forms.ComboBox cbEstadoCompr;
        private System.Windows.Forms.ComboBox cbComprCompr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btBuscarConsulta;
        private System.Windows.Forms.ComboBox cbComprConsulta;
        private System.Windows.Forms.ComboBox cbContatoConsulta;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btExcluirCtt;
        private System.Windows.Forms.ComboBox cbContatoExc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbDataInicial;
        private System.Windows.Forms.MaskedTextBox mtbDataFinal;
        private System.Windows.Forms.DataGridView dgDadosCompr;
        private System.Windows.Forms.Label lbDadosCompromisso;
        private System.Windows.Forms.ComboBox cbCompromissoExc;
        private System.Windows.Forms.Label label1;
    }
}

