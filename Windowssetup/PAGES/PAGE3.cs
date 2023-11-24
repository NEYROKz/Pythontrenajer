using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windowssetup.PAGES
{
    public partial class PAGE3 : UserControl
    {
        const int countask = 6;

        const string pattern1 = @"[a-zA-Z]";

        const string pattern2 = @"\d{2}";

        Regex regex = new Regex(pattern1, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        Regex regex2 = new Regex(pattern2, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        Random rand = new Random();

        Dictionary<string, string> map = new Dictionary<string, string>()
        {
            { @"кратно\s\d{2}\sбез\sостатка", @"%\s\d{2}\s==\s\d[0]$" },

            { @"кратно\s\d{2}\sс\sостатком", @"%\s\d{2}\s==\s1$" },

            { "чётное", @"%\s2\s==\s0$" },

            { "не чётное", @"%\s2\s!=\s0$" },

            { @"кратно\s\d{2}", @"%\s\d{2}\s==\s0$" }, 

            { @"не кратно\s\d{2}", @"%\s\d{2}\s!=\s0$" }, 
        };

        Dictionary<string, string> map2 = new Dictionary<string, string>()
        {
            { @"кратно\s\d{2}\sбез\sостатка", @"%\d{2}==0" },

            { @"кратно\s\d{2}\sс\sостатком", @"%\d{2}==1" },

            { "чётное", @"%2==0$" },

            { "не чётное", @"%2!=0" },

            { @"кратно\s\d{2}", @"%\d{2}==0" },

            { @"не кратно\s\d{2}", @"%\d{2}!=0" },
        };

        //list_labels
        List<Control> list_labels = new List<Control>();

        List<Control> list_labels2 = new List<Control>();

        List<Control> list_labels3 = new List<Control>();

        //list_textbox
        List<TextBox> list_textbox = new List<TextBox>();

        List<TextBox> list_textbox2 = new List<TextBox>();

        List<TextBox> list_textbox3 = new List<TextBox>();
        public PAGE3()
        {
            InitializeComponent();
            GenerateCondition();
        }

        private void PAGE3_Load(object sender, EventArgs e)
        {

        }
        private void GenerateCondition()
        {
            //list_labels
            list_labels.Add(task1);
            list_labels.Add(task5);

            list_labels2.Add(task2);
            list_labels2.Add(task6);

            list_labels3.Add(task3);
            list_labels3.Add(task4);


            //list_textbox
            list_textbox.Add(textBox1);
            list_textbox.Add(textBox5);

            list_textbox2.Add(textBox2);
            list_textbox2.Add(textBox6);

            list_textbox3.Add(textBox3);
            list_textbox3.Add(textBox4);



            string[] OperationsCon = { "кратно", "не кратно", };

            string[] OperationsCon2 = { "чётное", "не чётное" };

            string[] OperationsCon3 = { "без остатка", "с остатком" };

            for (int i = 0; i < 2; i++)
            {
                char words;

                int numbers, nameOperationsCon;

                nameOperationsCon = rand.Next(OperationsCon.Length);

                words = (char)rand.Next('A', 'Z' + 1);

                numbers = (int)rand.Next(10, 99);

                list_labels[i].Text = ($"Число {words.ToString()} {OperationsCon[nameOperationsCon]} {numbers} ");

            }

            for (int i = 0; i < 2; i++)
            {

                char words2;

                int nameOperationsCon2;

                nameOperationsCon2 = rand.Next(OperationsCon2.Length);

                words2 = (char)rand.Next('A', 'Z' + 1);

                list_labels2[i].Text = ($"Число {words2.ToString()} {OperationsCon2[nameOperationsCon2]} ");

            }

            for (int i = 0; i < 2; i++)
            {

                char words3;

                int numbers3, nameOperations3, numbers31;

                nameOperations3 = rand.Next(OperationsCon3.Length);

                words3 = (char)rand.Next('A', 'Z' + 1);

                numbers3 = (int)rand.Next(10, 99);

                list_labels3[i].Text = ($"Число {words3.ToString()} кратно {numbers3} {OperationsCon3[nameOperations3]} ");
            }
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < 2; i++)
            {
                foreach (var kvp in map)
                {
                    if (Regex.IsMatch(list_labels[i].Text, kvp.Key))
                    {   
                        if (map.ContainsKey(kvp.Key) == map.ContainsValue(kvp.Value))
                        {
                            foreach (Match match in regex.Matches(list_labels[i].Text))
                            {
                                if (Regex.IsMatch(list_textbox[i].Text, kvp.Value))
                                {
                                    if (Regex.IsMatch(list_textbox[i].Text, match.Value, RegexOptions.IgnoreCase))
                                    {
                                        count++;
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
                foreach (var kvp in map)
                {
                    if (Regex.IsMatch(list_labels3[i].Text, kvp.Key))
                    {
                        if (map.ContainsKey(kvp.Key) == map.ContainsValue(kvp.Value))
                        {
                            foreach(Match match in regex.Matches(list_labels3[i].Text))
                            {
                                if (Regex.IsMatch(list_textbox3[i].Text , kvp.Value))
                                {
                                    if (Regex.IsMatch(list_textbox3[i].Text , match.Value, RegexOptions.IgnoreCase))
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }

                list_textbox3[i].ReadOnly = true;

            }
            
            for (int i = 0; i < 2; i++)
            {
                foreach (var kvp in map)
                {
                    if (Regex.IsMatch(list_labels2[i].Text, kvp.Key))
                    {
                        if (map.ContainsKey(kvp.Key) == map.ContainsValue(kvp.Value))
                        {
                            foreach(Match match in regex.Matches(list_labels2[i].Text))
                            {
                                if (Regex.IsMatch(list_textbox2[i].Text, kvp.Value))
                                {
                                    if (Regex.IsMatch(list_textbox2[i].Text, match.Value, RegexOptions.IgnoreCase))
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }

                list_textbox2[i].ReadOnly = true;

            }

            namecountright.Visible = true;

            countright.Visible = true;

            countright.Text = count.ToString();

            buttonreset.Visible = true;
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            GenerateCondition();

            buttonreset.Visible = false;

            int count = 0;

            countright.Text = count.ToString();

            for(int i = 0; i < 2; i++)
            {
                list_textbox[i].Text = "";

                list_textbox[i].ReadOnly = false;
            }

            for (int i = 0; i < 2; i++)
            {
                list_textbox2[i].Text = "";

                list_textbox2[i].ReadOnly = false;
            }

            for (int i = 0; i < 2; i++)
            {
                list_textbox3[i].Text = "";

                list_textbox3[i].ReadOnly = false;
            }

            namecountright.Visible = false;

            countright.Visible = false;
        }
    }
}
