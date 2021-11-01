using Kaleev.laba7;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
 
 
        private void AbautMe_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = ("  Калеев Е.Д \r Группа 6104  ");
        }
 
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Task_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ("   Задача 7 лабораторной работы :  раскидать программу  на отдельные куски, используя : методы , конструкторы , скойства , поля. "); 
        }

        private void Saper_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaperTools f5 = new SaperTools();
            f5.Show();
        }

        private void Strings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stringsss f4 = new Stringsss();
            f4.Show();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorting f2 = new Sorting();
            f2.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Functionn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SolFunction f3 = new SolFunction();
            f3.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
