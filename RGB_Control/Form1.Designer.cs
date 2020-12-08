namespace RGB_Control
{
    partial class Form1
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
            this.Label_State = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SetButton = new MetroFramework.Controls.MetroButton();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RezistorValue = new MetroFramework.Controls.MetroLabel();
            this.Switch2 = new MetroFramework.Controls.MetroLabel();
            this.Switch1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Shutdown = new MetroFramework.Controls.MetroButton();
            this.colorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            this.ModeButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_State
            // 
            this.Label_State.AutoSize = true;
            this.Label_State.Location = new System.Drawing.Point(425, 30);
            this.Label_State.Name = "Label_State";
            this.Label_State.Size = new System.Drawing.Size(114, 19);
            this.Label_State.TabIndex = 0;
            this.Label_State.Text = "НЕ ПОДКЛЮЧЕН";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(522, 272);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ModeButton1);
            this.tabPage1.Controls.Add(this.colorWheel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(514, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Режимы";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Shutdown);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.metroButton1);
            this.tabPage2.Controls.Add(this.SetButton);
            this.tabPage2.Controls.Add(this.colorWheel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(514, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статический режим";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(82, 182);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "-1";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(82, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "+1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(15, 10);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(135, 40);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Установить";
            this.SetButton.UseSelectable = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(283, 3);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(228, 224);
            this.colorWheel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.metroButton3);
            this.tabPage3.Controls.Add(this.metroLabel3);
            this.tabPage3.Controls.Add(this.metroLabel2);
            this.tabPage3.Controls.Add(this.metroLabel1);
            this.tabPage3.Controls.Add(this.metroTextBox3);
            this.tabPage3.Controls.Add(this.metroTextBox2);
            this.tabPage3.Controls.Add(this.metroTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(514, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Цвет в HSV";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(181, 58);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(119, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "V";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(121, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(16, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "S";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(121, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "H";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(20, 109);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(20, 59);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(19, 14);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RezistorValue);
            this.tabPage4.Controls.Add(this.Switch2);
            this.tabPage4.Controls.Add(this.Switch1);
            this.tabPage4.Controls.Add(this.metroLabel6);
            this.tabPage4.Controls.Add(this.metroLabel5);
            this.tabPage4.Controls.Add(this.metroLabel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(514, 230);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Остальное";
            // 
            // RezistorValue
            // 
            this.RezistorValue.AutoSize = true;
            this.RezistorValue.Location = new System.Drawing.Point(260, 103);
            this.RezistorValue.Name = "RezistorValue";
            this.RezistorValue.Size = new System.Drawing.Size(16, 19);
            this.RezistorValue.TabIndex = 5;
            this.RezistorValue.Text = "0";
            // 
            // Switch2
            // 
            this.Switch2.AutoSize = true;
            this.Switch2.Location = new System.Drawing.Point(200, 50);
            this.Switch2.Name = "Switch2";
            this.Switch2.Size = new System.Drawing.Size(34, 19);
            this.Switch2.TabIndex = 4;
            this.Switch2.Text = "OFF";
            // 
            // Switch1
            // 
            this.Switch1.AutoSize = true;
            this.Switch1.Location = new System.Drawing.Point(200, 25);
            this.Switch1.Name = "Switch1";
            this.Switch1.Size = new System.Drawing.Size(34, 19);
            this.Switch1.TabIndex = 3;
            this.Switch1.Text = "OFF";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 103);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(216, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Значение датчика освещенности:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(154, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Состояние тумблера 2: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(152, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Состояние тумблера 1: ";
            // 
            // Shutdown
            // 
            this.Shutdown.Location = new System.Drawing.Point(15, 55);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(135, 40);
            this.Shutdown.TabIndex = 4;
            this.Shutdown.Text = "Выключить";
            this.Shutdown.UseSelectable = true;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // colorWheel2
            // 
            this.colorWheel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel2.Location = new System.Drawing.Point(285, 3);
            this.colorWheel2.Name = "colorWheel2";
            this.colorWheel2.Size = new System.Drawing.Size(228, 224);
            this.colorWheel2.TabIndex = 1;
            // 
            // ModeButton1
            // 
            this.ModeButton1.Location = new System.Drawing.Point(30, 30);
            this.ModeButton1.Name = "ModeButton1";
            this.ModeButton1.Size = new System.Drawing.Size(75, 23);
            this.ModeButton1.TabIndex = 2;
            this.ModeButton1.Text = "Режим 1";
            this.ModeButton1.UseSelectable = true;
            this.ModeButton1.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 352);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Label_State);
            this.Name = "Form1";
            this.Text = "RGB Control";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Label_State;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private MetroFramework.Controls.MetroButton SetButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private MetroFramework.Controls.MetroLabel Switch1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel RezistorValue;
        private MetroFramework.Controls.MetroLabel Switch2;
        private MetroFramework.Controls.MetroButton Shutdown;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
        private MetroFramework.Controls.MetroButton ModeButton1;
    }
}

