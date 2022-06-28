using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ReverteString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        private void calcBinario_Click(object sender, EventArgs e)
        {
            int decimalValue = Convert.ToInt32(decimalVar.Text);
            string binarioValue = "";

            if (decimalValue == 0 || decimalValue == 1)
            {
                Convert.ToString(decimalValue);
            }
            else
            {
                while (decimalValue > 0)
                {
                    binarioValue += decimalValue % 2;
                    decimalValue = decimalValue / 2;
                    
                }
                binarioVar.Text = ReverteString(binarioValue);
            }

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            binarioVar.Text = "";
            decimalVar.Text = "";
        }
    }
}
