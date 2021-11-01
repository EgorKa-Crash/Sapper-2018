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
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите положительное, целое число больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n < 1)
            {
                MessageBox.Show("Введите положительное, целое число больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                n = Convert.ToInt32(textBox2.Text); 
                int[] mas = new int[n];
                int[] masout = new int[n];
                double t2 = 0;
                double t1 = 0;
                string time = "";
                Random ran = new Random();
                Sort.WriteMassRand(mas, ran);
                for (int i = 0; i < n; i++)
                {
                    dataGridViewStart.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridViewStart.Rows[0].Cells[i].Value = mas[i];
                    dataGridViewStart.Columns[i].Width = dataGridViewStart.Width / n;
                }

                Sort.Gnom(mas, ref t1, n, masout);
                for (int i = 0; i < n; i++)
                {
                    dataGridViewGnom.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridViewGnom.Rows[0].Cells[i].Value = masout[i];
                    dataGridViewGnom.Columns[i].Width = dataGridViewStart.Width / n;
                }
                Sort.Mixing(mas, ref t2, n, masout);
                for (int i = 0; i < n; i++)
                    {
                        dataGridViewMix.Columns.Add(new DataGridViewTextBoxColumn());
                    dataGridViewMix.Rows[0].Cells[i].Value = masout[i];
                    dataGridViewMix.Columns[i].Width = dataGridViewStart.Width / n;
                }
                Sort.Vs(t1, t2, ref time);
                result.Text = (time);

/*
                Sort.Gnom(mas, ref t1, n, masout);
                for (int i = 0; i < n; i++)
                {
                    gnom.Text += ("  " + masout[i]);
                }
                Sort.Mixing(mas, ref t2, n, masout);
                for (int i = 0; i < n; i++)
                {
                    mix.Text += ("  " + masout[i]);
                }
                Sort.Vs(t1, t2 ,ref time);
                result.Text = (time);*/
            }

        }
        
 
        private void label2_Click(object sender, EventArgs e)
        {

        }
         

        private void randMass_Click(object sender, EventArgs e)
        { 
        }

        private void gnomMass_Click(object sender, EventArgs e)
        {

        }

        private void mixMass_Click(object sender, EventArgs e)
        {

        }

        private void mix_TextChanged(object sender, EventArgs e)
        {

        }

        private void rand_TextChanged(object sender, EventArgs e)
        {

        }

        private void gnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewStart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
