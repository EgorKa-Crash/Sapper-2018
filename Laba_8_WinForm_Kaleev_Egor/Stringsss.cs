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
    public partial class Stringsss : Form
    {
        public Stringsss()
        {
            InitializeComponent();
        }
        private void next_Click(object sender, EventArgs e)
        { 
            TextForReorg.Text += " \r  Строка в нижнем регистре , без пробелов:  \r " + TextForReorg.Text.ToLower().Replace(" ", string.Empty);
        }
        private void TextForReorg_TextChanged(object sender, EventArgs e)
        {

        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.Show();
        }
        private void Prob_Click(object sender, EventArgs e)
        { 
            int h = 3;
            int[] St = new int[h];
            string[] str = new string[h];
            ProbStr(h, St, ref str);
        }
        private void ProbStr(int H, int[] St, ref string[] str)                                //  Пробные строки строки
        {
            TextForReorg.Text = ("    Исходные строки : \r"); 
            str[0] = "Как уже ветерок весенний";
            str[1] = "Поселился в зеленом ростке";
            str[2] = "Не успела отнять руки,";
            TextForReorg.Text += ("  \r  Строка 1 : " + str[0]);
            TextForReorg.Text += ("  \r  Строка 2 : " + str[1]);
            TextForReorg.Text += ("  \r  Строка 3 : " + str[2]);
            TextForReorg.Text += ("  \r Строки в нижнем регистре :   ");
            for (int i = 0; i < H; i++)
            {
                St[i] = str[i].Replace(" ", string.Empty).Length;
            }
            int nk = 0;
            for (int i = 0; i < H; i++)
            {
                int outt = Num(ref nk, H, St);
                TextForReorg.Text += (" \r  Строка "+i+" : ");
                TextForReorg.Text += (" " + str[outt].ToLower().Replace(" ", string.Empty));
            }
             
        }
        /// <summary>
        /// Сортируем строки по убыванию
        /// </summary>
        /// <param name="nk"></param>
        /// <param name="H"></param>
        /// <param name="St"></param>
        /// <returns></returns>
        private int Num(ref int nk, int H, int[] St)
        {
            int k = 10000;
            int p = 0;
            for (int i = 0; i < H; i++)
            {
                if (St[i] < k && St[i] > nk)
                {
                    k = St[i];

                }
            }
            for (int i = 0; i < H; i++)
            {
                if (k == St[i]) p = i;

            }
            nk = St[p];
            return p;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            TextForReorg.Text = ("");
        }
    }
}
