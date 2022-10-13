//using BibliotecaClasses_Model.DataBase;
using BibliotecaClasses_Model.DataBase;
using ClassLibrary_Model.Classes;
using ClassLibrary_Model.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Main.DataBase;

#region Duvidas
/*
 nomenclatura de funções/metodos 'Comentários abaixo'
 (Metodos de Classe Modelo com a primeira em Maisuculo (Ok), porém as funções dentro de uma classe que não é inicializada (cria um obj) como a form, é maiuscula? em C não é assim)
*/
//existencias dos metodos set/get na classe porém o acesso aos atributos requer um encapsulamento de acesso público, poderia ser suprmido pela variável pública acessada por qlq objeto 
// verificar se há uma melhor implementação da interface, ou um cast, polimorfismo sem precisar criar variável
// passos para uma implementação com passagem de objetos entre compromissos com contato (uso de fk em compromissos)
#endregion

//TODO implementar com interface a classe ContatoRepositorio
//TODO Excluir compromisso

namespace WindowsFormsApp_Main
{
    public partial class Form1 : Form
    {

        ContatoRepositorio contatoRepositorio = new ContatoRepositorio();
        CompromissoRepositorio compromissoRepositorio = new CompromissoRepositorio();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarCombosContato();
            CarregarCombosCompromisso();


        }




        #region Funções
        public void CarregarCombosCompromissoId(int id_contato)
        {
            cbComprConsulta.Items.Clear();
            MySqlConnection conn2 = ConnectionMySql.GetConnection();
            MySqlDataReader dadosCompromissos; 
            dadosCompromissos = compromissoRepositorio.GetCompromissos(conn2);
            while (dadosCompromissos.Read())
            {
                if (Int32.Parse(dadosCompromissos.GetString(6)) == id_contato)
                {
                    cbComprConsulta.Items.Add(dadosCompromissos.GetString(1));
                }
            }

            conn2.Close();

        }
        //TODO tirar essa função e fazer tudo em uma só
        public void CarregarCombosCompromissoId2(int id_contato)
        {

            cbCompromissoExc.Items.Clear();
            MySqlConnection conn2 = ConnectionMySql.GetConnection();
            MySqlDataReader dadosCompromissos;
            dadosCompromissos = compromissoRepositorio.GetCompromissos(conn2);
            while (dadosCompromissos.Read())
            {
                if (Int32.Parse(dadosCompromissos.GetString(6)) == id_contato)
                {
                    cbCompromissoExc.Items.Add(dadosCompromissos.GetString(1));
                }
            }

            conn2.Close();

        }
        public void CarregarCombosCompromisso()
        {
            MySqlConnection conn = ConnectionMySql.GetConnection();
            MySqlDataReader dadosCompromissos;
            dadosCompromissos = compromissoRepositorio.GetCompromissos(conn);

            while (dadosCompromissos.Read())
            {
                cbComprCompr.Items.Add(dadosCompromissos.GetString(1));
                //cbComprConsulta.Items.Add(dadosCompromissos.GetString(1));
            }

            cbEstadoCompr.Items.Add("Inativo");
            cbEstadoCompr.Items.Add("Aberto");
            cbEstadoCompr.Items.Add("Concluído");
            cbEstadoCompr.Items.Add("Reagendado");

            conn.Close();
        }

        public void CarregarCombosContato()
        {
            MySqlConnection conn = ConnectionMySql.GetConnection();
            MySqlDataReader dadosContato;
            dadosContato = contatoRepositorio.GetContatos(conn);

            while (dadosContato.Read())
            {
                cbContatoCompr.Items.Add(dadosContato.GetString(1));
                cbContatoACtt.Items.Add(dadosContato.GetString(1));
                cbContatoConsulta.Items.Add(dadosContato.GetString(1));
                cbContatoExc.Items.Add(dadosContato.GetString(1));
            }


            conn.Close();

        }

