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
        double s;  // кол-во паролей
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
            AccessibleSymbolsCB.SelectedIndex = 0;
        }

        private void GetAnswerButton_Click(object sender, EventArgs e)
        {
            if (VComboBox.SelectedIndex == 0) v = Convert.ToInt32(VValueBox.Value) * 60 * 24 * 7;
            else if (VComboBox.SelectedIndex == 1) v = Convert.ToInt32(VValueBox.Value) * 7;
            else v = Convert.ToInt32(VValueBox.Value);

            if (TComboBox.SelectedIndex == 0) t = Math.Round(Convert.ToDouble(TValueBox.Value) / 7.0, 2);
            else t = Convert.ToDouble(TValueBox.Value);

            p = Convert.ToDouble(PValueBox.Value);
            downS = v * t / p;
            DownSTB.Text = downS.ToString();
            
            switch (AccessibleSymbolsCB.SelectedIndex)
            {
                case 0:
                    s = Math.Pow(accesibleLowSymbols, KnowTheL(accesibleLowSymbols));
                    break;
                case 1:
                    s = Math.Pow(accesibleLowHighSymbols, KnowTheL(accesibleLowHighSymbols));
                    break;
                case 2:
                    s = Math.Pow(accesibleLowHighNumSymbols, KnowTheL(accesibleLowHighNumSymbols));
                    break;
            }
            SValueTB.Text = s.ToString();
                    }
    }
}
