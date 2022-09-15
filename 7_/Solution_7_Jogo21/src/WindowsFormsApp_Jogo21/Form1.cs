using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp_Jogo21
{
    public partial class Jogo21 : Form
    {   

        public int contador = 0;
        public int nmrVitoriasPC = 0;
        public int nmrVitoriasUser = 0;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        private static void TimerEventProcessor(Object myObject,
                                          EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Displays a message box asking whether to continue running the timer.
            if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter.
                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }
        }


        public Jogo21()
        {
            InitializeComponent();
        }

        public void startGame()
        {
            tbScoreBoard.Text = "Bem vindo ao Jogo 21, Pressione Jogar.";
            backendStart();
        }
        public void backendStart()
        {
            tbPlayer1.Enabled = false;
            btnPlayer1.Enabled = false;
        }

        public void backendFinish()
        {
            tbPlayer1.Enabled = true;
            btnPlayer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
            tbScoreBoard.Enabled = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            backendFinish();
            tbPlayer1Info.Text = "RODADA 1 - Informe sua aposta e pressione OK!";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //myTimer.Tick += new EventHandler();
            startPlayGround();

        }

        public void nextRound()
        {
            backendFinish();
            

        }
        public void startPlayGround()
        {
            contador++;
            bool isValid = int.TryParse(tbPlayer1.Text, out int numberP1);
            //TODO validação
            backendStart();
            tbScoreBoard.Text = "Aguarda o processamento do resultado!";
            //Thread.Sleep(2000);
            myTimer.Interval = 2000;
            myTimer.Start();
            tratador(numberP1, contador);
        }
        public void tratador(int numberP1, int i)
        {
            
            Random random = new Random();
            int pcNumber = random.Next(1,21);
            //Thread.Sleep(500);
            tbPlayer2Info.Text = $"Número escolhio pelo PC: {pcNumber}";
            //Thread.Sleep(500);
            int randomNumber = random.Next(1,21);
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 2000;
            myTimer.Start();
            tbScoreBoard.Text = $"Número escolhido Aleatóriamente {randomNumber}";
            int somaP1 = randomNumber + numberP1;
            int somaPC = randomNumber + pcNumber;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 2000;
            myTimer.Start();
            tbPlayer2Info.Text += $"\r\nSoma do PC {somaPC}";
            tbPlayer1Info.Text = $"\nSoma do Player 1 {somaP1}";
            
            tbScoreBoard.Text = "Aguarde o calculo do resultado";
            //Thread.Sleep(5000);
            int resultPc = calculoPontos(somaPC);
            int resultP1 = calculoPontos(somaP1);
            //Thread.Sleep(2000);
            if (resultPc > resultP1)
            {
                tbScoreBoard.Text = $"PC Venceu rodada - {i}";
                nmrVitoriasPC++;
            } else if (resultPc == resultP1)
            {
                tbScoreBoard.Text = $"Houve um empate rodada {i}";
            } else
            {
                nmrVitoriasUser++;
                tbScoreBoard.Text = $"Player 1 Venceu rodada {i}";
            }
            myTimer.Stop();
            callCheck();


        }

        public void callCheck()
        {
            switch (contador)
            {
                case 1:
                    cb1.Checked = true;
                    nextRound();
                    tbScoreBoard.Text = "Informe o valor para segunda rodada!";
                    break;
                case 2:
                    cb2.Checked = true;
                    nextRound();
                    tbScoreBoard.Text = "Informe o valor para terceira rodada!";
                    break;
                case 3:
                    cb3.Checked = true;
                    finishGame();
                    break;
                default:
                    break;
            }
        }

        public void finishGame()
        {
            if (nmrVitoriasPC > nmrVitoriasUser)
            {
                tbScoreBoard.Text = $"PC venceu por  (PC){nmrVitoriasPC} x {nmrVitoriasUser}(P1)";
            } else if (nmrVitoriasPC == nmrVitoriasUser)
            {
                tbScoreBoard.Text = $"Houve um empate (PC){nmrVitoriasPC} x {nmrVitoriasUser}(P1)";
            } else
            {
                tbScoreBoard.Text = $"Usuário Venceu (PC){nmrVitoriasPC} x {nmrVitoriasUser}(P1)";
            }
            backendStart();
        }
        public int calculoPontos(int soma)
        {
            int point = 0;
            switch (soma)
            {
                case int n when n <= 6:
                    point += 1;
                    break;
                case 7:
                    point += 10;
                    break;
                case int n when (n > 7 && n <= 13):
                    point += 5;
                    break;
                case 14:
                    point += 20;
                    break;
                case int n when (n > 14 && n <= 20):
                    point += 6;
                    break;
                case 21:
                    point += 30;
                    break;
                default:
                    break;

            }
            return point;



        }
               


     }
}
