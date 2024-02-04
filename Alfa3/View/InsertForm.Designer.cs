namespace Alfa3.View
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DatePickerLabel = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DeploymentCheckBox = new System.Windows.Forms.CheckBox();
            this.AddVojak = new System.Windows.Forms.Button();
            this.Služby = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.RoleBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBoxUtvar = new System.Windows.Forms.TextBox();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.UtvarBtn = new System.Windows.Forms.Button();
            this.SpecializaceBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameSpecializaceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.decsBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.SoldierCombo = new System.Windows.Forms.ComboBox();
            this.UtvarCombo = new System.Windows.Forms.ComboBox();
            this.RoleCombo = new System.Windows.Forms.ComboBox();
            this.FromPick = new System.Windows.Forms.MonthCalendar();
            this.UntilPick = new System.Windows.Forms.MonthCalendar();
            this.SluzbaBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.KZPVojakBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addZkouskaBtn = new System.Windows.Forms.Button();
            this.whenPick = new System.Windows.Forms.MonthCalendar();
            this.specializaceCombo = new System.Windows.Forms.ComboBox();
            this.VojakCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.kdeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.Služby.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(72, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Jmeno";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(35, 53);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(132, 26);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(35, 141);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(132, 26);
            this.SurnameBox.TabIndex = 3;
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(65, 118);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(64, 20);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Prijmeni";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(214, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // DatePickerLabel
            // 
            this.DatePickerLabel.AutoSize = true;
            this.DatePickerLabel.Location = new System.Drawing.Point(224, 25);
            this.DatePickerLabel.Name = "DatePickerLabel";
            this.DatePickerLabel.Size = new System.Drawing.Size(122, 20);
            this.DatePickerLabel.TabIndex = 5;
            this.DatePickerLabel.Text = "Datum narození";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(35, 225);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(132, 26);
            this.HeightBox.TabIndex = 7;
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(77, 196);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(52, 20);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Výška";
            // 
            // DeploymentCheckBox
            // 
            this.DeploymentCheckBox.AutoSize = true;
            this.DeploymentCheckBox.Location = new System.Drawing.Point(49, 296);
            this.DeploymentCheckBox.Name = "DeploymentCheckBox";
            this.DeploymentCheckBox.Size = new System.Drawing.Size(94, 24);
            this.DeploymentCheckBox.TabIndex = 8;
            this.DeploymentCheckBox.Text = "Nasazení";
            this.DeploymentCheckBox.UseVisualStyleBackColor = true;
            this.DeploymentCheckBox.CheckedChanged += new System.EventHandler(this.DeploymentCheckBox_CheckedChanged);
            // 
            // AddVojak
            // 
            this.AddVojak.Location = new System.Drawing.Point(81, 377);
            this.AddVojak.Name = "AddVojak";
            this.AddVojak.Size = new System.Drawing.Size(133, 57);
            this.AddVojak.TabIndex = 9;
            this.AddVojak.Text = "Přidat vojáka";
            this.AddVojak.UseVisualStyleBackColor = true;
            this.AddVojak.Click += new System.EventHandler(this.AddVojak_Click);
            // 
            // Služby
            // 
            this.Služby.Controls.Add(this.tabPage1);
            this.Služby.Controls.Add(this.tabPage2);
            this.Služby.Controls.Add(this.tabPage3);
            this.Služby.Controls.Add(this.tabPage4);
            this.Služby.Controls.Add(this.tabPage5);
            this.Služby.Controls.Add(this.tabPage6);
            this.Služby.Location = new System.Drawing.Point(1, 2);
            this.Služby.Name = "Služby";
            this.Služby.SelectedIndex = 0;
            this.Služby.Size = new System.Drawing.Size(782, 498);
            this.Služby.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.KZPVojakBtn);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.AddVojak);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.DeploymentCheckBox);
            this.tabPage1.Controls.Add(this.NameBox);
            this.tabPage1.Controls.Add(this.HeightBox);
            this.tabPage1.Controls.Add(this.SurnameLabel);
            this.tabPage1.Controls.Add(this.HeightLabel);
            this.tabPage1.Controls.Add(this.SurnameBox);
            this.tabPage1.Controls.Add(this.DatePickerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Voják";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RoleBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RoleBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazev role";
            // 
            // RoleBox
            // 
            this.RoleBox.Location = new System.Drawing.Point(263, 47);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(132, 26);
            this.RoleBox.TabIndex = 3;
            // 
            // RoleBtn
            // 
            this.RoleBtn.Location = new System.Drawing.Point(263, 202);
            this.RoleBtn.Name = "RoleBtn";
            this.RoleBtn.Size = new System.Drawing.Size(132, 57);
            this.RoleBtn.TabIndex = 10;
            this.RoleBtn.Text = "Přidat roli";
            this.RoleBtn.UseVisualStyleBackColor = true;
            this.RoleBtn.Click += new System.EventHandler(this.RoleBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UtvarBtn);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.nameBoxUtvar);
            this.tabPage3.Controls.Add(this.placeBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.typeBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Útvar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SpecializaceBtn);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.nameSpecializaceBox);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.decsBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Specializace";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazev útvaru";
            // 
            // nameBoxUtvar
            // 
            this.nameBoxUtvar.Location = new System.Drawing.Point(261, 40);
            this.nameBoxUtvar.Name = "nameBoxUtvar";
            this.nameBoxUtvar.Size = new System.Drawing.Size(132, 26);
            this.nameBoxUtvar.TabIndex = 9;
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(261, 212);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(132, 26);
            this.placeBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zamereni útvaru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Působiště";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(261, 128);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(132, 26);
            this.typeBox.TabIndex = 11;
            // 
            // UtvarBtn
            // 
            this.UtvarBtn.Location = new System.Drawing.Point(260, 308);
            this.UtvarBtn.Name = "UtvarBtn";
            this.UtvarBtn.Size = new System.Drawing.Size(133, 57);
            this.UtvarBtn.TabIndex = 14;
            this.UtvarBtn.Text = "Přidat útvar";
            this.UtvarBtn.UseVisualStyleBackColor = true;
            this.UtvarBtn.Click += new System.EventHandler(this.UtvarBtn_Click);
            // 
            // SpecializaceBtn
            // 
            this.SpecializaceBtn.Location = new System.Drawing.Point(296, 349);
            this.SpecializaceBtn.Name = "SpecializaceBtn";
            this.SpecializaceBtn.Size = new System.Drawing.Size(133, 57);
            this.SpecializaceBtn.TabIndex = 21;
            this.SpecializaceBtn.Text = "Přidat specializaci";
            this.SpecializaceBtn.UseVisualStyleBackColor = true;
            this.SpecializaceBtn.Click += new System.EventHandler(this.SpecializaceBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nazev specializace";
            // 
            // nameSpecializaceBox
            // 
            this.nameSpecializaceBox.Location = new System.Drawing.Point(297, 81);
            this.nameSpecializaceBox.Name = "nameSpecializaceBox";
            this.nameSpecializaceBox.Size = new System.Drawing.Size(132, 26);
            this.nameSpecializaceBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Popis ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // decsBox
            // 
            this.decsBox.Location = new System.Drawing.Point(211, 169);
            this.decsBox.Multiline = true;
            this.decsBox.Name = "decsBox";
            this.decsBox.Size = new System.Drawing.Size(301, 89);
            this.decsBox.TabIndex = 18;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.SluzbaBtn);
            this.tabPage5.Controls.Add(this.UntilPick);
            this.tabPage5.Controls.Add(this.FromPick);
            this.tabPage5.Controls.Add(this.RoleCombo);
            this.tabPage5.Controls.Add(this.UtvarCombo);
            this.tabPage5.Controls.Add(this.SoldierCombo);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(774, 465);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Služby";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.resultBox);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.kdeBox);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.addZkouskaBtn);
            this.tabPage6.Controls.Add(this.whenPick);
            this.tabPage6.Controls.Add(this.specializaceCombo);
            this.tabPage6.Controls.Add(this.VojakCombo);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(774, 465);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Zkouska";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // SoldierCombo
            // 
            this.SoldierCombo.FormattingEnabled = true;
            this.SoldierCombo.Location = new System.Drawing.Point(7, 42);
            this.SoldierCombo.Name = "SoldierCombo";
            this.SoldierCombo.Size = new System.Drawing.Size(166, 28);
            this.SoldierCombo.TabIndex = 0;
            this.SoldierCombo.SelectedIndexChanged += new System.EventHandler(this.SoldierCombo_SelectedIndexChanged);
            // 
            // UtvarCombo
            // 
            this.UtvarCombo.FormattingEnabled = true;
            this.UtvarCombo.Location = new System.Drawing.Point(7, 119);
            this.UtvarCombo.Name = "UtvarCombo";
            this.UtvarCombo.Size = new System.Drawing.Size(166, 28);
            this.UtvarCombo.TabIndex = 1;
            this.UtvarCombo.SelectedIndexChanged += new System.EventHandler(this.UtvarCombo_SelectedIndexChanged);
            // 
            // RoleCombo
            // 
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.Location = new System.Drawing.Point(7, 204);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(166, 28);
            this.RoleCombo.TabIndex = 2;
            this.RoleCombo.SelectedIndexChanged += new System.EventHandler(this.RoleCombo_SelectedIndexChanged);
            // 
            // FromPick
            // 
            this.FromPick.Location = new System.Drawing.Point(249, 42);
            this.FromPick.Name = "FromPick";
            this.FromPick.TabIndex = 3;
            this.FromPick.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.FromPick_DateChanged);
            // 
            // UntilPick
            // 
            this.UntilPick.Location = new System.Drawing.Point(517, 42);
            this.UntilPick.Name = "UntilPick";
            this.UntilPick.TabIndex = 4;
            this.UntilPick.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.UntilPick_DateChanged);
            // 
            // SluzbaBtn
            // 
            this.SluzbaBtn.Location = new System.Drawing.Point(367, 341);
            this.SluzbaBtn.Name = "SluzbaBtn";
            this.SluzbaBtn.Size = new System.Drawing.Size(180, 62);
            this.SluzbaBtn.TabIndex = 5;
            this.SluzbaBtn.Text = "Přidat službu";
            this.SluzbaBtn.UseVisualStyleBackColor = true;
            this.SluzbaBtn.Click += new System.EventHandler(this.SluzbaBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Do kdy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Od kdy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Útvar(KDE?)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Vojak(KDO?)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // KZPVojakBtn
            // 
            this.KZPVojakBtn.Location = new System.Drawing.Point(322, 377);
            this.KZPVojakBtn.Name = "KZPVojakBtn";
            this.KZPVojakBtn.Size = new System.Drawing.Size(184, 57);
            this.KZPVojakBtn.TabIndex = 10;
            this.KZPVojakBtn.Text = "Přidat vojáka ,prošel právě KZP";
            this.KZPVojakBtn.UseVisualStyleBackColor = true;
            this.KZPVojakBtn.Click += new System.EventHandler(this.KZPVojakBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Vojak(KDO?)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Zkouška(CO?)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(336, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Kdy:";
            // 
            // addZkouskaBtn
            // 
            this.addZkouskaBtn.Location = new System.Drawing.Point(417, 365);
            this.addZkouskaBtn.Name = "addZkouskaBtn";
            this.addZkouskaBtn.Size = new System.Drawing.Size(180, 62);
            this.addZkouskaBtn.TabIndex = 16;
            this.addZkouskaBtn.Text = "Přidat zkoušku";
            this.addZkouskaBtn.UseVisualStyleBackColor = true;
            this.addZkouskaBtn.Click += new System.EventHandler(this.addZkouskaBtn_Click);
            // 
            // whenPick
            // 
            this.whenPick.Location = new System.Drawing.Point(299, 66);
            this.whenPick.Name = "whenPick";
            this.whenPick.TabIndex = 14;
            // 
            // specializaceCombo
            // 
            this.specializaceCombo.FormattingEnabled = true;
            this.specializaceCombo.Location = new System.Drawing.Point(57, 143);
            this.specializaceCombo.Name = "specializaceCombo";
            this.specializaceCombo.Size = new System.Drawing.Size(166, 28);
            this.specializaceCombo.TabIndex = 12;
            // 
            // VojakCombo
            // 
            this.VojakCombo.FormattingEnabled = true;
            this.VojakCombo.Location = new System.Drawing.Point(57, 66);
            this.VojakCombo.Name = "VojakCombo";
            this.VojakCombo.Size = new System.Drawing.Size(166, 28);
            this.VojakCombo.TabIndex = 11;
            this.VojakCombo.SelectedIndexChanged += new System.EventHandler(this.VojakCombo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Kde?";
            // 
            // kdeBox
            // 
            this.kdeBox.Location = new System.Drawing.Point(72, 229);
            this.kdeBox.Name = "kdeBox";
            this.kdeBox.Size = new System.Drawing.Size(132, 26);
            this.kdeBox.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 278);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(284, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Výsledek zkoušky ideálně v procentech";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(72, 301);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(132, 26);
            this.resultBox.TabIndex = 25;
            this.resultBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 497);
            this.Controls.Add(this.Služby);
            this.Name = "InsertForm";
            this.Text = "Vložení";
            this.Služby.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label DatePickerLabel;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.CheckBox DeploymentCheckBox;
        private System.Windows.Forms.Button AddVojak;
        private System.Windows.Forms.TabControl Služby;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RoleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoleBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button UtvarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBoxUtvar;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button SpecializaceBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameSpecializaceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox decsBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SluzbaBtn;
        private System.Windows.Forms.MonthCalendar UntilPick;
        private System.Windows.Forms.MonthCalendar FromPick;
        private System.Windows.Forms.ComboBox RoleCombo;
        private System.Windows.Forms.ComboBox UtvarCombo;
        private System.Windows.Forms.ComboBox SoldierCombo;
        private System.Windows.Forms.Button KZPVojakBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button addZkouskaBtn;
        private System.Windows.Forms.MonthCalendar whenPick;
        private System.Windows.Forms.ComboBox specializaceCombo;
        private System.Windows.Forms.ComboBox VojakCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kdeBox;
    }
}