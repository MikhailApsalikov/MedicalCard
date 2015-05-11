namespace MedicalCard.WinForms.Forms
{
	partial class PatientMainWindow
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.медицинскаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.записьКВрачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактироватьЛичныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.initiateExaminationButton = new System.Windows.Forms.Button();
			this.initiateExaminationLabel = new System.Windows.Forms.Label();
			this.currentExaminationListView = new System.Windows.Forms.ListView();
			this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.медицинскаяКартаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(873, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзСистемыToolStripMenuItem,
            this.toolStripMenuItem2});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходИзСистемыToolStripMenuItem
			// 
			this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
			this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.выходИзСистемыToolStripMenuItem.Text = "Выход из системы";
			this.выходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выходИзСистемыToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 22);
			this.toolStripMenuItem2.Text = "Закрыть приложение";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// медицинскаяКартаToolStripMenuItem
			// 
			this.медицинскаяКартаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьКВрачуToolStripMenuItem,
            this.редактироватьЛичныеДанныеToolStripMenuItem});
			this.медицинскаяКартаToolStripMenuItem.Name = "медицинскаяКартаToolStripMenuItem";
			this.медицинскаяКартаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.медицинскаяКартаToolStripMenuItem.Text = "ЭМК";
			// 
			// записьКВрачуToolStripMenuItem
			// 
			this.записьКВрачуToolStripMenuItem.Name = "записьКВрачуToolStripMenuItem";
			this.записьКВрачуToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.записьКВрачуToolStripMenuItem.Text = "Запись к врачу";
			this.записьКВрачуToolStripMenuItem.Click += new System.EventHandler(this.записьКВрачуToolStripMenuItem_Click);
			// 
			// редактироватьЛичныеДанныеToolStripMenuItem
			// 
			this.редактироватьЛичныеДанныеToolStripMenuItem.Name = "редактироватьЛичныеДанныеToolStripMenuItem";
			this.редактироватьЛичныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.редактироватьЛичныеДанныеToolStripMenuItem.Text = "Редактировать личные данные";
			this.редактироватьЛичныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЛичныеДанныеToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.initiateExaminationButton);
			this.groupBox1.Controls.Add(this.initiateExaminationLabel);
			this.groupBox1.Controls.Add(this.currentExaminationListView);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(849, 182);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Я записан к:";
			// 
			// initiateExaminationButton
			// 
			this.initiateExaminationButton.Location = new System.Drawing.Point(354, 113);
			this.initiateExaminationButton.Name = "initiateExaminationButton";
			this.initiateExaminationButton.Size = new System.Drawing.Size(145, 23);
			this.initiateExaminationButton.TabIndex = 3;
			this.initiateExaminationButton.Text = "Записаться на прием";
			this.initiateExaminationButton.UseVisualStyleBackColor = true;
			this.initiateExaminationButton.Click += new System.EventHandler(this.записьКВрачуToolStripMenuItem_Click);
			// 
			// initiateExaminationLabel
			// 
			this.initiateExaminationLabel.AutoSize = true;
			this.initiateExaminationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.initiateExaminationLabel.ForeColor = System.Drawing.Color.Green;
			this.initiateExaminationLabel.Location = new System.Drawing.Point(272, 70);
			this.initiateExaminationLabel.Name = "initiateExaminationLabel";
			this.initiateExaminationLabel.Size = new System.Drawing.Size(333, 16);
			this.initiateExaminationLabel.TabIndex = 2;
			this.initiateExaminationLabel.Text = "Вы пока не записаны на прием ни к одному врачу";
			// 
			// currentExaminationListView
			// 
			this.currentExaminationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.currentExaminationListView.FullRowSelect = true;
			this.currentExaminationListView.Location = new System.Drawing.Point(6, 19);
			this.currentExaminationListView.MultiSelect = false;
			this.currentExaminationListView.Name = "currentExaminationListView";
			this.currentExaminationListView.Size = new System.Drawing.Size(837, 157);
			this.currentExaminationListView.TabIndex = 1;
			this.currentExaminationListView.UseCompatibleStateImageBehavior = false;
			this.currentExaminationListView.View = System.Windows.Forms.View.Details;
			// 
			// columnId
			// 
			this.columnId.Text = "Id";
			this.columnId.Width = 0;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Должность";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ФИО";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Время";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Статус";
			this.columnHeader4.Width = 120;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(12, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(849, 236);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "История записей:";
			// 
			// PatientMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 473);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PatientMainWindow";
			this.Text = "PatientMainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem медицинскаяКартаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem записьКВрачуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактироватьЛичныеДанныеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView currentExaminationListView;
		private System.Windows.Forms.ColumnHeader columnId;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button initiateExaminationButton;
		private System.Windows.Forms.Label initiateExaminationLabel;
	}
}