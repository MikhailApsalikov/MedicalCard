namespace MedicalCard.WinForms.Forms
{
	partial class NoteListWindow
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
			this.noteListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.expirationLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.textLabel = new System.Windows.Forms.Label();
			this.doctorLabel = new System.Windows.Forms.Label();
			this.patientLabel = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// noteListView
			// 
			this.noteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
			this.noteListView.FullRowSelect = true;
			this.noteListView.Location = new System.Drawing.Point(12, 12);
			this.noteListView.MultiSelect = false;
			this.noteListView.Name = "noteListView";
			this.noteListView.Size = new System.Drawing.Size(542, 431);
			this.noteListView.TabIndex = 5;
			this.noteListView.UseCompatibleStateImageBehavior = false;
			this.noteListView.View = System.Windows.Forms.View.Details;
			this.noteListView.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Id";
			this.columnHeader5.Width = 0;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Заголовок";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "ФИО врача";
			this.columnHeader7.Width = 200;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Должность врача";
			this.columnHeader8.Width = 110;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Действительна до:";
			this.columnHeader1.Width = 110;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.expirationLabel);
			this.groupBox1.Controls.Add(this.dateLabel);
			this.groupBox1.Controls.Add(this.textLabel);
			this.groupBox1.Controls.Add(this.doctorLabel);
			this.groupBox1.Controls.Add(this.patientLabel);
			this.groupBox1.Controls.Add(this.label43);
			this.groupBox1.Controls.Add(this.titleLabel);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(560, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(581, 431);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// expirationLabel
			// 
			this.expirationLabel.AutoSize = true;
			this.expirationLabel.Location = new System.Drawing.Point(13, 353);
			this.expirationLabel.Name = "expirationLabel";
			this.expirationLabel.Size = new System.Drawing.Size(104, 13);
			this.expirationLabel.TabIndex = 14;
			this.expirationLabel.Text = "Действительна до:";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(13, 328);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(33, 13);
			this.dateLabel.TabIndex = 13;
			this.dateLabel.Text = "Дата";
			// 
			// textLabel
			// 
			this.textLabel.Location = new System.Drawing.Point(10, 82);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(565, 217);
			this.textLabel.TabIndex = 12;
			this.textLabel.Text = "label1";
			// 
			// doctorLabel
			// 
			this.doctorLabel.AutoSize = true;
			this.doctorLabel.Location = new System.Drawing.Point(366, 329);
			this.doctorLabel.Name = "doctorLabel";
			this.doctorLabel.Size = new System.Drawing.Size(31, 13);
			this.doctorLabel.TabIndex = 11;
			this.doctorLabel.Text = "Врач";
			// 
			// patientLabel
			// 
			this.patientLabel.AutoSize = true;
			this.patientLabel.Location = new System.Drawing.Point(117, 59);
			this.patientLabel.Name = "patientLabel";
			this.patientLabel.Size = new System.Drawing.Size(34, 13);
			this.patientLabel.TabIndex = 10;
			this.patientLabel.Text = "ФИО";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(7, 59);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(56, 13);
			this.label43.TabIndex = 9;
			this.label43.Text = "Пациент: ";
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel.Location = new System.Drawing.Point(6, 16);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(569, 23);
			this.titleLabel.TabIndex = 8;
			this.titleLabel.Text = "Справка";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(475, 402);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Распечатать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// NoteListWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 455);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.noteListView);
			this.Name = "NoteListWindow";
			this.Text = "NoteListWindow";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView noteListView;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label patientLabel;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label textLabel;
		private System.Windows.Forms.Label doctorLabel;
		private System.Windows.Forms.Label expirationLabel;
		private System.Windows.Forms.Label dateLabel;
	}
}