        public int GetId(int n)
        {
            //TODO mudar para switch-case   
            MySqlConnection conn = ConnectionMySql.GetConnection();
            MySqlDataReader dados;
            if (n == 0 || n == 1 || n == 3 || n == 6)
            {
                dados = contatoRepositorio.GetContatos(conn);
            } else
            {
                dados = compromissoRepositorio.GetCompromissos(conn);
            }


            if (n == 0)
            {
                while (dados.Read())
                {
                    if (cbContatoCompr.Text.Equals(dados.GetString(1)))
                    {

                        return Int32.Parse(dados.GetString(0));
                    }
                }
            }
            else if (n == 1)
            {
                while (dados.Read())
                {
                    if (cbContatoACtt.Text.Equals(dados.GetString(1)))
                    {
                        return Int32.Parse(dados.GetString(0));
                    }
                }
            } else if (n == 2)
            {
                while (dados.Read())
                {
                    if (cbComprCompr.Text.Equals(dados.GetString(1)))
                    {
                        return Int32.Parse(dados.GetString(0));
                    }
                }
            } else if (n == 3)
            {
                while (dados.Read())
                {
                    if (cbContatoConsulta.Text.Equals(dados.GetString(1)))
                    {
                        return Int32.Parse(dados.GetString(0));
                    }
                }
            } else if (n == 4)
            {
                while (dados.Read())
                {
                    if (cbComprConsulta.Text.Equals(dados.GetString(1)))
                    {
                        return Int32.Parse(dados.GetString(0));
                    }
                }
            } else if (n == 5)
            {
                while (dados.Read())
                {   
                    if (cbCompromissoExc.Text.Equals(dados.GetString(1)))
                    {

                        return Int32.Parse(dados.GetString(0));
                    }
                }
            } else if (n == 6)
            {
                while (dados.Read())
                {
                    if (cbContatoExc.Text.Equals(dados.GetString(1)))
                    {

                        return Int32.Parse(dados.GetString(0));
                    }
                }
            }

            conn.Close();
            return 0;
        }
        public void BuscaPreencheCep()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mtbCep.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
                return; 
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    mtbCep.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                tbRua.Text = valor[1];
                            }

                            //Complemento
                            /*
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtComplemento.Text = valor[1];
                            }
                            */
                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                tbBairro.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                tbCidade.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                tbEstado.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }
        }
        public bool ValidarCamposContato()
        {
            if (
                tbNome.Text.Equals("") || tbNome.Text == null ||
                tbCelular.Text.Equals("") || tbCelular.Text == null ||
                tbEmail.Text.Equals("") || tbEmail.Text == null ||
                tbRua.Text.Equals("") || tbRua.Text == null ||
                tbNmr.Text.Equals("") || tbNmr.Text == null
            ) { return false; }
            else { return true; }
        }

        public bool ValidarCamposCompromisso()
        {

            //TODO: Fazer para os meses
            if (Int32.Parse(mtbDataInicial.Text.Substring(0,2)) > 31)
            {
                MessageBox.Show("Dias devem ser menores que 31"); 
                return false; 
            }
            if (Int32.Parse(mtbDataFinal.Text.Substring(0, 2)) > 31)
            {
                MessageBox.Show("Dias devem ser menores que 31");
                return false;
            }

            if (
                tbTitulo.Text.Equals("") || tbTitulo.Text == null ||
                tbDescricao.Text.Equals("") || tbDescricao.Text == null ||
                mtbDataInicial.Text.Equals("") || mtbDataInicial.Text == null ||
                mtbDataFinal.Text.Equals("") || mtbDataFinal.Text == null ||
                cbContatoCompr.Text.Equals("") || cbContatoCompr.Text == null
            ) { return false; }
            else { return true; }
        }

        #endregion


        #region Eventos
        private void btAddCtt_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = ConnectionMySql.GetConnection();
            if (ValidarCamposContato())
            {

                Contato ctt = new Contato(
                    tbNome.Text,
                    tbCelular.Text,
                    tbEmail.Text,
                    tbRua.Text,
                    int.Parse(tbNmr.Text),
                    tbBairro.Text,
                    tbCidade.Text,
                    tbEstado.Text.Substring(1, 2)
                    );

                try
                {
                    Contato contato = contatoRepositorio.SaveContato(ctt, conn);
                    MessageBox.Show($"{contato.Nome} Salvo com sucesso!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro " + exception.StackTrace);
                }


            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos \"Adicionar Contato\"");
            }


            tbNome.Text = "";
            tbCelular.Text = "";
            tbEmail.Text = "";
            tbRua.Text = "";
            tbNmr.Text = "";
            tbBairro.Text = "";
            tbCidade.Text = "";
            tbEstado.Text = "";
            mtbCep.Text = "_____-___";

            conn.Close();
            Application.Restart();
        }
        private void mtbCep_TextChanged(object sender, EventArgs e)
        {
            if (
                mtbCep.TextLength == 9 &&
                Regex.IsMatch(mtbCep.Text.Replace("-", ""), "^[0-9]{8}$") &&
                mtbCep.Text[5].Equals('-')
                )
            {
                BuscaPreencheCep();
            }
        }

        private void btAddCompr_Click(object sender, EventArgs e)
        {
            
            if (ValidarCamposCompromisso())
            {
               
                MySqlConnection conn2 = ConnectionMySql.GetConnection();
                Compromisso compr = new Compromisso(
                    tbTitulo.Text,
                    tbDescricao.Text,
                    DateTime.Parse(mtbDataInicial.Text),
                    DateTime.Parse(mtbDataFinal.Text)
                    );

                compr.Id_contato = GetId(0);
                compr.Estado = EStatus.A;
                Object obj = compromissoRepositorio.Save(compr, conn2);
                Compromisso ok = (Compromisso)obj;
                MessageBox.Show($"Compromisso {ok.Titulo} agendado com sucesso!");
                conn2.Close();

            } else
            {
                MessageBox.Show("Favor, preencher todos os campos \"Adicionar Compromisso\" ");
            }

            tbTitulo.Text = "";
            tbDescricao.Text = "";
            mtbDataInicial.Text = "__/__/____";
            mtbDataFinal.Text = "__/__/____";

            Application.Restart();
        }

        private void mtbDataInicial_TextChanged(object sender, EventArgs e)
        {

            //FIXME: se o usuário começar pelo ultimo algarísmo o foco muda, substituir essa forma de implementação
            bool bandeiraFocar = false;
            char soParaAtribuir = 'a';
            try {
                soParaAtribuir = mtbDataInicial.Text[9];
                bandeiraFocar = true; 
            } catch{}
            
            if (mtbDataInicial.TextLength == 10 && bandeiraFocar)
            {
                mtbDataFinal.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btAltCtt;
            btAltCtt = new System.Windows.Forms.Button();
            

            if (cbContatoACtt != null && !cbContatoACtt.Text.Equals(""))
            {
                btAddCtt.Visible = false;
                btAddCtt.Enabled = false;

                panel1.Controls.Add(btAltCtt);
                btAltCtt.Location = new System.Drawing.Point(90, 180);
                btAltCtt.Name = "btAltCtt";
                btAltCtt.Size = new System.Drawing.Size(89, 30);
                btAltCtt.TabIndex = 19;
                btAltCtt.Text = "Alterar";
                btAltCtt.UseVisualStyleBackColor = true;
                btAltCtt.Click += new System.EventHandler(this.btAltCtt_Click);
                lbContato.Text = "Alterar Contato";


                lbContato.Location = new System.Drawing.Point(44, 15);
                MySqlConnection conn2 = ConnectionMySql.GetConnection();
                int id = GetId(1);
                MySqlDataReader contato = contatoRepositorio.GetContato(id, conn2);
                while (contato.Read())
                {
                    tbNome.Text = contato.GetString(1);
                    tbCelular.Text = contato.GetString(3);
                    tbEstado.Text = contato.GetString(9);
                    tbBairro.Text = contato.GetString(7);
                    tbCidade.Text = contato.GetString(8);
                    tbNmr.Text = contato.GetString(6);
                    tbRua.Text = contato.GetString(5);
                    tbEmail.Text = contato.GetString(4);
                }

                conn2.Close();
            }
            else {

                MessageBox.Show("Favor, selecionar um contato para alterar!");
            }


                        
            


        }

        private void btAltCtt_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionMySql.GetConnection();
            int id = GetId(1);
            if (ValidarCamposContato())
            {

                Contato ctt = new Contato(
                    tbNome.Text,
                    tbCelular.Text,
                    tbEmail.Text,
                    tbRua.Text,
                    int.Parse(tbNmr.Text),
                    tbBairro.Text,
                    tbCidade.Text,
                    tbEstado.Text.Substring(0, 1)
                    );

                try
                {


                    contatoRepositorio.UpdateContato(id, ctt, conn);
                    MessageBox.Show($"{ctt.Nome} alterado com sucesso!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro " + exception.StackTrace);
                }


            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos \"Adicionar Contato\"");
            }


            tbNome.Text = "";
            tbCelular.Text = "";
            tbEmail.Text = "";
            tbRua.Text = "";
            tbNmr.Text = "";
            tbBairro.Text = "";
            tbCidade.Text = "";
            tbEstado.Text = "";
            mtbCep.Text = "_____-___";

            conn.Close();
            Application.Restart();

        }

        private void btAlterarCompr_Click(object sender, EventArgs e)
        {
            if (cbComprCompr.Text.Equals("") || cbEstadoCompr.Text.Equals("")) {


                MessageBox.Show("Selecione as duas opções para alterar o estado!");
            
            } else
            {
                MySqlConnection conn2 = ConnectionMySql.GetConnection();
                string valueSelectedString = cbEstadoCompr.Text;
                char valueSelected = 'Z';
                int id = GetId(2);

                switch (valueSelectedString)
                {
                    case "Inativo":
                        valueSelected = 'I';
                        break;
                    case "Aberto":
                        valueSelected = 'A';
                        break;
                    case "Concluído":
                        valueSelected = 'C';
                        break;
                    case "Reagendado":
                        valueSelected = 'R';
                        break;
                    default:
                        break;
                }

                compromissoRepositorio.SetUpdateStatus(
                    valueSelected,
                    id,
                    conn2
                    );


                conn2.Close();


            }
            
        }

        private void cbContatoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GetId(3);
            cbComprConsulta.Enabled = true;
            CarregarCombosCompromissoId(id);


        }

        private void btBuscarConsulta_Click(object sender, EventArgs e)
        {
            dgDadosContato.DataSource = null;
            lbDadosContato.Text = "";
            MySqlConnection conn2 = ConnectionMySql.GetConnection();
            int idContato = GetId(3);

            MySqlDataReader contatoSelecionado = contatoRepositorio.GetContato(idContato, conn2);
            dgDadosContato.DataSource = new BindingSource(contatoSelecionado, null);
            dgDadosContato.Rows[0].DefaultCellStyle.BackColor = Color.Red;


            conn2.Close();
            
            if (cbComprConsulta.Text.Equals(""))
            {
                dgDadosCompr.Rows.Clear();
                dgDadosCompr.Columns.Clear();
                lbDadosCompromisso.Text = "Contato sem compromisso ou não selecionado!";
            } else
            {
                lbDadosCompromisso.Text= "";
                MySqlConnection conn3 = ConnectionMySql.GetConnection();
                int idCompr = GetId(4);
                MySqlDataReader compromissoSelecionado = compromissoRepositorio.GetCompromisso(idCompr, conn3);
                dgDadosCompr.DataSource = new BindingSource(compromissoSelecionado, null);
                dgDadosCompr.Rows[0].DefaultCellStyle.BackColor = Color.Tan;
                conn3.Close();
            }


        }

        private void cbContatoExc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GetId(6);
            cbCompromissoExc.Enabled = true;
            CarregarCombosCompromissoId2(id);
        }

        private void btExcluirCtt_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn2 = ConnectionMySql.GetConnection();
            int idContato = GetId(6);

            //MySqlDataReader contatoSelecionado = contatoRepositorio.GetContato(idContato, conn2);
            contatoRepositorio.DeleteContato(idContato, conn2);
            conn2.Close();

            if (cbCompromissoExc.Text.Equals(""))
            {
                MessageBox.Show("Nenhum compromisso selecionado para exclusão");
            }
            else
            {

                MySqlConnection conn3 = ConnectionMySql.GetConnection();
                int idCompr = GetId(5);
                MySqlDataReader compromissoSelecionado = compromissoRepositorio.GetCompromisso(idCompr, conn3);
                compromissoRepositorio.DeleteCompromisso(idCompr, conn3);
                conn3.Close();
                
            }

            Application.Restart();
        }
    }

    #endregion
}
