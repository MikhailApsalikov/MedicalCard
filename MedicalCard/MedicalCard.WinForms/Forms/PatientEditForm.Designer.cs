﻿namespace MedicalCard.WinForms.Forms
{
	partial class PatientEditForm
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
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.GenderComboBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.middleNameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.positionTextBox = new System.Windows.Forms.TextBox();
			this.disabliltyDocumentTextBox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.disabilityComboBox = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.insurancePolicyTextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.snilsTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(132, 26);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(206, 20);
			this.passwordTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Пароль:";
			// 
			// passwordTextBox2
			// 
			this.passwordTextBox2.Location = new System.Drawing.Point(132, 58);
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = '*';
			this.passwordTextBox2.Size = new System.Drawing.Size(206, 20);
			this.passwordTextBox2.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Повторите пароль:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.passwordTextBox);
			this.groupBox1.Controls.Add(this.passwordTextBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(447, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 119);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Смена пароля";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(229, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Сменить пароль";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(88, 202);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(328, 20);
			this.emailTextBox.TabIndex = 40;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 205);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 39;
			this.label10.Text = "E-mail:";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(88, 176);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(328, 20);
			this.phoneTextBox.TabIndex = 38;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 179);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 13);
			this.label11.TabIndex = 37;
			this.label11.Text = "Телефон:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(88, 150);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(328, 20);
			this.addressTextBox.TabIndex = 36;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 153);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 13);
			this.label12.TabIndex = 35;
			this.label12.Text = "Адрес:";
			// 
			// GenderComboBox
			// 
			this.GenderComboBox.AllowDrop = true;
			this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GenderComboBox.FormattingEnabled = true;
			this.GenderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.GenderComboBox.Location = new System.Drawing.Point(88, 123);
			this.GenderComboBox.Name = "GenderComboBox";
			this.GenderComboBox.Size = new System.Drawing.Size(328, 21);
			this.GenderComboBox.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 33;
			this.label9.Text = "Пол:";
			// 
			// birthDateTimePicker
			// 
			this.birthDateTimePicker.Location = new System.Drawing.Point(162, 97);
			this.birthDateTimePicker.Name = "birthDateTimePicker";
			this.birthDateTimePicker.Size = new System.Drawing.Size(254, 20);
			this.birthDateTimePicker.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 13);
			this.label8.TabIndex = 31;
			this.label8.Text = "Дата рождения:";
			// 
			// middleNameTextBox
			// 
			this.middleNameTextBox.Location = new System.Drawing.Point(88, 71);
			this.middleNameTextBox.Name = "middleNameTextBox";
			this.middleNameTextBox.Size = new System.Drawing.Size(328, 20);
			this.middleNameTextBox.TabIndex = 30;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 29;
			this.label7.Text = "Отчество:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(88, 45);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(328, 20);
			this.firstNameTextBox.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Имя:";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(88, 19);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(328, 20);
			this.lastNameTextBox.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Фамилия:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.positionTextBox);
			this.groupBox2.Controls.Add(this.disabliltyDocumentTextBox);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.disabilityComboBox);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.insurancePolicyTextBox);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.snilsTextBox);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.lastNameTextBox);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.birthDateTimePicker);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.middleNameTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.phoneTextBox);
			this.groupBox2.Controls.Add(this.GenderComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.firstNameTextBox);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.addressTextBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(429, 434);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Редактирование данных";
			// 
			// positionTextBox
			// 
			this.positionTextBox.Location = new System.Drawing.Point(136, 399);
			this.positionTextBox.Name = "positionTextBox";
			this.positionTextBox.Size = new System.Drawing.Size(280, 20);
			this.positionTextBox.TabIndex = 43;
			// 
			// disabliltyDocumentTextBox
			// 
			this.disabliltyDocumentTextBox.Location = new System.Drawing.Point(16, 325);
			this.disabliltyDocumentTextBox.Multiline = true;
			this.disabliltyDocumentTextBox.Name = "disabliltyDocumentTextBox";
			this.disabliltyDocumentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.disabliltyDocumentTextBox.Size = new System.Drawing.Size(400, 65);
			this.disabliltyDocumentTextBox.TabIndex = 50;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(13, 402);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(117, 13);
			this.label17.TabIndex = 41;
			this.label17.Text = "Место работы/учебы:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(13, 309);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(150, 13);
			this.label16.TabIndex = 49;
			this.label16.Text = "Документ об инвалидности:";
			// 
			// disabilityComboBox
			// 
			this.disabilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.disabilityComboBox.FormattingEnabled = true;
			this.disabilityComboBox.Items.AddRange(new object[] {
            "Нет",
            "3-ей группы",
            "2-ой группы",
            "1-ой группы"});
			this.disabilityComboBox.Location = new System.Drawing.Point(102, 279);
			this.disabilityComboBox.Name = "disabilityComboBox";
			this.disabilityComboBox.Size = new System.Drawing.Size(314, 21);
			this.disabilityComboBox.TabIndex = 48;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(13, 284);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 13);
			this.label15.TabIndex = 47;
			this.label15.Text = "Инвалидность:";
			// 
			// insurancePolicyTextBox
			// 
			this.insurancePolicyTextBox.Location = new System.Drawing.Point(162, 253);
			this.insurancePolicyTextBox.Name = "insurancePolicyTextBox";
			this.insurancePolicyTextBox.Size = new System.Drawing.Size(254, 20);
			this.insurancePolicyTextBox.TabIndex = 46;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(13, 256);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(143, 13);
			this.label14.TabIndex = 45;
			this.label14.Text = "Номер страхового полиса:";
			// 
			// snilsTextBox
			// 
			this.snilsTextBox.Location = new System.Drawing.Point(88, 227);
			this.snilsTextBox.Name = "snilsTextBox";
			this.snilsTextBox.Size = new System.Drawing.Size(328, 20);
			this.snilsTextBox.TabIndex = 44;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(13, 230);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 13);
			this.label13.TabIndex = 42;
			this.label13.Text = "СНИЛС:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(716, 419);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 42;
			this.button2.Text = "Сохранить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(635, 419);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 43;
			this.button3.Text = "Отмена";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.OnClickCancelButton);
			// 
			// PatientEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 454);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "PatientEditForm";
			this.Text = "AccountDataEdit";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox GenderComboBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker birthDateTimePicker;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox middleNameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox positionTextBox;
		private System.Windows.Forms.TextBox disabliltyDocumentTextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox disabilityComboBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox insurancePolicyTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox snilsTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}