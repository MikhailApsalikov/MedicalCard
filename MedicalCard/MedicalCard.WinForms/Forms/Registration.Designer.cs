namespace MedicalCard.WinForms.Forms
{
	partial class Registration
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
			this.roleComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.patientPanel = new System.Windows.Forms.Panel();
			this.doctorPanel = new System.Windows.Forms.Panel();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.middleNameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.GenderComboBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.emailTextBox1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.phoneTextBox2 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// roleComboBox
			// 
			this.roleComboBox.AllowDrop = true;
			this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roleComboBox.FormattingEnabled = true;
			this.roleComboBox.Items.AddRange(new object[] {
            "Пациент",
            "Врач"});
			this.roleComboBox.Location = new System.Drawing.Point(87, 91);
			this.roleComboBox.Name = "roleComboBox";
			this.roleComboBox.Size = new System.Drawing.Size(226, 21);
			this.roleComboBox.TabIndex = 7;
			this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Роль:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(87, 62);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(226, 20);
			this.passwordTextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Пароль:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(253, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пожалуста заполните регистрационные данные";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Location = new System.Drawing.Point(87, 34);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(226, 20);
			this.loginTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин:";
			// 
			// patientPanel
			// 
			this.patientPanel.Location = new System.Drawing.Point(0, 367);
			this.patientPanel.Name = "patientPanel";
			this.patientPanel.Size = new System.Drawing.Size(331, 82);
			this.patientPanel.TabIndex = 0;
			// 
			// doctorPanel
			// 
			this.doctorPanel.Location = new System.Drawing.Point(66, 469);
			this.doctorPanel.Name = "doctorPanel";
			this.doctorPanel.Size = new System.Drawing.Size(200, 100);
			this.doctorPanel.TabIndex = 8;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(87, 118);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(226, 20);
			this.lastNameTextBox.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Фамилия:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(87, 144);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(226, 20);
			this.firstNameTextBox.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Имя:";
			// 
			// middleNameTextBox
			// 
			this.middleNameTextBox.Location = new System.Drawing.Point(87, 170);
			this.middleNameTextBox.Name = "middleNameTextBox";
			this.middleNameTextBox.Size = new System.Drawing.Size(226, 20);
			this.middleNameTextBox.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Отчество:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 199);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Дата рождения:";
			// 
			// birthDateTimePicker
			// 
			this.birthDateTimePicker.Location = new System.Drawing.Point(113, 196);
			this.birthDateTimePicker.Name = "birthDateTimePicker";
			this.birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.birthDateTimePicker.TabIndex = 16;
			// 
			// GenderComboBox
			// 
			this.GenderComboBox.AllowDrop = true;
			this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GenderComboBox.FormattingEnabled = true;
			this.GenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.GenderComboBox.Location = new System.Drawing.Point(87, 222);
			this.GenderComboBox.Name = "GenderComboBox";
			this.GenderComboBox.Size = new System.Drawing.Size(226, 21);
			this.GenderComboBox.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 225);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Пол:";
			// 
			// emailTextBox1
			// 
			this.emailTextBox1.Location = new System.Drawing.Point(87, 301);
			this.emailTextBox1.Name = "emailTextBox1";
			this.emailTextBox1.Size = new System.Drawing.Size(226, 20);
			this.emailTextBox1.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 304);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "E-mail:";
			// 
			// phoneTextBox2
			// 
			this.phoneTextBox2.Location = new System.Drawing.Point(87, 275);
			this.phoneTextBox2.Name = "phoneTextBox2";
			this.phoneTextBox2.Size = new System.Drawing.Size(226, 20);
			this.phoneTextBox2.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 278);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Телефон:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(87, 249);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(226, 20);
			this.addressTextBox.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 252);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 13);
			this.label12.TabIndex = 19;
			this.label12.Text = "Адрес:";
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 604);
			this.Controls.Add(this.emailTextBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.phoneTextBox2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.GenderComboBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.birthDateTimePicker);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.middleNameTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.doctorPanel);
			this.Controls.Add(this.roleComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.patientPanel);
			this.Name = "Registration";
			this.Text = "Registration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel patientPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox roleComboBox;
		private System.Windows.Forms.Panel doctorPanel;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox middleNameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker birthDateTimePicker;
		private System.Windows.Forms.ComboBox GenderComboBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox emailTextBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox phoneTextBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label12;
	}
}