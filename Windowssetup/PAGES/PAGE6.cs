using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowssetup.PAGES
{
    public partial class PAGE6 : UserControl
    {
        Random rnd = new Random();
        public PAGE6()
        {
            InitializeComponent();
            GenerateCondition();
        }

        private void PAGE6_Load(object sender, EventArgs e)
        {

        }
        
        private void GenerateCondition()
        {
            char words;

            int numbers, numbers2, numbers3;

            words = (char)rnd.Next('A', 'Z' + 1);

            numbers = (int)rnd.Next(2, 20);

            numbers2 = (int)rnd.Next(3, 30);

            numbers3 = (int)rnd.Next(9, 50);

            task1.Text = ($"Если переменная {words.ToString()} больше {numbers}, то увеличить переменную {words.ToString()} в {numbers2} раз, \n" +
            $"иначе уменьшить в {numbers3} раз");

            answer.Text = @"^if\s" + words.ToString() + @"\s>\s" + numbers + @":\r\n\s{4}" + words.ToString() + @"\s=\s" + words.ToString() + @"\s\*\s" + numbers2 + @"\r\nelse:\r\n\s{4}" + words.ToString() + @"\s=\s" + words.ToString() + @"\s\/\s" + numbers3 + "$";

            answer2.Text = @"^if\s" + words.ToString() + @">" + numbers + @":\r\n\s{4}" + words.ToString() + @"=" + words.ToString() + @"\*" + numbers2 + @"\r\nelse:\r\n\s{4}" + words.ToString() + @"=" + words.ToString() + @"\/" + numbers3 + "$";

            textBox1.ContextMenu = new ContextMenu();
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, answer.Text, RegexOptions.IgnoreCase) || Regex.IsMatch(textBox1.Text, answer2.Text, RegexOptions.IgnoreCase))
            {
                textBox1.ForeColor = Color.Green;
            }

            buttonreset.Visible = true;
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            GenerateCondition();

            buttonreset.Visible = false;

            textBox1.Text = "";

            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string namequote = ":";

            bool temp = textBox1.Text.Contains(namequote);

            if (temp)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBox1.AppendText("    ");

                }
            }
        }
    }
}
