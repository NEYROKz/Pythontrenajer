using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windowssetup.PAGES
{
    public partial class PAGE7 : UserControl
    {
        Random rnd = new Random();

        bool forBackspace = false;

        bool forSpace = false;
        public PAGE7()
        {
            InitializeComponent();
            GenerateCondition();
        }

        private void PAGE7_Load(object sender, EventArgs e)
        {

        }

        private void GenerateCondition()
        {
            char words;

            int numbers2, numbers3;

            words = (char)rnd.Next('A', 'Z' + 1);

            numbers2 = (int)rnd.Next(7, 70);

            numbers3 = (int)rnd.Next(2, 90);

            task1.Text = ($"Если переменная {words.ToString()} чётная , то увеличить переменную {words.ToString()} в {numbers2} раз, \n" +
            $"иначе уменьшить на {numbers3}");

            answer.Text = @"^if\s" + words.ToString() + @"\s%\s2\s==\s0:\r\n\s{4}" + words.ToString() + @"\s=\s" + words.ToString() + @"\s\*\s" + numbers2 + @"\r\nelse:\r\n\s{4}" + words.ToString() + @"\s=\s" + words.ToString() + @"\s\-\s" + numbers3 + "$";

            answer2.Text = @"^if\s" + words.ToString() + @"%2==0:\r\n\s{4}" + words.ToString() + @"=" + words.ToString() + @"\*" + numbers2 + @"\r\nelse:\r\n\s{4}" + words.ToString() + @"=" + words.ToString() + @"\-" + numbers3 + "$";

            textBox1.ContextMenu = new ContextMenu();
        }


        private void buttoncheck_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, answer.Text, RegexOptions.IgnoreCase) || Regex.IsMatch(textBox1.Text, answer2.Text, RegexOptions.IgnoreCase))
            {
                textBox1.BackColor = textBox1.BackColor;
                textBox1.ForeColor = Color.Green;
                textBox1.ReadOnly = true;
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
                    this.forBackspace = true;

                }
            }

            if (this.forBackspace == true)
            {

                if (e.KeyCode == Keys.Back && textBox1.Text.Length > 3)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 3);
                    textBox1.SelectionStart = textBox1.TextLength;

                    this.forBackspace = false;

                }
            }

            string nameif = "if";

            bool temp2 = textBox1.Text.Contains(nameif);

            if (this.forSpace == false)
            {
                if (temp2)
                {
                    textBox1.AppendText(" ");
                    this.forSpace = true;

                }

            }

            if (!temp2)
            {
                this.forSpace = false;
            }
        }
    }
}
