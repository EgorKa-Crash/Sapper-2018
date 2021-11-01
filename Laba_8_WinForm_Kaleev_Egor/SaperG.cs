using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_8_WinForm_Kaleev_Egor
{


    internal partial class SaperG : Form
    { 
        Button[,] but = new Button[10, 10];
        private const int MINE = 9;
        private int[,] _Bombs = new int[12, 12];
        private int[,] _State = new int[10, 10];
        private int _bomb = SaperTools.Bombs;
        private int _TrueBomb = 0;      // победа когда станет равным бомбам
        private int LOSE = SaperTools.Bombs + 1;
        private const int SIZE = 10;
        /*Bitmap B = new Bitmap(@"C:\\Users\Olga_K\\Desktop\\labi\\Laba_8_WinForm_Kaleev_Egor\\mina.png");
        Bitmap Flag = new Bitmap(@"C:\\Users\Olga_K\\Desktop\\labi\\Laba_8_WinForm_Kaleev_Egor\\Flag.png");
        Bitmap Travaaa = new Bitmap(@"C:\\Users\Olga_K\\Desktop\\labi\\Laba_8_WinForm_Kaleev_Egor\\Travaaa.png");*/
        Bitmap B = new Bitmap(Properties.Resources.mina);
        Bitmap Flag = new Bitmap(Properties.Resources.Flag); 
        /// <summary>
        /// запуск формы
        /// </summary>
        internal SaperG()
        {
            InitializeComponent();
            Sap(); 
        }
        /// <summary>
        /// выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.Show();
        }
        /// <summary>
        /// обработка нажатия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b1(object sender, EventArgs e)
        {
            double[] _XYButton = new double[2];
            int victoryCheck = 0;
            if (Convert.ToInt32((sender as Button).Tag) >= 0)
            {
                int k = (Convert.ToInt32((sender as Button).Tag));
                XYBut(sender, k, _XYButton);
                int xx = Convert.ToInt32(_XYButton[0]);
                int yy = Convert.ToInt32(_XYButton[1]); 
                CheckClik(victoryCheck, xx, yy);
                CheckWinOrLose(victoryCheck, xx, yy);
            }
        }
        /// <summary>
        /// рашшифрование тэга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="k"></param>
        /// <param name="_XYButton"></param>
        private void XYBut(object sender, int k, double[] _XYButton)
        {
            _XYButton[0] = Math.Truncate((double)(k / 100));
            _XYButton[1] = Math.Truncate(k - (_XYButton[0] * 100));
        }
        /// <summary>
        /// создание кнопок
        /// </summary>
        /// <param name="Bombs"></param>
        private void ButtonCr(int[,] Bombs)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    but[i, j] = new Button();
                    but[i, j].Top = j * 40 + 25;
                    but[i, j].Left = i * 40 + 234;
                   // but[i, j]. BackgroundImage = Travaaa;//FromArgb(0, 191, 255);
                    but[i, j].Size = new Size(40, 40);
                    but[i, j].Tag = (i * 100 + j);
                    but[i, j].Click += new EventHandler(b1);
                    step.Checked = true;
                    this.Controls.Add(but[i, j]);
                }
            }
        }

        private void Sap()
        {
            RandBombs(_Bombs, SIZE, _bomb);
            Aroundbombs(ref _Bombs, SIZE);
            ButtonCr(_Bombs);
        }
        /// <summary>
        /// Рандомируем место мины на поле 
        /// </summary>
        /// <param name="Bombs"></param>
        /// <param name="SIZE"></param>
        /// <param name="bomb"></param>
        internal static void RandBombs(int[,] Bombs, int SIZE, int bomb)                //  Рандомируем бомбы
        {
            int x = 0;
            int y = 0;
            int i = 0;
            while (i < bomb)
            {
                Random rand = new Random();
                for (int r = 0; r < rand.Next(1, SIZE + 1); r++)
                    x = rand.Next(1, SIZE + 1);
                for (int r = 0; r < rand.Next(1, SIZE + 1); r++)
                    y = rand.Next(1, SIZE + 1);
                if (Bombs[y, x] != MINE)
                {
                    Bombs[y, x] = MINE;
                    i++;
                }
            }
        }
        /// <summary>
        /// Бегаем по полю в поисках мины
        /// </summary>
        /// <param name="Bombs"></param>
        /// <param name="SIZE"></param>
        internal static void Aroundbombs(ref int[,] Bombs, int SIZE)                //  Прибавляем однерки вокруг бомб
        {
            for (int i = 1; i < SIZE + 1; i++)
            {
                for (int j = 1; j < SIZE + 1; j++)
                {
                    if (Bombs[i, j] >= MINE)
                    {
                        Aroundbomb(SIZE, ref Bombs, i, j);
                    }
                }
            }
            for (int i = 1; i < SIZE + 1; i++)
            {
                for (int j = 1; j < SIZE + 1; j++)
                {
                    if (Bombs[i, j] >= MINE)
                    {
                        Bombs[i, j] = MINE;
                    }
                }
            }
        }
        /// <summary>
        /// Выставляем однерки вокруг мин
        /// </summary>
        /// <param name="Bombs"></param>
        /// <param name="SIZE"></param>
        internal static void Aroundbomb(int SIZE, ref int[,] Bombs, int i, int j)                //  + 1 вокруг >= 9
        {
            for (int t = i - 1; t < i + 2; t++)
            {
                for (int k = j - 1; k < j + 2; k++)
                {
                    Bombs[t, k] = Bombs[t, k] + 1;
                }
            }
        }
        /// <summary>
        /// проверка на победу или поражение
        /// </summary>
        /// <param name="victoryCheck"></param>
        /// <param name="xx"></param>
        /// <param name="yy"></param>
        private void CheckClik(int victoryCheck, int xx, int yy)
        {
            if (flag.Checked == true)
            { 
                if (_State[xx, yy] == 0)
                {
                    _State[xx, yy] = 1; //поставлен флаг
                    but[xx, yy].BackgroundImage = Flag;
                    if (_Bombs[xx + 1, yy + 1] == 9)
                        _State[xx, yy] = 3; //флаг на бомбе
                }
                else if (_State[xx, yy] == 1)
                {
                    _State[xx, yy] = 0;  //эл открывали
                    but[xx, yy].BackgroundImage = null;
                    if (_Bombs[xx + 1, yy + 1] == 9)
                        _TrueBomb--;
                }

            }
            if (step.Checked == true && _State[xx, yy] != 1)
            {
                if (_Bombs[xx + 1, yy + 1] >= 9)
                {
                    _State[xx, yy] = 2; 
                    _TrueBomb = LOSE;
                }
                else
                {
                    WorcWithButton(xx, yy);
                    if (_Bombs[xx + 1, yy + 1] == 0)
                        OpenAround();
                } 
            }
        }
        /// <summary>
        /// внешка кнопки после нажатия
        /// </summary>
        /// <param name="xx"></param>
        /// <param name="yy"></param>
        private void WorcWithButton(int xx, int yy)
        {
            if (xx >= 0 && xx <= 9 && yy >= 0 && yy <= 9)
            {
                but[xx, yy].BackgroundImage = null;
                _State[xx, yy] = 2;
                but[xx, yy].Text = "" + _Bombs[xx + 1, yy + 1];
                //but[xx, yy].BackgroundImage = Travaaa;//
                but[xx, yy].BackColor = Color.FromArgb  (255 - (28 * _Bombs[xx + 1, yy + 1]), 255 - (28 * _Bombs[xx + 1, yy + 1]), 255 - (28 * _Bombs[xx + 1, yy + 1]));
            }
        }
        /// <summary>
        /// оконьчание программы
        /// </summary>
        /// <param name="victoryCheck"></param>
        /// <param name="xx"></param>
        /// <param name="yy"></param>
        private void CheckWinOrLose(int victoryCheck, int xx, int yy)
        {
            int k = CheckWin();
            if (k == SIZE*SIZE)
            { 
                textBox1.Text += ("   Победа ");
                BlocButtons();
            }
            if (_TrueBomb == LOSE)
            {
                textBox1.Text += ("   Поражение ");
                BlocButtons(); 
            }
        }
        private int CheckWin ()
        {
            int k = 0;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (_State[i, j] == 2 || _State[i, j] == 3)
                        k ++;
                }
            }
                    return k;
        }
        /// <summary>
        /// открытие 0
        /// </summary>
        private void BlocButtons()             
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                { 
                    if ( _State[i,j] == 0 || _State[i, j] == 1 && _Bombs[i + 1, j + 1] != 9)
                    {
                        but[i, j].BackgroundImage = null;
                        WorcWithButton(i, j);
                    } 
                        if (_Bombs [i+1,j+1] == 9 && _State[i, j] != 3)
                    but[i, j].BackgroundImage = B;
                    but[i, j].Enabled = false; 
                }
            }
        }
        private void OpenAround()             //  Из массива в массив
        {
            for (int k = 0; k < 20; k++)
            {
                for (int i = 0; i < SIZE; i++)
                {
                    for (int j = 0; j < SIZE; j++)
                    {
                        if (_Bombs[i + 1, j + 1] == 0 && _State[i, j] == 2)
                        {
                            OpenAround0(i, j);
                        }
                    }
                }
            }
        }
        private void OpenAround0(int i, int j)                //  открываем вокруг 0
        {
            for (int t = j - 1; t < j + 2; t++)
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    WorcWithButton(k, t);
                }
            }
        }

        private void flag_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void step_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
