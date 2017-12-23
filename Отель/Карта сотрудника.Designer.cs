namespace Отель
{
    partial class Карта_сотрудника
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
            this.button1 = new System.Windows.Forms.Button();
            this.seriesWorkBook = new System.Windows.Forms.MaskedTextBox();
            this.insurance = new System.Windows.Forms.MaskedTextBox();
            this.series = new System.Windows.Forms.MaskedTextBox();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.lastName = new System.Windows.Forms.MaskedTextBox();
            this.nuberWorkBook = new System.Windows.Forms.MaskedTextBox();
            this.dateIssue = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.insertionWorkBook = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.famileStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.MaskedTextBox();
            this.midlleName = new System.Windows.Forms.MaskedTextBox();
            this.position = new System.Windows.Forms.MaskedTextBox();
            this.citizenShip = new System.Windows.Forms.MaskedTextBox();
            this.homeAddress = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seriesWorkBook
            // 
            this.seriesWorkBook.Location = new System.Drawing.Point(67, 332);
            this.seriesWorkBook.Mask = "0000";
            this.seriesWorkBook.Name = "seriesWorkBook";
            this.seriesWorkBook.Size = new System.Drawing.Size(52, 20);
            this.seriesWorkBook.TabIndex = 124;
            // 
            // insurance
            // 
            this.insurance.Location = new System.Drawing.Point(122, 203);
            this.insurance.Mask = "000-000-000-00";
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(129, 20);
            this.insurance.TabIndex = 123;
            // 
            // series
            // 
            this.series.Location = new System.Drawing.Point(240, 127);
            this.series.Mask = "0000";
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(55, 20);
            this.series.TabIndex = 122;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(240, 156);
            this.number.Mask = "000000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(55, 20);
            this.number.TabIndex = 121;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(136, 6);
            this.lastName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLL";
            this.lastName.Name = "lastName";
            this.lastName.PromptChar = '.';
            this.lastName.Size = new System.Drawing.Size(144, 20);
            this.lastName.TabIndex = 120;
            this.lastName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.lastName_MaskInputRejected);
            // 
            // nuberWorkBook
            // 
            this.nuberWorkBook.Location = new System.Drawing.Point(202, 335);
            this.nuberWorkBook.Mask = "000000";
            this.nuberWorkBook.Name = "nuberWorkBook";
            this.nuberWorkBook.Size = new System.Drawing.Size(100, 20);
            this.nuberWorkBook.TabIndex = 119;
            this.nuberWorkBook.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.nuberWorkBook.ValidatingType = typeof(int);
            // 
            // dateIssue
            // 
            this.dateIssue.Location = new System.Drawing.Point(321, 152);
            this.dateIssue.MaxDate = new System.DateTime(2050, 12, 23, 0, 0, 0, 0);
            this.dateIssue.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.dateIssue.Name = "dateIssue";
            this.dateIssue.Size = new System.Drawing.Size(193, 20);
            this.dateIssue.TabIndex = 118;
            this.dateIssue.Value = new System.DateTime(2017, 12, 23, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 371);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 116;
            this.label21.Text = "Гражданство";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(308, 338);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 114;
            this.label20.Text = "Вкладыш";
            // 
            // insertionWorkBook
            // 
            this.insertionWorkBook.Location = new System.Drawing.Point(368, 338);
            this.insertionWorkBook.Name = "insertionWorkBook";
            this.insertionWorkBook.Size = new System.Drawing.Size(108, 20);
            this.insertionWorkBook.TabIndex = 113;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 112;
            this.label18.Text = "Серия";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(155, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 111;
            this.label19.Text = "Номер";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 110;
            this.label17.Text = "Трудовая книжка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 13);
            this.label16.TabIndex = 108;
            this.label16.Text = "Фактический адрес проживания";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 107;
            this.label15.Text = "Страховой номер";
            // 
            // famileStatus
            // 
            this.famileStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.famileStatus.FormattingEnabled = true;
            this.famileStatus.Items.AddRange(new object[] {
            "В браке",
            "Не в браке"});
            this.famileStatus.Location = new System.Drawing.Point(144, 229);
            this.famileStatus.Name = "famileStatus";
            this.famileStatus.Size = new System.Drawing.Size(121, 21);
            this.famileStatus.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 105;
            this.label14.Text = "Семейное положение";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.Items.AddRange(new object[] {
            "Мужкой",
            "Женский"});
            this.sex.Location = new System.Drawing.Point(54, 176);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(121, 21);
            this.sex.TabIndex = 104;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Пол";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Серия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Дата выдачи";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Введите паспортные данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Введите должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Введите отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Введите имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Введите фамилию";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 125;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(136, 36);
            this.firstName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLL";
            this.firstName.Name = "firstName";
            this.firstName.PromptChar = '.';
            this.firstName.Size = new System.Drawing.Size(144, 20);
            this.firstName.TabIndex = 126;
            // 
            // midlleName
            // 
            this.midlleName.Location = new System.Drawing.Point(136, 62);
            this.midlleName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLL";
            this.midlleName.Name = "midlleName";
            this.midlleName.PromptChar = '.';
            this.midlleName.Size = new System.Drawing.Size(144, 20);
            this.midlleName.TabIndex = 127;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(136, 90);
            this.position.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLL";
            this.position.Name = "position";
            this.position.PromptChar = '.';
            this.position.Size = new System.Drawing.Size(144, 20);
            this.position.TabIndex = 128;
            // 
            // citizenShip
            // 
            this.citizenShip.Location = new System.Drawing.Point(100, 364);
            this.citizenShip.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLL";
            this.citizenShip.Name = "citizenShip";
            this.citizenShip.PromptChar = '.';
            this.citizenShip.Size = new System.Drawing.Size(55, 20);
            this.citizenShip.TabIndex = 129;
            // 
            // homeAddress
            // 
            this.homeAddress.Location = new System.Drawing.Point(24, 278);
            this.homeAddress.Mask = "гор. LLLLLLLLLLLLL, ул. LLLLLLLLLLLLL, дом. AAAAA, кв. 00000";
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.Size = new System.Drawing.Size(324, 20);
            this.homeAddress.TabIndex = 130;
            // 
            // Карта_сотрудника
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.homeAddress);
            this.Controls.Add(this.citizenShip);
            this.Controls.Add(this.position);
            this.Controls.Add(this.midlleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seriesWorkBook);
            this.Controls.Add(this.insurance);
            this.Controls.Add(this.series);
            this.Controls.Add(this.number);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.nuberWorkBook);
            this.Controls.Add(this.dateIssue);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.insertionWorkBook);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.famileStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(542, 450);
            this.MinimumSize = new System.Drawing.Size(542, 450);
            this.Name = "Карта_сотрудника";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта сотрудника";
            this.Load += new System.EventHandler(this.Карта_сотрудника_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox seriesWorkBook;
        private System.Windows.Forms.MaskedTextBox insurance;
        private System.Windows.Forms.MaskedTextBox series;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.MaskedTextBox nuberWorkBook;
        private System.Windows.Forms.DateTimePicker dateIssue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox insertionWorkBook;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox famileStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox lastName;
        private System.Windows.Forms.MaskedTextBox firstName;
        private System.Windows.Forms.MaskedTextBox midlleName;
        private System.Windows.Forms.MaskedTextBox position;
        private System.Windows.Forms.MaskedTextBox citizenShip;
        private System.Windows.Forms.MaskedTextBox homeAddress;
    }
}