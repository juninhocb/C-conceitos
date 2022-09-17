using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEnviarP_Click(object sender, EventArgs e)
        {   

            DateTime date = new DateTime();
            Pessoa pessoa = new Pessoa();
            pessoa.Idade = 0; 
            pessoa.Nome = tbNameP.Text;
            pessoa.SobreNome = tbSnameP.Text;
            pessoa.Idade = int.Parse(tbAgeP.Text);
            pessoa.Endereco = tbAdressP.Text;
            pessoa.DataNascimento = date.Date;
            MessageBox.Show($"Informações: {pessoa.ApresentarNomeCustom()} {pessoa.ApresentarIdadeEndereco()} ás {date.Hour} Horas.");



        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista(
                int.Parse(tbIdR.Text),
                tbNameR.Text,
                tbSnameR.Text
                );
            MessageBox.Show(recepcionista.AgendarConsulta());
        }

        private void btnDismissD_Click(object sender, EventArgs e)
        {
            Diretor diretor = new Diretor(
                tbNameD.Text,
                tbSnameD.Text,
                double.Parse(tbProLaboreD.Text)
                );

            DialogResult result = MessageBox.Show(
                diretor.InfoDiretor(),
                "Tomada de decisão",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
                );

            if (result == DialogResult.OK)
            {
                tbNameR.Text = "";
                tbSnameR.Text = "";
                tbIdR.Text = ""; 
                MessageBox.Show("Ok, demitida!");
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Ação cancelada");
            }

        }
    }
}
