namespace MedicalCard.WinForms.Forms
{
	partial class ExaminationForm
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
			this.doctorActionsGroupBox = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.historyListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.historyIsEmptyLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.doctorActionsGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// doctorActionsGroupBox
			// 
			this.doctorActionsGroupBox.Controls.Add(this.button4);
			this.doctorActionsGroupBox.Controls.Add(this.button3);
			this.doctorActionsGroupBox.Controls.Add(this.button2);
			this.doctorActionsGroupBox.Controls.Add(this.button1);
			this.doctorActionsGroupBox.Location = new System.Drawing.Point(532, 12);
			this.doctorActionsGroupBox.Name = "doctorActionsGroupBox";
			this.doctorActionsGroupBox.Size = new System.Drawing.Size(155, 532);
			this.doctorActionsGroupBox.TabIndex = 0;
			this.doctorActionsGroupBox.TabStop = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 101);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Назначить анализ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 72);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Выдать справку";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 14);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сохранить изменения";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Закончить осмотр";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 113);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(494, 189);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Текст осмотра:";
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
			this.label3.Size = new System.Drawing.Size(409, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Врач:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(100, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(409, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "label5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// historyListView
			// 
			this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.historyListView.FullRowSelect = true;
			this.historyListView.Location = new System.Drawing.Point(6, 19);
			this.historyListView.MultiSelect = false;
			this.historyListView.Name = "historyListView";
			this.historyListView.Size = new System.Drawing.Size(485, 211);
			this.historyListView.TabIndex = 4;
			this.historyListView.UseCompatibleStateImageBehavior = false;
			this.historyListView.View = System.Windows.Forms.View.Details;
			this.historyListView.DoubleClick += new System.EventHandler(this.historyListView_DoubleClick);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Id";
			this.columnHeader5.Width = 0;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Должность";
			this.columnHeader6.Width = 135;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "ФИО";
			this.columnHeader7.Width = 220;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Время";
			this.columnHeader8.Width = 120;
			// 
			// historyIsEmptyLabel
			// 
			this.historyIsEmptyLabel.AutoSize = true;
			this.historyIsEmptyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.historyIsEmptyLabel.ForeColor = System.Drawing.Color.Green;
			this.historyIsEmptyLabel.Location = new System.Drawing.Point(117, 110);
			this.historyIsEmptyLabel.Name = "historyIsEmptyLabel";
			this.historyIsEmptyLabel.Size = new System.Drawing.Size(258, 16);
			this.historyIsEmptyLabel.TabIndex = 4;
			this.historyIsEmptyLabel.Text = "У пациента нет предыдущих осмотров";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.historyIsEmptyLabel);
			this.groupBox1.Controls.Add(this.historyListView);
			this.groupBox1.Location = new System.Drawing.Point(6, 314);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(503, 236);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Предыдущие осмотры:";
			// 
			// ExaminationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 562);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.doctorActionsGroupBox);
			this.Name = "ExaminationForm";
			this.Text = "ExaminationForm";
			this.doctorActionsGroupBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox doctorActionsGroupBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label historyIsEmptyLabel;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView historyListView;
	}
}