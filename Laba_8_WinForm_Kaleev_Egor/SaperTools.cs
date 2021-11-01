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
    public partial class SaperTools : Form
    {
        private static int _bombs;
        public static int Bombs       //свойства   
        {
            get
            { 
                return _bombs;
            }
        }
        public SaperTools()
        {
            InitializeComponent(); 
        }

        private void next_Click(object sender, EventArgs e)
        { 
                if ((!int.TryParse(textBoxNMin.Text, out _bombs))||_bombs < 5 || _bombs > 25)
                {
                    MessageBox.Show("Введите  !!!число!!!  от 5 до 25 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                } 
            this.Hide();
            SaperG f6 = new SaperG();
            f6.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.Show();
        }

        private void textBoxNMin_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
