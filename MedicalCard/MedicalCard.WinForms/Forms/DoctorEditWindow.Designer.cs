namespace MedicalCard.WinForms.Forms
{
	partial class DoctorEditWindow
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
			this.removePhotoButton = new System.Windows.Forms.Button();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.photoPickButton = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.positionComboBox = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
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
			this.groupBox2.Controls.Add(this.removePhotoButton);
			this.groupBox2.Controls.Add(this.photoPictureBox);
			this.groupBox2.Controls.Add(this.photoPickButton);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.positionComboBox);
			this.groupBox2.Controls.Add(this.label18);
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
			// removePhotoButton
			// 
			this.removePhotoButton.Location = new System.Drawing.Point(274, 287);
			this.removePhotoButton.Name = "removePhotoButton";
			this.removePhotoButton.Size = new System.Drawing.Size(142, 23);
			this.removePhotoButton.TabIndex = 46;
			this.removePhotoButton.Text = "Удалить фото";
			this.removePhotoButton.UseVisualStyleBackColor = true;
			this.removePhotoButton.Click += new System.EventHandler(this.removePhotoButton_Click);
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Image = global::MedicalCard.WinForms.Properties.Resources.DefaultPhoto;
			this.photoPictureBox.Location = new System.Drawing.Point(107, 260);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(161, 161);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photoPictureBox.TabIndex = 45;
			this.photoPictureBox.TabStop = false;
			// 
			// photoPickButton
			// 
			this.photoPickButton.Location = new System.Drawing.Point(274, 259);
			this.photoPickButton.Name = "photoPickButton";
			this.photoPickButton.Size = new System.Drawing.Size(142, 23);
			this.photoPickButton.TabIndex = 44;
			this.photoPickButton.Text = "Обзор...";
			this.photoPickButton.UseVisualStyleBackColor = true;
			this.photoPickButton.Click += new System.EventHandler(this.photoPickButton_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(18, 269);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(38, 13);
			this.label19.TabIndex = 43;
			this.label19.Text = "Фото:";
			// 
			// positionComboBox
			// 
			this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.positionComboBox.FormattingEnabled = true;
			this.positionComboBox.Location = new System.Drawing.Point(107, 228);
			this.positionComboBox.Name = "positionComboBox";
			this.positionComboBox.Size = new System.Drawing.Size(309, 21);
			this.positionComboBox.TabIndex = 42;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(16, 231);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 13);
			this.label18.TabIndex = 41;
			this.label18.Text = "Должность: ";
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
			// DoctorEditWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 454);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "DoctorEditWindow";
			this.Text = "AccountDataEdit";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button removePhotoButton;
		private System.Windows.Forms.PictureBox photoPictureBox;
		private System.Windows.Forms.Button photoPickButton;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox positionComboBox;
		private System.Windows.Forms.Label label18;
	}
}