using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using SDT.Prime;

namespace PrimeForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxNumber.Text;
            ulong number;
            BigInteger bigNumber;
            buttonResolve.Enabled = (ulong.TryParse(input, out number) || BigInteger.TryParse(input, out bigNumber));
        }

        private void buttonResolve_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = "";
            string input = textBoxNumber.Text;
            ulong number;
            BigInteger bigNumber;
            if (ulong.TryParse(input, out number))
            {
                List<Tuple<ulong, uint>> answer = Prime.PrimeResolve(number);
                StringBuilder sb = new StringBuilder();
                foreach (var tuple in answer)
                {
                    sb.Append(tuple.Item1 + "^" + tuple.Item2 + "*");
                }
                sb.Remove(sb.Length - 1, 1);
                textBoxAnswer.Text = sb.ToString();
            }
            else if (BigInteger.TryParse(input, out bigNumber))
            {
                List<Tuple<BigInteger, BigInteger>> answer = Prime.PrimeResolve(bigNumber);
                StringBuilder sb = new StringBuilder();
                foreach (var tuple in answer)
                {
                    sb.Append(tuple.Item1 + "^" + tuple.Item2 + "*");
                }
                sb.Remove(sb.Length - 1, 1);
                textBoxAnswer.Text = sb.ToString();
            }
        }

        private void BuildRichTextAnswer(List<Tuple<ulong, uint>> answer)
        {
            
            foreach(var tuple in answer)
            {

            }
        }
    }
}
