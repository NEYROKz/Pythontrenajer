using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windowssetup.PAGES
{
    public partial class PAGE1 : UserControl
    {
        const int taskcount = 16;

        const string pattern = @"\w\s*(<|>|==|>=|<=|!=)\s*\d";

        List<Control> list_labels = new List<Control>();

        List<CheckBox> checkboxes = new List<CheckBox>();

        Regex regex = new Regex(pattern);
        public PAGE1()
        {
            InitializeComponent();
            GenerateConditionAnswer();
        }

        private void PAGE1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateConditionAnswer()
        {
            string[] types = { "<", "!=", ">", "==", "=", ",", "><", "<>", ">=", "<=" };

            list_labels.Add(task1);
            list_labels.Add(task2);
            list_labels.Add(task3);
            list_labels.Add(task4);
            list_labels.Add(task5);
            list_labels.Add(task6);
            list_labels.Add(task7);
            list_labels.Add(task8);
            list_labels.Add(task9);
            list_labels.Add(task10);
            list_labels.Add(task11);
            list_labels.Add(task12);
            list_labels.Add(task13);
            list_labels.Add(task14);
            list_labels.Add(task15);
            list_labels.Add(task16);

            checkboxes.Add(checkBoxtask1);
            checkboxes.Add(checkBoxtask2);
            checkboxes.Add(checkBoxtask3);
            checkboxes.Add(checkBoxtask4);
            checkboxes.Add(checkBoxtask5);
            checkboxes.Add(checkBoxtask6);
            checkboxes.Add(checkBoxtask7);
            checkboxes.Add(checkBoxtask8);
            checkboxes.Add(checkBoxtask9);
            checkboxes.Add(checkBoxtask10);
            checkboxes.Add(checkBoxtask11);
            checkboxes.Add(checkBoxtask12);
            checkboxes.Add(checkBoxtask13);
            checkboxes.Add(checkBoxtask14);
            checkboxes.Add(checkBoxtask15);
            checkboxes.Add(checkBoxtask16);

            Random rand = new Random();

            int count = 0;


            for (int i = 0; i <= 15; i++)
            {

                string answer;

                int nametypes;

                nametypes = rand.Next(types.Length);


                char words = (char)rand.Next('A', 'Z' + 1);

                int number = (char)rand.Next(0, 100);

                list_labels[i].Text = ($"{words.ToString()} {types[nametypes]} {number}");

            }



        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            int allrightcount = 0;

            int rightcount = 0;

            for (int i = 0; i <= 15; i++)
            {
                checkboxes[i].Enabled = false;
                if (checkboxes[i].Checked == true)
                {
                    
                    {
                        if (Regex.IsMatch(list_labels[i].Text, pattern, RegexOptions.Multiline))
                        {
                            list_labels[i].ForeColor = Color.Green;
                            rightcount++;
                            allrightcount++;

                        }
                        else
                        {
                            list_labels[i].ForeColor = Color.Red;
                        }
                    }


                }

                if (checkboxes[i].Checked == false)
                {

                    if (Regex.IsMatch(list_labels[i].Text, pattern, RegexOptions.Multiline))
                    {
                        list_labels[i].ForeColor = Color.Green;
                        allrightcount++;
                    }
                    else
                    {
                        list_labels[i].ForeColor = Color.Red;
                    }
                }

                buttonreset.Visible = true;
            }

            rightscount.Text = rightcount.ToString();

            allrightscount.Text = allrightcount.ToString();

            rightscount.Visible = true;

            of.Visible = true;

            nameallrightscount.Visible = true;

            allrightscount.Visible = true;

        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            GenerateConditionAnswer();

            buttonreset.Visible = false;

            for (int i = 0; i <= 15; i++)
            {
                list_labels[i].ForeColor = Color.White;

                checkboxes[i].Checked = false;

                checkboxes[i].Enabled = true;
            }

            rightscount.Visible = false;

            of.Visible = false;

            nameallrightscount.Visible = false;

            allrightscount.Visible = false;

            int rightcount = 0;

            rightscount.Text = rightcount.ToString();

        }
    }
}
