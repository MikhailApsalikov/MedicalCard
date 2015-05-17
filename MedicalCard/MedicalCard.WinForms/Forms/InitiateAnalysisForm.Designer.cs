namespace MedicalCard.WinForms.Forms
{
	partial class InitiateAnalysisForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.assistantListView = new System.Windows.Forms.ListView();
			this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.assistantInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.assistantFullNameLabel = new System.Windows.Forms.Label();
			this.timePickerGroupBox = new System.Windows.Forms.GroupBox();
			this.errorLabel = new System.Windows.Forms.Label();
			this.timeComboBox = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.analysisTypeTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.assistantInfoGroupBox.SuspendLayout();
			this.timePickerGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.searchTextBox);
			this.groupBox1.Controls.Add(this.assistantListView);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 405);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите лаборанта";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 24);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 2;
			this.label14.Text = "Поиск:";
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(119, 21);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(323, 20);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.searchTextBox.TextChanged += new System.EventHandler(this.FilterTextChanged);
			// 
			// assistantListView
			// 
			this.assistantListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnHeader1,
            this.columnHeader3});
			this.assistantListView.FullRowSelect = true;
			this.assistantListView.Location = new System.Drawing.Point(6, 58);
			this.assistantListView.MultiSelect = false;
			this.assistantListView.Name = "assistantListView";
			this.assistantListView.Size = new System.Drawing.Size(436, 341);
			this.assistantListView.TabIndex = 0;
			this.assistantListView.UseCompatibleStateImageBehavior = false;
			this.assistantListView.View = System.Windows.Forms.View.Details;
			this.assistantListView.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// columnId
			// 
			this.columnId.Text = "Id";
			this.columnId.Width = 30;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ФИО";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Телефон";
			this.columnHeader3.Width = 100;
			// 
			// assistantInfoGroupBox
			// 
			this.assistantInfoGroupBox.Controls.Add(this.analysisTypeTextBox);
			this.assistantInfoGroupBox.Controls.Add(this.label1);
			this.assistantInfoGroupBox.Controls.Add(this.label13);
			this.assistantInfoGroupBox.Controls.Add(this.label10);
			this.assistantInfoGroupBox.Controls.Add(this.label12);
			this.assistantInfoGroupBox.Controls.Add(this.label8);
			this.assistantInfoGroupBox.Controls.Add(this.label9);
			this.assistantInfoGroupBox.Controls.Add(this.label6);
			this.assistantInfoGroupBox.Controls.Add(this.label7);
			this.assistantInfoGroupBox.Controls.Add(this.label4);
			this.assistantInfoGroupBox.Controls.Add(this.label5);
			this.assistantInfoGroupBox.Controls.Add(this.label2);
			this.assistantInfoGroupBox.Controls.Add(this.label3);
			this.assistantInfoGroupBox.Controls.Add(this.assistantFullNameLabel);
			this.assistantInfoGroupBox.Location = new System.Drawing.Point(474, 12);
			this.assistantInfoGroupBox.Name = "assistantInfoGroupBox";
			this.assistantInfoGroupBox.Size = new System.Drawing.Size(455, 300);
			this.assistantInfoGroupBox.TabIndex = 1;
			this.assistantInfoGroupBox.TabStop = false;
			this.assistantInfoGroupBox.Text = "Лаборант";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(54, 65);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 18);
			this.label13.TabIndex = 19;
			this.label13.Text = "Часы работы:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(26, 219);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 18);
			this.label10.TabIndex = 18;
			this.label10.Text = "Пт:";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(76, 219);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(130, 20);
			this.label12.TabIndex = 17;
			this.label12.Text = "label1";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(26, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 18);
			this.label8.TabIndex = 10;
			this.label8.Text = "Чт:";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(76, 190);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(130, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "label1";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(26, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "Ср:";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(76, 158);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "label1";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(26, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Вт:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(76, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "label1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(26, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пн:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(76, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "label1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// assistantFullNameLabel
			// 
			this.assistantFullNameLabel.AutoSize = true;
			this.assistantFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.assistantFullNameLabel.Location = new System.Drawing.Point(6, 19);
			this.assistantFullNameLabel.Name = "assistantFullNameLabel";
			this.assistantFullNameLabel.Size = new System.Drawing.Size(59, 20);
			this.assistantFullNameLabel.TabIndex = 0;
			this.assistantFullNameLabel.Text = "label1";
			// 
			// timePickerGroupBox
			// 
			this.timePickerGroupBox.Controls.Add(this.errorLabel);
			this.timePickerGroupBox.Controls.Add(this.timeComboBox);
			this.timePickerGroupBox.Controls.Add(this.dateTimePicker1);
			this.timePickerGroupBox.Location = new System.Drawing.Point(474, 332);
			this.timePickerGroupBox.Name = "timePickerGroupBox";
			this.timePickerGroupBox.Size = new System.Drawing.Size(293, 79);
			this.timePickerGroupBox.TabIndex = 2;
			this.timePickerGroupBox.TabStop = false;
			this.timePickerGroupBox.Text = "Выберите дату и время";
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(7, 56);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(136, 15);
			this.errorLabel.TabIndex = 2;
			this.errorLabel.Text = "Запись недоступна";
			this.errorLabel.Visible = false;
			// 
			// timeComboBox
			// 
			this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeComboBox.FormattingEnabled = true;
			this.timeComboBox.Location = new System.Drawing.Point(216, 29);
			this.timeComboBox.Name = "timeComboBox";
			this.timeComboBox.Size = new System.Drawing.Size(71, 21);
			this.timeComboBox.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(10, 30);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(773, 394);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Отмена";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnClickCancelButton);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(854, 394);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Назначить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Тип анализа:";
			// 
			// analysisTypeTextBox
			// 
			this.analysisTypeTextBox.Location = new System.Drawing.Point(106, 266);
			this.analysisTypeTextBox.Name = "analysisTypeTextBox";
			this.analysisTypeTextBox.Size = new System.Drawing.Size(349, 20);
			this.analysisTypeTextBox.TabIndex = 6;
			// 
			// InitiateAnalysisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(941, 430);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.timePickerGroupBox);
			this.Controls.Add(this.assistantInfoGroupBox);
			this.Controls.Add(this.groupBox1);
			this.Name = "InitiateAnalysisForm";
			this.Text = "InitiateExaminationForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.assistantInfoGroupBox.ResumeLayout(false);
			this.assistantInfoGroupBox.PerformLayout();
			this.timePickerGroupBox.ResumeLayout(false);
			this.timePickerGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView assistantListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnId;
		private System.Windows.Forms.GroupBox assistantInfoGroupBox;
		private System.Windows.Forms.GroupBox timePickerGroupBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label assistantFullNameLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox timeComboBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox analysisTypeTextBox;
	}
}