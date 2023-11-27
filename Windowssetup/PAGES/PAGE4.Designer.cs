using System.Windows.Forms;

namespace Windowssetup.PAGES
{
    partial class PAGE4
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.condition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.task1 = new System.Windows.Forms.Label();
            this.buttoncheck = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.buttonreset = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.condition.Location = new System.Drawing.Point(362, 14);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(358, 23);
            this.condition.TabIndex = 27;
            this.condition.Text = "Правильно напишите код на языке Python";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(53, 141);
            this.textBox1.MaximumSize = new System.Drawing.Size(646, 302);
            this.textBox1.MaxLength = 100;
            this.textBox1.MinimumSize = new System.Drawing.Size(646, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 302);
            this.textBox1.TabIndex = 28;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.task1.Location = new System.Drawing.Point(47, 69);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(32, 33);
            this.task1.TabIndex = 29;
            this.task1.Text = "D";
            // 
            // buttoncheck
            // 
            this.buttoncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.buttoncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncheck.Location = new System.Drawing.Point(48, 480);
            this.buttoncheck.Name = "buttoncheck";
            this.buttoncheck.Size = new System.Drawing.Size(136, 39);
            this.buttoncheck.TabIndex = 38;
            this.buttoncheck.Text = "Проверить";
            this.buttoncheck.UseVisualStyleBackColor = false;
            this.buttoncheck.Click += new System.EventHandler(this.buttoncheck_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(705, 494);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(41, 13);
            this.answer.TabIndex = 39;
            this.answer.Text = "answer";
            this.answer.Visible = false;
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.buttonreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonreset.Location = new System.Drawing.Point(206, 480);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(136, 39);
            this.buttonreset.TabIndex = 40;
            this.buttonreset.Text = "Сбросить";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Visible = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(756, 494);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(47, 13);
            this.answer2.TabIndex = 41;
            this.answer2.Text = "answer2";
            this.answer2.Visible = false;
            // 
            // PAGE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.buttoncheck);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.condition);
            this.MaximumSize = new System.Drawing.Size(1106, 545);
            this.MinimumSize = new System.Drawing.Size(1106, 545);
            this.Name = "PAGE4";
            this.Size = new System.Drawing.Size(1106, 545);
            this.Load += new System.EventHandler(this.PAGE4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label task1;
        private System.Windows.Forms.Button buttoncheck;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Label answer2;
    }
}
