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
            this.components = new System.ComponentModel.Container();
            this.Label_State = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Page_StaticMode = new System.Windows.Forms.TabPage();
            this.Button_V_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_H_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_S_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_B_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_G_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_R_Minus = new MetroFramework.Controls.MetroButton();
            this.Button_V_Plus = new MetroFramework.Controls.MetroButton();
            this.Button_S_Plus = new MetroFramework.Controls.MetroButton();
            this.Button_H_Plus = new MetroFramework.Controls.MetroButton();
            this.Button_B_Plus = new MetroFramework.Controls.MetroButton();
            this.Button_G_Plus = new MetroFramework.Controls.MetroButton();
            this.Button_R_Plus = new MetroFramework.Controls.MetroButton();
            this.H_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.S_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.V_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.V_Label = new MetroFramework.Controls.MetroLabel();
            this.S_Label = new MetroFramework.Controls.MetroLabel();
            this.H_Label = new MetroFramework.Controls.MetroLabel();
            this.B_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.G_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.R_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.G_Label = new MetroFramework.Controls.MetroLabel();
            this.B_Label = new MetroFramework.Controls.MetroLabel();
            this.R_Label = new MetroFramework.Controls.MetroLabel();
            this.Shutdown = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SetButton = new MetroFramework.Controls.MetroButton();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RezistorValue = new MetroFramework.Controls.MetroLabel();
            this.Switch2 = new MetroFramework.Controls.MetroLabel();
            this.Switch1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ModeButton1 = new MetroFramework.Controls.MetroButton();
            this.colorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_RGBtoHSV = new MetroFramework.Controls.MetroButton();
            this.Btn_HSVtoRGB = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.Page_StaticMode.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_State
            // 
            this.Label_State.AutoSize = true;
            this.Label_State.Location = new System.Drawing.Point(508, 27);
            this.Label_State.Name = "Label_State";
            this.Label_State.Size = new System.Drawing.Size(114, 19);
            this.Label_State.TabIndex = 0;
            this.Label_State.Text = "НЕ ПОДКЛЮЧЕН";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Page_StaticMode);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(602, 346);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Page_StaticMode
            // 
            this.Page_StaticMode.Controls.Add(this.Btn_HSVtoRGB);
            this.Page_StaticMode.Controls.Add(this.Btn_RGBtoHSV);
            this.Page_StaticMode.Controls.Add(this.Button_V_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_H_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_S_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_B_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_G_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_R_Minus);
            this.Page_StaticMode.Controls.Add(this.Button_V_Plus);
            this.Page_StaticMode.Controls.Add(this.Button_S_Plus);
            this.Page_StaticMode.Controls.Add(this.Button_H_Plus);
            this.Page_StaticMode.Controls.Add(this.Button_B_Plus);
            this.Page_StaticMode.Controls.Add(this.Button_G_Plus);
            this.Page_StaticMode.Controls.Add(this.Button_R_Plus);
            this.Page_StaticMode.Controls.Add(this.H_TextBox);
            this.Page_StaticMode.Controls.Add(this.S_TextBox);
            this.Page_StaticMode.Controls.Add(this.V_TextBox);
            this.Page_StaticMode.Controls.Add(this.V_Label);
            this.Page_StaticMode.Controls.Add(this.S_Label);
            this.Page_StaticMode.Controls.Add(this.H_Label);
            this.Page_StaticMode.Controls.Add(this.B_TextBox);
            this.Page_StaticMode.Controls.Add(this.G_TextBox);
            this.Page_StaticMode.Controls.Add(this.R_TextBox);
            this.Page_StaticMode.Controls.Add(this.G_Label);
            this.Page_StaticMode.Controls.Add(this.B_Label);
            this.Page_StaticMode.Controls.Add(this.R_Label);
            this.Page_StaticMode.Controls.Add(this.Shutdown);
            this.Page_StaticMode.Controls.Add(this.metroButton2);
            this.Page_StaticMode.Controls.Add(this.metroButton1);
            this.Page_StaticMode.Controls.Add(this.SetButton);
            this.Page_StaticMode.Controls.Add(this.colorWheel1);
            this.Page_StaticMode.Location = new System.Drawing.Point(4, 38);
            this.Page_StaticMode.Name = "Page_StaticMode";
            this.Page_StaticMode.Size = new System.Drawing.Size(594, 304);
            this.Page_StaticMode.TabIndex = 1;
            this.Page_StaticMode.Text = "Статический режим";
            // 
            // Button_V_Minus
            // 
            this.Button_V_Minus.Location = new System.Drawing.Point(275, 160);
            this.Button_V_Minus.Name = "Button_V_Minus";
            this.Button_V_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_V_Minus.TabIndex = 28;
            this.Button_V_Minus.Text = "-";
            this.Button_V_Minus.UseSelectable = true;
            this.Button_V_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_H_Minus
            // 
            this.Button_H_Minus.Location = new System.Drawing.Point(275, 100);
            this.Button_H_Minus.Name = "Button_H_Minus";
            this.Button_H_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_H_Minus.TabIndex = 27;
            this.Button_H_Minus.Text = "-";
            this.Button_H_Minus.UseSelectable = true;
            this.Button_H_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_S_Minus
            // 
            this.Button_S_Minus.Location = new System.Drawing.Point(275, 130);
            this.Button_S_Minus.Name = "Button_S_Minus";
            this.Button_S_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_S_Minus.TabIndex = 26;
            this.Button_S_Minus.Text = "-";
            this.Button_S_Minus.UseSelectable = true;
            this.Button_S_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_B_Minus
            // 
            this.Button_B_Minus.Location = new System.Drawing.Point(275, 70);
            this.Button_B_Minus.Name = "Button_B_Minus";
            this.Button_B_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_B_Minus.TabIndex = 25;
            this.Button_B_Minus.Text = "-";
            this.Button_B_Minus.UseSelectable = true;
            this.Button_B_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_G_Minus
            // 
            this.Button_G_Minus.Location = new System.Drawing.Point(275, 40);
            this.Button_G_Minus.Name = "Button_G_Minus";
            this.Button_G_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_G_Minus.TabIndex = 24;
            this.Button_G_Minus.Text = "-";
            this.Button_G_Minus.UseSelectable = true;
            this.Button_G_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_R_Minus
            // 
            this.Button_R_Minus.Location = new System.Drawing.Point(275, 10);
            this.Button_R_Minus.Name = "Button_R_Minus";
            this.Button_R_Minus.Size = new System.Drawing.Size(24, 23);
            this.Button_R_Minus.TabIndex = 23;
            this.Button_R_Minus.Text = "-";
            this.Button_R_Minus.UseSelectable = true;
            this.Button_R_Minus.Click += new System.EventHandler(this.RGBHSV_MINUS);
            // 
            // Button_V_Plus
            // 
            this.Button_V_Plus.Location = new System.Drawing.Point(245, 160);
            this.Button_V_Plus.Name = "Button_V_Plus";
            this.Button_V_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_V_Plus.TabIndex = 22;
            this.Button_V_Plus.Text = "+";
            this.Button_V_Plus.UseSelectable = true;
            this.Button_V_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // Button_S_Plus
            // 
            this.Button_S_Plus.Location = new System.Drawing.Point(245, 130);
            this.Button_S_Plus.Name = "Button_S_Plus";
            this.Button_S_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_S_Plus.TabIndex = 21;
            this.Button_S_Plus.Text = "+";
            this.Button_S_Plus.UseSelectable = true;
            this.Button_S_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // Button_H_Plus
            // 
            this.Button_H_Plus.Location = new System.Drawing.Point(245, 100);
            this.Button_H_Plus.Name = "Button_H_Plus";
            this.Button_H_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_H_Plus.TabIndex = 20;
            this.Button_H_Plus.Text = "+";
            this.Button_H_Plus.UseSelectable = true;
            this.Button_H_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // Button_B_Plus
            // 
            this.Button_B_Plus.Location = new System.Drawing.Point(245, 70);
            this.Button_B_Plus.Name = "Button_B_Plus";
            this.Button_B_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_B_Plus.TabIndex = 19;
            this.Button_B_Plus.Text = "+";
            this.Button_B_Plus.UseSelectable = true;
            this.Button_B_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // Button_G_Plus
            // 
            this.Button_G_Plus.Location = new System.Drawing.Point(245, 40);
            this.Button_G_Plus.Name = "Button_G_Plus";
            this.Button_G_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_G_Plus.TabIndex = 18;
            this.Button_G_Plus.Text = "+";
            this.Button_G_Plus.UseSelectable = true;
            this.Button_G_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // Button_R_Plus
            // 
            this.Button_R_Plus.Location = new System.Drawing.Point(245, 10);
            this.Button_R_Plus.Name = "Button_R_Plus";
            this.Button_R_Plus.Size = new System.Drawing.Size(24, 23);
            this.Button_R_Plus.TabIndex = 17;
            this.Button_R_Plus.Text = "+";
            this.Button_R_Plus.UseSelectable = true;
            this.Button_R_Plus.Click += new System.EventHandler(this.RGBHSV_PLUS);
            // 
            // H_TextBox
            // 
            // 
            // 
            // 
            this.H_TextBox.CustomButton.Image = null;
            this.H_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.H_TextBox.CustomButton.Name = "";
            this.H_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.H_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.H_TextBox.CustomButton.TabIndex = 1;
            this.H_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.H_TextBox.CustomButton.UseSelectable = true;
            this.H_TextBox.CustomButton.Visible = false;
            this.H_TextBox.Lines = new string[] {
        "000"};
            this.H_TextBox.Location = new System.Drawing.Point(195, 100);
            this.H_TextBox.MaxLength = 32767;
            this.H_TextBox.Name = "H_TextBox";
            this.H_TextBox.PasswordChar = '\0';
            this.H_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.H_TextBox.SelectedText = "";
            this.H_TextBox.SelectionLength = 0;
            this.H_TextBox.SelectionStart = 0;
            this.H_TextBox.ShortcutsEnabled = true;
            this.H_TextBox.Size = new System.Drawing.Size(45, 23);
            this.H_TextBox.TabIndex = 16;
            this.H_TextBox.Text = "000";
            this.H_TextBox.UseSelectable = true;
            this.H_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.H_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // S_TextBox
            // 
            // 
            // 
            // 
            this.S_TextBox.CustomButton.Image = null;
            this.S_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.S_TextBox.CustomButton.Name = "";
            this.S_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.S_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.S_TextBox.CustomButton.TabIndex = 1;
            this.S_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.S_TextBox.CustomButton.UseSelectable = true;
            this.S_TextBox.CustomButton.Visible = false;
            this.S_TextBox.Lines = new string[] {
        "000"};
            this.S_TextBox.Location = new System.Drawing.Point(195, 130);
            this.S_TextBox.MaxLength = 32767;
            this.S_TextBox.Name = "S_TextBox";
            this.S_TextBox.PasswordChar = '\0';
            this.S_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.S_TextBox.SelectedText = "";
            this.S_TextBox.SelectionLength = 0;
            this.S_TextBox.SelectionStart = 0;
            this.S_TextBox.ShortcutsEnabled = true;
            this.S_TextBox.Size = new System.Drawing.Size(45, 23);
            this.S_TextBox.TabIndex = 15;
            this.S_TextBox.Text = "000";
            this.S_TextBox.UseSelectable = true;
            this.S_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.S_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // V_TextBox
            // 
            // 
            // 
            // 
            this.V_TextBox.CustomButton.Image = null;
            this.V_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.V_TextBox.CustomButton.Name = "";
            this.V_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.V_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.V_TextBox.CustomButton.TabIndex = 1;
            this.V_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.V_TextBox.CustomButton.UseSelectable = true;
            this.V_TextBox.CustomButton.Visible = false;
            this.V_TextBox.Lines = new string[] {
        "000"};
            this.V_TextBox.Location = new System.Drawing.Point(195, 160);
            this.V_TextBox.MaxLength = 32767;
            this.V_TextBox.Name = "V_TextBox";
            this.V_TextBox.PasswordChar = '\0';
            this.V_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.V_TextBox.SelectedText = "";
            this.V_TextBox.SelectionLength = 0;
            this.V_TextBox.SelectionStart = 0;
            this.V_TextBox.ShortcutsEnabled = true;
            this.V_TextBox.Size = new System.Drawing.Size(45, 23);
            this.V_TextBox.TabIndex = 14;
            this.V_TextBox.Text = "000";
            this.V_TextBox.UseSelectable = true;
            this.V_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.V_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.V_TextBox.TextChanged += new System.EventHandler(this.V_TextBox_TextChanged);
            // 
            // V_Label
            // 
            this.V_Label.AutoSize = true;
            this.V_Label.Location = new System.Drawing.Point(165, 160);
            this.V_Label.Name = "V_Label";
            this.V_Label.Size = new System.Drawing.Size(20, 19);
            this.V_Label.TabIndex = 13;
            this.V_Label.Text = "V:";
            // 
            // S_Label
            // 
            this.S_Label.AutoSize = true;
            this.S_Label.Location = new System.Drawing.Point(165, 130);
            this.S_Label.Name = "S_Label";
            this.S_Label.Size = new System.Drawing.Size(19, 19);
            this.S_Label.TabIndex = 12;
            this.S_Label.Text = "S:";
            // 
            // H_Label
            // 
            this.H_Label.AutoSize = true;
            this.H_Label.Location = new System.Drawing.Point(165, 100);
            this.H_Label.Name = "H_Label";
            this.H_Label.Size = new System.Drawing.Size(21, 19);
            this.H_Label.TabIndex = 11;
            this.H_Label.Text = "H:";
            // 
            // B_TextBox
            // 
            // 
            // 
            // 
            this.B_TextBox.CustomButton.Image = null;
            this.B_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.B_TextBox.CustomButton.Name = "";
            this.B_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.B_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.B_TextBox.CustomButton.TabIndex = 1;
            this.B_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.B_TextBox.CustomButton.UseSelectable = true;
            this.B_TextBox.CustomButton.Visible = false;
            this.B_TextBox.Lines = new string[] {
        "000"};
            this.B_TextBox.Location = new System.Drawing.Point(195, 70);
            this.B_TextBox.MaxLength = 32767;
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.PasswordChar = '\0';
            this.B_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.B_TextBox.SelectedText = "";
            this.B_TextBox.SelectionLength = 0;
            this.B_TextBox.SelectionStart = 0;
            this.B_TextBox.ShortcutsEnabled = true;
            this.B_TextBox.Size = new System.Drawing.Size(45, 23);
            this.B_TextBox.TabIndex = 10;
            this.B_TextBox.Text = "000";
            this.B_TextBox.UseSelectable = true;
            this.B_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.B_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // G_TextBox
            // 
            // 
            // 
            // 
            this.G_TextBox.CustomButton.Image = null;
            this.G_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.G_TextBox.CustomButton.Name = "";
            this.G_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.G_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.G_TextBox.CustomButton.TabIndex = 1;
            this.G_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.G_TextBox.CustomButton.UseSelectable = true;
            this.G_TextBox.CustomButton.Visible = false;
            this.G_TextBox.Lines = new string[] {
        "000"};
            this.G_TextBox.Location = new System.Drawing.Point(195, 40);
            this.G_TextBox.MaxLength = 32767;
            this.G_TextBox.Name = "G_TextBox";
            this.G_TextBox.PasswordChar = '\0';
            this.G_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.G_TextBox.SelectedText = "";
            this.G_TextBox.SelectionLength = 0;
            this.G_TextBox.SelectionStart = 0;
            this.G_TextBox.ShortcutsEnabled = true;
            this.G_TextBox.Size = new System.Drawing.Size(45, 23);
            this.G_TextBox.TabIndex = 9;
            this.G_TextBox.Text = "000";
            this.G_TextBox.UseSelectable = true;
            this.G_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.G_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // R_TextBox
            // 
            // 
            // 
            // 
            this.R_TextBox.CustomButton.Image = null;
            this.R_TextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.R_TextBox.CustomButton.Name = "";
            this.R_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.R_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.R_TextBox.CustomButton.TabIndex = 1;
            this.R_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.R_TextBox.CustomButton.UseSelectable = true;
            this.R_TextBox.CustomButton.Visible = false;
            this.R_TextBox.Lines = new string[] {
        "000"};
            this.R_TextBox.Location = new System.Drawing.Point(195, 10);
            this.R_TextBox.MaxLength = 32767;
            this.R_TextBox.Name = "R_TextBox";
            this.R_TextBox.PasswordChar = '\0';
            this.R_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.R_TextBox.SelectedText = "";
            this.R_TextBox.SelectionLength = 0;
            this.R_TextBox.SelectionStart = 0;
            this.R_TextBox.ShortcutsEnabled = true;
            this.R_TextBox.Size = new System.Drawing.Size(45, 23);
            this.R_TextBox.TabIndex = 8;
            this.R_TextBox.Text = "000";
            this.R_TextBox.UseSelectable = true;
            this.R_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.R_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // G_Label
            // 
            this.G_Label.AutoSize = true;
            this.G_Label.Location = new System.Drawing.Point(165, 40);
            this.G_Label.Name = "G_Label";
            this.G_Label.Size = new System.Drawing.Size(21, 19);
            this.G_Label.TabIndex = 7;
            this.G_Label.Text = "G:";
            // 
            // B_Label
            // 
            this.B_Label.AutoSize = true;
            this.B_Label.Location = new System.Drawing.Point(165, 70);
            this.B_Label.Name = "B_Label";
            this.B_Label.Size = new System.Drawing.Size(20, 19);
            this.B_Label.TabIndex = 6;
            this.B_Label.Text = "B:";
            // 
            // R_Label
            // 
            this.R_Label.AutoSize = true;
            this.R_Label.Location = new System.Drawing.Point(165, 10);
            this.R_Label.Name = "R_Label";
            this.R_Label.Size = new System.Drawing.Size(20, 19);
            this.R_Label.TabIndex = 5;
            this.R_Label.Text = "R:";
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
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(20, 160);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Яркость -";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(20, 130);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Яркость +";
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
            this.colorWheel1.ColorStep = 10;
            this.colorWheel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.colorWheel1.Location = new System.Drawing.Point(305, 3);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(286, 298);
            this.colorWheel1.TabIndex = 0;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
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
            this.tabPage4.Size = new System.Drawing.Size(594, 304);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ModeButton1);
            this.tabPage1.Controls.Add(this.colorWheel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(594, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Режимы";
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
            // colorWheel2
            // 
            this.colorWheel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel2.Location = new System.Drawing.Point(285, 3);
            this.colorWheel2.Name = "colorWheel2";
            this.colorWheel2.Size = new System.Drawing.Size(228, 224);
            this.colorWheel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.UpdateState_Tick);
            // 
            // Btn_RGBtoHSV
            // 
            this.Btn_RGBtoHSV.Location = new System.Drawing.Point(165, 220);
            this.Btn_RGBtoHSV.Name = "Btn_RGBtoHSV";
            this.Btn_RGBtoHSV.Size = new System.Drawing.Size(75, 23);
            this.Btn_RGBtoHSV.TabIndex = 29;
            this.Btn_RGBtoHSV.Text = "RGB->HSV";
            this.Btn_RGBtoHSV.UseSelectable = true;
            this.Btn_RGBtoHSV.Click += new System.EventHandler(this.Btn_RGBtoHSV_Click);
            // 
            // Btn_HSVtoRGB
            // 
            this.Btn_HSVtoRGB.Location = new System.Drawing.Point(165, 190);
            this.Btn_HSVtoRGB.Name = "Btn_HSVtoRGB";
            this.Btn_HSVtoRGB.Size = new System.Drawing.Size(75, 23);
            this.Btn_HSVtoRGB.TabIndex = 30;
            this.Btn_HSVtoRGB.Text = "HSV->RGB";
            this.Btn_HSVtoRGB.UseSelectable = true;
            this.Btn_HSVtoRGB.Click += new System.EventHandler(this.Btn_HSVtoRGB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 426);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Label_State);
            this.Name = "Form1";
            this.Text = "RGB Control";
            this.metroTabControl1.ResumeLayout(false);
            this.Page_StaticMode.ResumeLayout(false);
            this.Page_StaticMode.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Label_State;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Page_StaticMode;
        private MetroFramework.Controls.MetroButton SetButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
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
        private MetroFramework.Controls.MetroTextBox B_TextBox;
        private MetroFramework.Controls.MetroTextBox G_TextBox;
        private MetroFramework.Controls.MetroTextBox R_TextBox;
        private MetroFramework.Controls.MetroLabel G_Label;
        private MetroFramework.Controls.MetroLabel B_Label;
        private MetroFramework.Controls.MetroLabel R_Label;
        private MetroFramework.Controls.MetroLabel V_Label;
        private MetroFramework.Controls.MetroLabel S_Label;
        private MetroFramework.Controls.MetroLabel H_Label;
        private MetroFramework.Controls.MetroTextBox H_TextBox;
        private MetroFramework.Controls.MetroTextBox S_TextBox;
        private MetroFramework.Controls.MetroTextBox V_TextBox;
        public Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private MetroFramework.Controls.MetroButton Button_V_Plus;
        private MetroFramework.Controls.MetroButton Button_S_Plus;
        private MetroFramework.Controls.MetroButton Button_H_Plus;
        private MetroFramework.Controls.MetroButton Button_B_Plus;
        private MetroFramework.Controls.MetroButton Button_G_Plus;
        private MetroFramework.Controls.MetroButton Button_R_Plus;
        private MetroFramework.Controls.MetroButton Button_V_Minus;
        private MetroFramework.Controls.MetroButton Button_H_Minus;
        private MetroFramework.Controls.MetroButton Button_S_Minus;
        private MetroFramework.Controls.MetroButton Button_B_Minus;
        private MetroFramework.Controls.MetroButton Button_G_Minus;
        private MetroFramework.Controls.MetroButton Button_R_Minus;
        public System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton Btn_HSVtoRGB;
        private MetroFramework.Controls.MetroButton Btn_RGBtoHSV;
    }
}

