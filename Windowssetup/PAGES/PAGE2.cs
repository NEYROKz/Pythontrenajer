using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windowssetup.PAGES
{

    public partial class PAGE2 : UserControl
    {
        Random rand = new Random();

        const int countask = 6;

        const string pattern1 = @"[a-zA-Z]";

        const string pattern2 = @"\d{2}";

        Regex regex = new Regex(pattern1, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        Regex regex2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        List<Control> list_labels = new List<Control>();

        List<Control> list_labels2 = new List<Control>();

        Dictionary<string, string> map = new Dictionary<string, string>()
        {
            {@"Число\s\w*([a-zA-Z])\s\w*(не равно)\s\d{2}", "!=" },
            {@"Число\s\w*([a[zA-Z])\s\w*(равно)\s\d{2}", "==" },
            {@"\w\sбольше\sили\sравно\s\d{2}", ">=" },
            {@"\w\sменьше\sили\sравно\s\d{2}", "<=" },
            {@"\w\sменьше\s\d{2}", "<" },
            {@"\w\sбольше\s\d{2}", ">" },
        };

        Dictionary<string, string> map2 = new Dictionary<string, string>()
        {
            {@"\w\sположительное", "> 0|>0" },
            {@"\w\sотрицательное", "< 0|<0" },
        };

        List<TextBox> list_textbox = new List<TextBox>();

        List<TextBox> list_textbox2 = new List<TextBox>();
        public PAGE2()
        {
            InitializeComponent();
            GenerateCondition();
        }

        private void PAGE2_Load(object sender, EventArgs e)
        {

        }

        private void GenerateCondition()
        {
            string[] operationCon = { "не равно", "равно", "больше или равно", "меньше или равно", "меньше", "больше" };

            string[] operationCon2 = { "положительное", "отрицательное" };

            list_labels.Add(task1);
            list_labels.Add(task2);
            list_labels.Add(task3);
            list_labels.Add(task4);

            list_labels2.Add(task5);
            list_labels2.Add(task6);

            list_textbox.Add(textBox1);
            list_textbox.Add(textBox2);
            list_textbox.Add(textBox3);
            list_textbox.Add(textBox4);
            list_textbox2.Add(textBox5);
            list_textbox2.Add(textBox6);

            for (int i = 0; i < 4; i++)
            {

                char words;

                int numbers, nameoperationCon;

                words = (char)rand.Next('A', 'Z' + 1);

                numbers = (int)rand.Next(10, 99);

                nameoperationCon = rand.Next(operationCon.Length);

                list_labels[i].Text = ($"Число {words.ToString()} {operationCon[nameoperationCon]} {numbers}");

                list_textbox[i].ContextMenu = new ContextMenu();

            }

            for (int i = 0; i < 2; i++)
            {
                char words2;

                int nameoperationCon2;

                words2 = (char)rand.Next('A', 'Z' + 1);

                nameoperationCon2 = rand.Next(operationCon2.Length);

                list_labels2[i].Text = ($"Число {words2.ToString()} {operationCon2[nameoperationCon2]}");

                list_textbox2[i].ContextMenu = new ContextMenu();

            }


        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                foreach (var kvp in map)
                {
                    if (Regex.IsMatch(list_labels[i].Text, kvp.Key))
                    {
                        if (map.ContainsKey(kvp.Key) == map.ContainsValue(kvp.Value))
                        {
                            foreach (Match match in regex.Matches(list_labels[i].Text))
                            {
                                foreach (Match match2 in regex2.Matches(list_labels[i].Text))
                                {
                                    if (Regex.IsMatch(list_textbox[i].Text, kvp.Value))
                                    {
                                        if (Regex.IsMatch(list_textbox[i].Text, match.Value, RegexOptions.IgnoreCase))
                                        {
                                            if (Regex.IsMatch(list_textbox[i].Text, match2.Value, RegexOptions.IgnoreCase))
                                            {
                                                count++;

                                                list_textbox[i].BackColor = list_textbox[i].BackColor;

                                                list_textbox[i].ForeColor = Color.Green;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }

                list_textbox[i].ReadOnly = true;

            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var kvp in map2)
                {
                    if (Regex.IsMatch(list_labels2[i].Text, kvp.Key))
                    {
                        if (map2.ContainsKey(kvp.Key) == map2.ContainsValue(kvp.Value))
                        {
                            foreach (Match match in regex.Matches(list_labels2[i].Text))
                            {
                                if (Regex.IsMatch(list_textbox2[i].Text, kvp.Value))
                                {
                                    count++;

                                    list_textbox2[i].BackColor = list_textbox[i].BackColor;

                                    list_textbox2[i].ForeColor = Color.Green;
                                }
                            }
                        }
                    }
                }

                list_textbox2[i].ReadOnly = true;

            }

            countright.Text = count.ToString();

            buttonreset.Visible = true;

            countright.Visible = true;

            namecountright.Visible = true;  

        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            GenerateCondition();

            buttonreset.Visible = false;

            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                list_textbox[i].Text = "";

                list_textbox[i].ReadOnly = false;

                list_textbox[i].ForeColor = Color.Black;
            }

            for (int i = 0; i < 2; i++)
            {
                list_textbox2[i].Text = "";

                list_textbox2[i].ReadOnly = false;

                list_textbox2[i].ForeColor = Color.Black;
            }

            for (int i = 0; i < countask; i++)
            {
                countright.Text = count.ToString();
            }

            countright.Visible = false;

            namecountright.Visible = false;
        }

            
    }
}
