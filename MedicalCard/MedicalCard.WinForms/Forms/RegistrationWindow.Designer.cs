namespace MedicalCard.WinForms.Forms
{
	partial class RegistrationWindow
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
			this.doctorPanel = new System.Windows.Forms.Panel();
			this.removePhotoButton = new System.Windows.Forms.Button();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.photoPickButton = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.positionComboBox = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
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
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.patientPanel.SuspendLayout();
			this.doctorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
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
			this.passwordTextBox.PasswordChar = '*';
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
			this.patientPanel.Controls.Add(this.positionTextBox);
			this.patientPanel.Controls.Add(this.disabliltyDocumentTextBox);
			this.patientPanel.Controls.Add(this.label17);
			this.patientPanel.Controls.Add(this.label16);
			this.patientPanel.Controls.Add(this.disabilityComboBox);
			this.patientPanel.Controls.Add(this.label15);
			this.patientPanel.Controls.Add(this.insurancePolicyTextBox);
			this.patientPanel.Controls.Add(this.label14);
			this.patientPanel.Controls.Add(this.snilsTextBox);
			this.patientPanel.Controls.Add(this.label13);
			this.patientPanel.Location = new System.Drawing.Point(330, 34);
			this.patientPanel.Name = "patientPanel";
			this.patientPanel.Size = new System.Drawing.Size(418, 217);
			this.patientPanel.TabIndex = 0;
			// 
			// positionTextBox
			// 
			this.positionTextBox.Location = new System.Drawing.Point(135, 175);
			this.positionTextBox.Name = "positionTextBox";
			this.positionTextBox.Size = new System.Drawing.Size(280, 20);
			this.positionTextBox.TabIndex = 26;
			// 
			// disabliltyDocumentTextBox
			// 
			this.disabliltyDocumentTextBox.Location = new System.Drawing.Point(15, 101);
			this.disabliltyDocumentTextBox.Multiline = true;
			this.disabliltyDocumentTextBox.Name = "disabliltyDocumentTextBox";
			this.disabliltyDocumentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.disabliltyDocumentTextBox.Size = new System.Drawing.Size(400, 65);
			this.disabliltyDocumentTextBox.TabIndex = 32;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(12, 178);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(117, 13);
			this.label17.TabIndex = 25;
			this.label17.Text = "Место работы/учебы:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(12, 85);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(150, 13);
			this.label16.TabIndex = 31;
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
			this.disabilityComboBox.Location = new System.Drawing.Point(101, 55);
			this.disabilityComboBox.Name = "disabilityComboBox";
			this.disabilityComboBox.Size = new System.Drawing.Size(314, 21);
			this.disabilityComboBox.TabIndex = 30;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 60);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 13);
			this.label15.TabIndex = 29;
			this.label15.Text = "Инвалидность:";
			// 
			// insurancePolicyTextBox
			// 
			this.insurancePolicyTextBox.Location = new System.Drawing.Point(161, 29);
			this.insurancePolicyTextBox.Name = "insurancePolicyTextBox";
			this.insurancePolicyTextBox.Size = new System.Drawing.Size(254, 20);
			this.insurancePolicyTextBox.TabIndex = 28;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(12, 32);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(143, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "Номер страхового полиса:";
			// 
			// snilsTextBox
			// 
			this.snilsTextBox.Location = new System.Drawing.Point(87, 3);
			this.snilsTextBox.Name = "snilsTextBox";
			this.snilsTextBox.Size = new System.Drawing.Size(328, 20);
			this.snilsTextBox.TabIndex = 26;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 6);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 13);
			this.label13.TabIndex = 25;
			this.label13.Text = "СНИЛС:";
			// 
			// doctorPanel
			// 
			this.doctorPanel.Controls.Add(this.removePhotoButton);
			this.doctorPanel.Controls.Add(this.photoPictureBox);
			this.doctorPanel.Controls.Add(this.photoPickButton);
			this.doctorPanel.Controls.Add(this.label19);
			this.doctorPanel.Controls.Add(this.positionComboBox);
			this.doctorPanel.Controls.Add(this.label18);
			this.doctorPanel.Location = new System.Drawing.Point(330, 34);
			this.doctorPanel.Name = "doctorPanel";
			this.doctorPanel.Size = new System.Drawing.Size(418, 217);
			this.doctorPanel.TabIndex = 8;
			// 
			// removePhotoButton
			// 
			this.removePhotoButton.Location = new System.Drawing.Point(268, 75);
			this.removePhotoButton.Name = "removePhotoButton";
			this.removePhotoButton.Size = new System.Drawing.Size(142, 23);
			this.removePhotoButton.TabIndex = 5;
			this.removePhotoButton.Text = "Удалить фото";
			this.removePhotoButton.UseVisualStyleBackColor = true;
			this.removePhotoButton.Click += new System.EventHandler(this.removePhotoButton_Click);
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Image = global::MedicalCard.WinForms.Properties.Resources.DefaultPhoto;
			this.photoPictureBox.Location = new System.Drawing.Point(101, 48);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(161, 161);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photoPictureBox.TabIndex = 4;
			this.photoPictureBox.TabStop = false;
			// 
			// photoPickButton
			// 
			this.photoPickButton.Location = new System.Drawing.Point(268, 47);
			this.photoPickButton.Name = "photoPickButton";
			this.photoPickButton.Size = new System.Drawing.Size(142, 23);
			this.photoPickButton.TabIndex = 3;
			this.photoPickButton.Text = "Обзор...";
			this.photoPickButton.UseVisualStyleBackColor = true;
			this.photoPickButton.Click += new System.EventHandler(this.photoPickButton_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(12, 57);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(38, 13);
			this.label19.TabIndex = 2;
			this.label19.Text = "Фото:";
			// 
			// positionComboBox
			// 
			this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.positionComboBox.FormattingEnabled = true;
			this.positionComboBox.Location = new System.Drawing.Point(101, 16);
			this.positionComboBox.Name = "positionComboBox";
			this.positionComboBox.Size = new System.Drawing.Size(309, 21);
			this.positionComboBox.TabIndex = 1;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(10, 19);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 13);
			this.label18.TabIndex = 0;
			this.label18.Text = "Должность: ";
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
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(87, 301);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(226, 20);
			this.emailTextBox.TabIndex = 24;
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
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(87, 275);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(226, 20);
			this.phoneTextBox.TabIndex = 22;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(619, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 23);
			this.button1.TabIndex = 25;
			this.button1.Text = "Зарегистрироваться";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(538, 298);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = " Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// RegistrationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 339);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.phoneTextBox);
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
			this.Name = "RegistrationWindow";
			this.Text = "Registration";
			this.patientPanel.ResumeLayout(false);
			this.patientPanel.PerformLayout();
			this.doctorPanel.ResumeLayout(false);
			this.doctorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
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
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox insurancePolicyTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox snilsTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox disabilityComboBox;
		private System.Windows.Forms.TextBox disabliltyDocumentTextBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox positionTextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.Button photoPickButton;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox positionComboBox;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button removePhotoButton;
	}
}