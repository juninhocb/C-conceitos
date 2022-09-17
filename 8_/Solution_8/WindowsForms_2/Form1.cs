using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_2
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }

        public List<Diretor> DirectoriesList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
           


            if (rbDiretor.Checked)
            {
                Diretor diretor = new Diretor(
               tbName.Text,
               tbSname.Text,
               1500
               );
                SalvarDiretor(diretor);
            } else
            {
                Recepcionista recepcionista = new Recepcionista(
                    5,
                    tbName.Text,
                    tbSname.Text
                    );
                SalvarRecepcionista(recepcionista);
            }


            showFuncs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DirectoriesList = new List<Diretor>();
        }


        #region Metodos


        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);

        }
        private void SalvarDiretor(Diretor diretor)
        {
            DirectoriesList.Add(diretor); 
        }

        private void LimparFormulario()
        {
            tbName.Text = "";
            tbAdress.Text = "";
            tbSname.Text = "";
            tbBorno.Text = "";
        }
        private void showFuncs()
        {
            tbViewFuncs.Text = "";
            if (RecepcionistasList.Count != 0)
            {
                tbViewFuncs.Text += "       Recepcionistas";
            }
            for (int i = 0; i < RecepcionistasList.Count; i++)
            {

                tbViewFuncs.Text += "\r\n" + RecepcionistasList[i].Nome;
            }
            if (DirectoriesList.Count != 0)
            {
                tbViewFuncs.Text +=  RecepcionistasList.Count != 0 ? "\r\n        Diretores" : "          Diretores";
                
            }
            for (int i = 0; i < DirectoriesList.Count; i++)
            {
                tbViewFuncs.Text += "\r\n"+DirectoriesList[i].Nome;
            }


        }

        private void EraseFormulario()
        {
            RecepcionistasList.Clear();
            DirectoriesList.Clear();
            showFuncs();
        }


        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            EraseFormulario();
        }
    }
}
