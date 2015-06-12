namespace MedicalCard.WinForms.Forms
{
	partial class AnalysisForm
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
			this.manageButtons = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.doctorLabel = new System.Windows.Forms.Label();
			this.patientLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.chestSideComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chestDegreesTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.neckDegreesTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.neckSideComboBox = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.waistDegreesTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.waistSideComboBox = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.manageButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// manageButtons
			// 
			this.manageButtons.Controls.Add(this.button3);
			this.manageButtons.Controls.Add(this.button2);
			this.manageButtons.Controls.Add(this.button1);
			this.manageButtons.Location = new System.Drawing.Point(642, 287);
			this.manageButtons.Name = "manageButtons";
			this.manageButtons.Size = new System.Drawing.Size(155, 112);
			this.manageButtons.TabIndex = 0;
			this.manageButtons.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сохранить изменения";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Закончить осмотр";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 254);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(547, 145);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 228);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Результаты анализа:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Статус: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(100, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(462, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Направление от:";
			// 
			// doctorLabel
			// 
			this.doctorLabel.Location = new System.Drawing.Point(100, 65);
			this.doctorLabel.Name = "doctorLabel";
			this.doctorLabel.Size = new System.Drawing.Size(462, 13);
			this.doctorLabel.TabIndex = 6;
			this.doctorLabel.Text = "label5";
			this.doctorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// patientLabel
			// 
			this.patientLabel.Location = new System.Drawing.Point(100, 96);
			this.patientLabel.Name = "patientLabel";
			this.patientLabel.Size = new System.Drawing.Size(462, 13);
			this.patientLabel.TabIndex = 7;
			this.patientLabel.Text = "label6";
			this.patientLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Пациент:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Искривление позвоночника в ";
			// 
			// chestSideComboBox
			// 
			this.chestSideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.chestSideComboBox.FormattingEnabled = true;
			this.chestSideComboBox.Items.AddRange(new object[] {
            "левую",
            "правую"});
			this.chestSideComboBox.Location = new System.Drawing.Point(179, 138);
			this.chestSideComboBox.Name = "chestSideComboBox";
			this.chestSideComboBox.Size = new System.Drawing.Size(107, 21);
			this.chestSideComboBox.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(292, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "сторону в грудном отделе на ";
			// 
			// chestDegreesTextBox
			// 
			this.chestDegreesTextBox.Location = new System.Drawing.Point(467, 138);
			this.chestDegreesTextBox.Name = "chestDegreesTextBox";
			this.chestDegreesTextBox.Size = new System.Drawing.Size(36, 20);
			this.chestDegreesTextBox.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(509, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "градусов";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(509, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "градусов";
			// 
			// neckDegreesTextBox
			// 
			this.neckDegreesTextBox.Location = new System.Drawing.Point(467, 165);
			this.neckDegreesTextBox.Name = "neckDegreesTextBox";
			this.neckDegreesTextBox.Size = new System.Drawing.Size(36, 20);
			this.neckDegreesTextBox.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(292, 168);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(155, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "сторону в шейном отделе на ";
			// 
			// neckSideComboBox
			// 
			this.neckSideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.neckSideComboBox.FormattingEnabled = true;
			this.neckSideComboBox.Items.AddRange(new object[] {
            "левую",
            "правую"});
			this.neckSideComboBox.Location = new System.Drawing.Point(179, 165);
			this.neckSideComboBox.Name = "neckSideComboBox";
			this.neckSideComboBox.Size = new System.Drawing.Size(107, 21);
			this.neckSideComboBox.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 168);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(161, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Искривление позвоночника в ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(509, 195);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "градусов";
			// 
			// waistDegreesTextBox
			// 
			this.waistDegreesTextBox.Location = new System.Drawing.Point(467, 192);
			this.waistDegreesTextBox.Name = "waistDegreesTextBox";
			this.waistDegreesTextBox.Size = new System.Drawing.Size(36, 20);
			this.waistDegreesTextBox.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(292, 195);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(176, 13);
			this.label13.TabIndex = 21;
			this.label13.Text = "сторону в поясничном отделе на ";
			// 
			// waistSideComboBox
			// 
			this.waistSideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.waistSideComboBox.FormattingEnabled = true;
			this.waistSideComboBox.Items.AddRange(new object[] {
            "левую",
            "правую"});
			this.waistSideComboBox.Location = new System.Drawing.Point(179, 192);
			this.waistSideComboBox.Name = "waistSideComboBox";
			this.waistSideComboBox.Size = new System.Drawing.Size(107, 21);
			this.waistSideComboBox.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(12, 195);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(161, 13);
			this.label14.TabIndex = 19;
			this.label14.Text = "Искривление позвоночника в ";
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.Location = new System.Drawing.Point(577, 36);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(214, 215);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photoPictureBox.TabIndex = 24;
			this.photoPictureBox.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Загрузить рентген";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// AnalysisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 419);
			this.Controls.Add(this.photoPictureBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.waistDegreesTextBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.waistSideComboBox);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.neckDegreesTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.neckSideComboBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.chestDegreesTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.chestSideComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.patientLabel);
			this.Controls.Add(this.doctorLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.manageButtons);
			this.Name = "AnalysisForm";
			this.Text = "ExaminationForm";
			this.manageButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox manageButtons;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label doctorLabel;
		private System.Windows.Forms.Label patientLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox chestSideComboBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox chestDegreesTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox neckDegreesTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox neckSideComboBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox waistDegreesTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox waistSideComboBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox photoPictureBox;
	}
}