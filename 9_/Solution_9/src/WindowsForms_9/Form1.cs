using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDisplay.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Contato ctt = new Contato();
            if (ValidaForm())
            {
                ctt.Nome = tbName.Text;
                ctt.Email = tbEmail.Text;
                ctt.Telefone = tbPhone.Text;
                ctt.CEP = tbCep.Text;
                ctt.Rua = "API RUA";
                ctt.Bairro = "API BAIRRO";
                ctt.Cidade = "API CIDADE";
                ctt.Estado = "API ESTADO";

                //preencherTbs();
                tbRua.Text = ctt.Rua;
                tbBairro.Text = ctt.Bairro;
                tbCity.Text = ctt.Cidade;
                tbState.Text = ctt.Estado;
                tbDisplay.Text = "\r\n Dados usuário!!!";
                MessageBox.Show("Inserindo dados nos campos!");
            }
            else
            {
                MessageBox.Show("Há dados faltando no formulário");
                apagarTbs();
            }

        }


        private void btnErase_Click(object sender, EventArgs e)
        {
            apagarTbs();
        }

        #region Metodos

        private void apagarTbs()
        {
            tbName.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbCep.Clear();
            tbRua.Clear();
            tbBairro.Clear();
            tbCity.Clear();
            tbState.Clear();
            tbDisplay.Text = "";
        }



        private void preencherTbs()
        {
        }

        public bool ValidaForm()
        {
            bool isValid = true;
            isValid = tbName.Text.Equals("") ? false : true;
            isValid = tbEmail.Text.Equals("") ? false : true;
            isValid = tbPhone.Text.Equals("") ? false : true;
            isValid = tbCep.Text.Equals("") ? false : true;

            return isValid;




            #endregion

        }

        private void tbCep_TextChanged(object sender, EventArgs e)
        {
            if (tbCep.Text.Length == 8)
            {
                tbRua.Text = "Minha Rua";
                tbBairro.Text = "Meu Bairro";
                tbCity.Text = "Minha Cidade";
                tbState.Text = "Meu Estado";
            } else
            {

            }
        }
    }
}
