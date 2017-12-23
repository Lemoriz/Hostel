namespace Отель
{
    partial class Сотрудник
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SearchEmployeeUser = new System.Windows.Forms.TabPage();
            this.CardUser = new System.Windows.Forms.Button();
            this.dataGridViewSearchUser = new System.Windows.Forms.DataGridView();
            this.SearchUser = new System.Windows.Forms.Button();
            this.searchPositiob = new System.Windows.Forms.TextBox();
            this.searchPatronymic = new System.Windows.Forms.TextBox();
            this.searchFirstName = new System.Windows.Forms.TextBox();
            this.searchLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listEmployeeUser = new System.Windows.Forms.TabPage();
            this.dataGridViewListUser = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.SearchEmployeeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).BeginInit();
            this.listEmployeeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchEmployeeUser);
            this.tabControl1.Controls.Add(this.listEmployeeUser);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 464);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // SearchEmployeeUser
            // 
            this.SearchEmployeeUser.Controls.Add(this.CardUser);
            this.SearchEmployeeUser.Controls.Add(this.dataGridViewSearchUser);
            this.SearchEmployeeUser.Controls.Add(this.SearchUser);
            this.SearchEmployeeUser.Controls.Add(this.searchPositiob);
            this.SearchEmployeeUser.Controls.Add(this.searchPatronymic);
            this.SearchEmployeeUser.Controls.Add(this.searchFirstName);
            this.SearchEmployeeUser.Controls.Add(this.searchLastName);
            this.SearchEmployeeUser.Controls.Add(this.label4);
            this.SearchEmployeeUser.Controls.Add(this.label3);
            this.SearchEmployeeUser.Controls.Add(this.label2);
            this.SearchEmployeeUser.Controls.Add(this.label1);
            this.SearchEmployeeUser.Location = new System.Drawing.Point(4, 22);
            this.SearchEmployeeUser.Name = "SearchEmployeeUser";
            this.SearchEmployeeUser.Padding = new System.Windows.Forms.Padding(3);
            this.SearchEmployeeUser.Size = new System.Drawing.Size(593, 438);
            this.SearchEmployeeUser.TabIndex = 0;
            this.SearchEmployeeUser.Text = "Поиск сотрудника";
            this.SearchEmployeeUser.UseVisualStyleBackColor = true;
            this.SearchEmployeeUser.Click += new System.EventHandler(this.SearchEmployeeUser_Click);
            // 
            // CardUser
            // 
            this.CardUser.Location = new System.Drawing.Point(59, 404);
            this.CardUser.Name = "CardUser";
            this.CardUser.Size = new System.Drawing.Size(133, 23);
            this.CardUser.TabIndex = 29;
            this.CardUser.Text = "Карта сотрудника";
            this.CardUser.UseVisualStyleBackColor = true;
            this.CardUser.Click += new System.EventHandler(this.CardUser_Click);
            // 
            // dataGridViewSearchUser
            // 
            this.dataGridViewSearchUser.AllowUserToAddRows = false;
            this.dataGridViewSearchUser.AllowUserToDeleteRows = false;
            this.dataGridViewSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchUser.Location = new System.Drawing.Point(6, 176);
            this.dataGridViewSearchUser.Name = "dataGridViewSearchUser";
            this.dataGridViewSearchUser.ReadOnly = true;
            this.dataGridViewSearchUser.Size = new System.Drawing.Size(582, 222);
            this.dataGridViewSearchUser.TabIndex = 28;
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(59, 135);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(133, 23);
            this.SearchUser.TabIndex = 27;
            this.SearchUser.Text = "Поиск";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // searchPositiob
            // 
            this.searchPositiob.Location = new System.Drawing.Point(130, 95);
            this.searchPositiob.Name = "searchPositiob";
            this.searchPositiob.Size = new System.Drawing.Size(144, 20);
            this.searchPositiob.TabIndex = 26;
            // 
            // searchPatronymic
            // 
            this.searchPatronymic.Location = new System.Drawing.Point(130, 69);
            this.searchPatronymic.Name = "searchPatronymic";
            this.searchPatronymic.Size = new System.Drawing.Size(144, 20);
            this.searchPatronymic.TabIndex = 25;
            // 
            // searchFirstName
            // 
            this.searchFirstName.Location = new System.Drawing.Point(130, 41);
            this.searchFirstName.Name = "searchFirstName";
            this.searchFirstName.Size = new System.Drawing.Size(144, 20);
            this.searchFirstName.TabIndex = 24;
            // 
            // searchLastName
            // 
            this.searchLastName.Location = new System.Drawing.Point(130, 14);
            this.searchLastName.Name = "searchLastName";
            this.searchLastName.Size = new System.Drawing.Size(144, 20);
            this.searchLastName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Введите должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Введите отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите фамилию";
            // 
            // listEmployeeUser
            // 
            this.listEmployeeUser.Controls.Add(this.dataGridViewListUser);
            this.listEmployeeUser.Location = new System.Drawing.Point(4, 22);
            this.listEmployeeUser.Name = "listEmployeeUser";
            this.listEmployeeUser.Padding = new System.Windows.Forms.Padding(3);
            this.listEmployeeUser.Size = new System.Drawing.Size(593, 438);
            this.listEmployeeUser.TabIndex = 1;
            this.listEmployeeUser.Text = "Список";
            this.listEmployeeUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListUser
            // 
            this.dataGridViewListUser.AllowUserToAddRows = false;
            this.dataGridViewListUser.AllowUserToDeleteRows = false;
            this.dataGridViewListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUser.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewListUser.Name = "dataGridViewListUser";
            this.dataGridViewListUser.ReadOnly = true;
            this.dataGridViewListUser.Size = new System.Drawing.Size(580, 425);
            this.dataGridViewListUser.TabIndex = 0;
            this.dataGridViewListUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListUser_CellContentClick);
            // 
            // Сотрудник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 489);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(642, 528);
            this.MinimumSize = new System.Drawing.Size(642, 528);
            this.Name = "Сотрудник";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Сотрудник_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.SearchEmployeeUser.ResumeLayout(false);
            this.SearchEmployeeUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).EndInit();
            this.listEmployeeUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchEmployeeUser;
        private System.Windows.Forms.TabPage listEmployeeUser;
        private System.Windows.Forms.DataGridView dataGridViewListUser;
        private System.Windows.Forms.Button CardUser;
        private System.Windows.Forms.DataGridView dataGridViewSearchUser;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.TextBox searchPositiob;
        private System.Windows.Forms.TextBox searchPatronymic;
        private System.Windows.Forms.TextBox searchFirstName;
        private System.Windows.Forms.TextBox searchLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}