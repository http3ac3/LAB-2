using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Form1 : Form
    {
        double p = 0; // вероятность 
        double t = 0; // кол-во недель
        int v = 0; // паролей/величина
        double downS; // нижнаяя граница паролей
        int s;  // кол-во паролей
        int accesibleLowSymbols = 26;
        int accesibleLowHighSymbols = 52;
        int accesibleLowHighNumSymbols = 62;

        int l = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private int KnowTheL(int a)
        {
            for (int i = 0; i < 100; i++)
            {
                if (Math.Pow(a, i) >= downS) return i;
            }
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VComboBox.SelectedIndex = 0;
            TComboBox.SelectedIndex = 0;
        }

        private void GetAnswerButton_Click(object sender, EventArgs e)
        {
            switch (VComboBox.SelectedIndex) // 0 - минуту, 1 - дней, 2 - неделю
            {
                case 0:
                    if (TComboBox.SelectedIndex == 0)
                    {
                        t = Math.Round(Convert.ToDouble(TValueBox.Value) / 7.0, 2);
                    }
                    p = Convert.ToDouble(PValueBox.Value);
                    v = Convert.ToInt32(VValueBox.Value) * 60 * 24 * 7;
                    downS = v * t / p;
                    DownSTB.Text = downS.ToString();
                    MessageBox.Show($"A = 26 (все нижние латинские буквы), L = {KnowTheL(accesibleLowSymbols)}");
                    MessageBox.Show($"A = 52 (все нижние и высокие латинские буквы), L = {KnowTheL(accesibleLowHighSymbols)}");
                    MessageBox.Show($"A = 62 (все нижние и высокие латинские буквы + цифры), L = {KnowTheL(accesibleLowHighNumSymbols)}");
                    break;
            }
        }
    }
}
