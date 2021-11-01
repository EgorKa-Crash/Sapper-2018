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
    public partial class SolFunction : Form
    {

        const int NUMBERCHECKS = 3;
        private int _seconds;

        public int Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }

        public SolFunction()
        {
            InitializeComponent();
        }

        private void aMathTextBox_TextChanged(object sender, EventArgs e)
        {
        }


        private void ansTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (Seconds == 0)
                Seconds = 3;
            double fNumber;
            if (!double.TryParse(aMathTextBox.Text, out fNumber))
            {
                MessageBox.Show("Введите  !!!число!!!  A ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aMathTextBox.Text = "Значение А";
                return;
            }
            functionOnDisp.Text = ("f=(sin(4П/4+A/3))^2+(cos(3П/4+A/3))^2");
            const double P = Math.PI;
            double functionn = 0;
            int win = -1;
            double answer = 0;
            SinAndCos(fNumber, P, ref functionn);
            Cycle(functionn, win, answer, P);
            if (Seconds == 0)
            {
                MessageBox.Show("Вы не справились   ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Seconds = 3;
                next.Enabled = false;
            }
        }
        internal void Cycle(double functionn, int win, double answer, double P)
        {
            if (!double.TryParse(ansTextBox.Text, out answer))
            {
                MessageBox.Show("Введите  !!!число!!!   ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ansTextBox.Text = "Ответ";
                return;
            }
            Alg(functionn, win, answer); 
        }
        internal void Alg(double functionn, int win, double answer)
        {
            if (answer != functionn)
            {
                komentDec.Text = ("  нет , не правильно  ");
                int k = Seconds - 1;
                chance.Text = "Осталось " + k + "  попыток ";
                Seconds--;
            }
            else
            {
                komentDec.Text = (" Мои поздравления ! Это правильный ответ ");
                next.Enabled = false;
                Seconds = win;

            }
        }
        private static void SinAndCos(double fNumber, double P, ref double functionn)
        {
            functionn = Math.Pow(Math.Sin(3 * P / 4 + fNumber / 3), 2) + Math.Pow(Math.Cos(3 * P / 4 + fNumber / 3), 2);
            functionn = Math.Round(functionn, 5);
        }

        private void chance_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

            Seconds = 3;
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.Show();
        }

        private void aMathTextBox_Click(object sender, EventArgs e)
        { 
            aMathTextBox.Text = String.Empty; 
        }

        private void ansTextBox_Click(object sender, EventArgs e)
        {
            ansTextBox.Text = String.Empty;
        }

        private void functionOnDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void komentDec_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
