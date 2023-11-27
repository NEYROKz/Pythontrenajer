namespace Windowssetup
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTray = new System.Windows.Forms.Button();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton8 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.UC_PAGE1 = new Windowssetup.PAGES.PAGE1();
            this.UC_PAGE2 = new Windowssetup.PAGES.PAGE2();
            this.UC_PAGE3 = new Windowssetup.PAGES.PAGE3();
            this.UC_PAGE4 = new Windowssetup.PAGES.PAGE4();
            this.UC_PAGE5 = new Windowssetup.PAGES.PAGE5();
            this.UC_PAGE6 = new Windowssetup.PAGES.PAGE6();
            this.UC_PAGE7 = new Windowssetup.PAGES.PAGE7();
            this.UC_PAGE8 = new Windowssetup.PAGES.PAGE8();
            this.siticonePanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1056, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTray
            // 
            this.btnTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTray.FlatAppearance.BorderSize = 0;
            this.btnTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTray.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTray.ForeColor = System.Drawing.Color.Black;
            this.btnTray.Location = new System.Drawing.Point(1008, 0);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(47, 44);
            this.btnTray.TabIndex = 2;
            this.btnTray.Text = "−";
            this.btnTray.UseVisualStyleBackColor = true;
            this.btnTray.Click += new System.EventHandler(this.btnTray_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneButton8);
            this.siticonePanel1.Controls.Add(this.siticoneButton7);
            this.siticonePanel1.Controls.Add(this.siticoneButton6);
            this.siticonePanel1.Controls.Add(this.btnExit);
            this.siticonePanel1.Controls.Add(this.btnTray);
            this.siticonePanel1.Controls.Add(this.siticoneButton5);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.siticoneButton4);
            this.siticonePanel1.Controls.Add(this.siticoneButton2);
            this.siticonePanel1.Controls.Add(this.siticoneButton3);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.Size = new System.Drawing.Size(1106, 44);
            this.siticonePanel1.TabIndex = 11;
            this.siticonePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseDown);
            this.siticonePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseMove);
            this.siticonePanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseUp);
            // 
            // siticoneButton8
            // 
            this.siticoneButton8.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton8.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton8.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siticoneButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneButton8.Location = new System.Drawing.Point(840, -1);
            this.siticoneButton8.Name = "siticoneButton8";
            this.siticoneButton8.PressedDepth = 0;
            this.siticoneButton8.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton8.TabIndex = 21;
            this.siticoneButton8.Text = "Задание №8";
            this.siticoneButton8.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton8.CheckedChanged += new System.EventHandler(this.siticoneButton8_CheckedChanged);
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton7.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton7.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siticoneButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneButton7.Location = new System.Drawing.Point(720, 0);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.PressedDepth = 0;
            this.siticoneButton7.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton7.TabIndex = 20;
            this.siticoneButton7.Text = "Задание №7";
            this.siticoneButton7.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton7.CheckedChanged += new System.EventHandler(this.siticoneButton7_CheckedChanged);
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton6.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siticoneButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.Location = new System.Drawing.Point(600, -1);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.PressedDepth = 0;
            this.siticoneButton6.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton6.TabIndex = 19;
            this.siticoneButton6.Text = "Задание №6";
            this.siticoneButton6.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton6.CheckedChanged += new System.EventHandler(this.siticoneButton6_CheckedChanged);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.Location = new System.Drawing.Point(480, 0);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.PressedDepth = 0;
            this.siticoneButton5.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton5.TabIndex = 18;
            this.siticoneButton5.Text = "Задание №5";
            this.siticoneButton5.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton5.CheckedChanged += new System.EventHandler(this.siticoneButton5_CheckedChanged);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.Checked = true;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(0, -1);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedDepth = 0;
            this.siticoneButton1.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton1.TabIndex = 14;
            this.siticoneButton1.Text = "Задание №1";
            this.siticoneButton1.CheckedChanged += new System.EventHandler(this.siticoneButton1_CheckedChanged);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.Location = new System.Drawing.Point(360, -1);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.PressedDepth = 0;
            this.siticoneButton4.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton4.TabIndex = 17;
            this.siticoneButton4.Text = "Задание №4";
            this.siticoneButton4.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton4.CheckedChanged += new System.EventHandler(this.siticoneButton4_CheckedChanged);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(120, -1);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedDepth = 0;
            this.siticoneButton2.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton2.TabIndex = 15;
            this.siticoneButton2.Text = "Задание №2";
            this.siticoneButton2.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton2.CheckedChanged += new System.EventHandler(this.siticoneButton2_CheckedChanged);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButton3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(240, 0);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.PressedDepth = 0;
            this.siticoneButton3.Size = new System.Drawing.Size(120, 45);
            this.siticoneButton3.TabIndex = 16;
            this.siticoneButton3.Text = "Задание №3";
            this.siticoneButton3.TextOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton3.CheckedChanged += new System.EventHandler(this.siticoneButton3_CheckedChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.UC_PAGE1);
            this.panelContainer.Controls.Add(this.UC_PAGE2);
            this.panelContainer.Controls.Add(this.UC_PAGE3);
            this.panelContainer.Controls.Add(this.UC_PAGE4);
            this.panelContainer.Controls.Add(this.UC_PAGE5);
            this.panelContainer.Controls.Add(this.UC_PAGE6);
            this.panelContainer.Controls.Add(this.UC_PAGE7);
            this.panelContainer.Controls.Add(this.UC_PAGE8);
            this.panelContainer.Location = new System.Drawing.Point(0, 45);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1106, 545);
            this.panelContainer.TabIndex = 15;
            // 
            // UC_PAGE1
            // 
            this.UC_PAGE1.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE1.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE1.MinimumSize = new System.Drawing.Size(784, 345);
            this.UC_PAGE1.Name = "UC_PAGE1";
            this.UC_PAGE1.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE1.TabIndex = 14;
            this.UC_PAGE1.Load += new System.EventHandler(this.UC_PAGE1_Load);
            // 
            // UC_PAGE2
            // 
            this.UC_PAGE2.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE2.Name = "UC_PAGE2";
            this.UC_PAGE2.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE2.TabIndex = 13;
            // 
            // UC_PAGE3
            // 
            this.UC_PAGE3.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE3.Name = "UC_PAGE3";
            this.UC_PAGE3.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE3.TabIndex = 15;
            // 
            // UC_PAGE4
            // 
            this.UC_PAGE4.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE4.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE4.MinimumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE4.Name = "UC_PAGE4";
            this.UC_PAGE4.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE4.TabIndex = 16;
            // 
            // UC_PAGE5
            // 
            this.UC_PAGE5.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE5.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE5.MinimumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE5.Name = "UC_PAGE5";
            this.UC_PAGE5.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE5.TabIndex = 17;
            // 
            // UC_PAGE6
            // 
            this.UC_PAGE6.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE6.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE6.MinimumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE6.Name = "UC_PAGE6";
            this.UC_PAGE6.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE6.TabIndex = 18;
            // 
            // UC_PAGE7
            // 
            this.UC_PAGE7.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE7.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE7.MinimumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE7.Name = "UC_PAGE7";
            this.UC_PAGE7.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE7.TabIndex = 19;
            // 
            // UC_PAGE8
            // 
            this.UC_PAGE8.Location = new System.Drawing.Point(0, 0);
            this.UC_PAGE8.MaximumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE8.MinimumSize = new System.Drawing.Size(1106, 545);
            this.UC_PAGE8.Name = "UC_PAGE8";
            this.UC_PAGE8.Size = new System.Drawing.Size(1106, 545);
            this.UC_PAGE8.TabIndex = 20;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 590);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1106, 590);
            this.MinimumSize = new System.Drawing.Size(1106, 590);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Python Trenajer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTray;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private PAGES.PAGE2 UC_PAGE2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private PAGES.PAGE1 UC_PAGE1;
        private System.Windows.Forms.Panel panelContainer;
        private PAGES.PAGE3 UC_PAGE3;
        private PAGES.PAGE4 UC_PAGE4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton8;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;
        private PAGES.PAGE5 UC_PAGE5;
        private PAGES.PAGE6 UC_PAGE6;
        private PAGES.PAGE7 UC_PAGE7;
        private PAGES.PAGE8 UC_PAGE8;
    }
}

