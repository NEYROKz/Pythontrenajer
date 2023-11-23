using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Pythontrenajerv2.Properties;
using Bunifu.UI.WinForms.Helpers.Transitions;
using Bunifu.UI.WinForms.BunifuButton;
using Siticone.Desktop.UI.WinForms;
using Windowssetup.PAGES;

namespace Windowssetup
{
    public partial class MainWindow : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public MainWindow()
        {
            InitializeComponent();
            InitializeUI("UIMODE");



        }

       private void addUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();

            panelContainer.Controls.Add(userControl);

            userControl.BringToFront();
        }

       private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light")
                {
                    siticoneButton1.ForeColor = Color.Black;
                    siticoneButton2.ForeColor = Color.Black;
                    siticoneButton3.ForeColor = Color.Black;
                    siticoneButton4.ForeColor = Color.Black;
                    siticoneButton5.ForeColor = Color.Black;
                    siticoneButton6.ForeColor = Color.Black;

                    //FillColor
                    siticoneButton1.FillColor = Color.LightGray;
                    siticoneButton2.FillColor = Color.LightGray;
                    siticoneButton3.FillColor = Color.LightGray;
                    siticoneButton4.FillColor = Color.LightGray;
                    siticoneButton5.FillColor = Color.LightGray;
                    siticoneButton6.FillColor = Color.LightGray;

                  //labelchangemode.ForeColor = Color.Black;
                    btnTray.ForeColor = Color.FromArgb(47, 54, 64); // кнопка свернуть в трей
                    btnTray.BackColor = Color.FromArgb(236, 240, 241);
                    btnExit.ForeColor = Color.FromArgb(47, 54, 64);
                    btnExit.BackColor = Color.FromArgb(236, 240, 241); // кнопка закрыть программу
                    this.ForeColor = Color.FromArgb(47, 54, 64); // цвет текста
                    this.BackColor = Color.FromArgb(236, 240, 241); // цвет бэкграунда
                    ConfigurationManager.AppSettings[key] = "dark";

                }
                else
                {
;                     //ForeColor
                    siticoneButton1.ForeColor = Color.White;
                    siticoneButton2.ForeColor = Color.White;
                    siticoneButton3.ForeColor = Color.White;
                    siticoneButton4.ForeColor = Color.White;
                    siticoneButton5.ForeColor = Color.White;
                    siticoneButton6.ForeColor = Color.White;

                    //FillColor
                    siticoneButton1.FillColor = Color.FromArgb(53, 59, 72);
                    siticoneButton2.FillColor = Color.FromArgb(53, 59, 72);
                    siticoneButton3.FillColor = Color.FromArgb(53, 59, 72);
                    siticoneButton4.FillColor = Color.FromArgb(53, 59, 72);
                    siticoneButton5.FillColor = Color.FromArgb(53, 59, 72);
                    siticoneButton6.FillColor = Color.FromArgb(53, 59, 72);


                 //labelchangemode.ForeColor = Color.White;
                    btnTray.ForeColor = Color.FromArgb(236, 240, 241);
                    btnTray.BackColor = Color.FromArgb(47, 54, 64);
                    btnExit.ForeColor = Color.FromArgb(236, 240, 241);
                    btnExit.BackColor = Color.FromArgb(47, 54, 64);
                    this.ForeColor = Color.FromArgb(236, 240, 241);
                    this.BackColor = Color.FromArgb(47, 54, 64);
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        { 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE1.BringToFront();
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE2.BringToFront();
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE3.BringToFront();
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE4.BringToFront();
        }

        private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE5.BringToFront();
        }

        private void siticoneButton6_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE6.BringToFront();
        }

        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void siticonePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void UC_PAGE1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE7.BringToFront();
        }

        private void siticoneButton8_CheckedChanged(object sender, EventArgs e)
        {
            UC_PAGE8.BringToFront();
        }
    }
}
