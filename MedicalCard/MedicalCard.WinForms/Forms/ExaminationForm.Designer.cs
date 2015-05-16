﻿namespace MedicalCard.WinForms.Forms
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.doctorActionsGroupBox.SuspendLayout();
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
			this.doctorActionsGroupBox.Size = new System.Drawing.Size(155, 290);
			this.doctorActionsGroupBox.TabIndex = 0;
			this.doctorActionsGroupBox.TabStop = false;
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
			this.textBox1.Location = new System.Drawing.Point(15, 80);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(494, 222);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 64);
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
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 72);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Выдать справку";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 101);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Назначить анализ";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// ExaminationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 316);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.doctorActionsGroupBox);
			this.Name = "ExaminationForm";
			this.Text = "ExaminationForm";
			this.doctorActionsGroupBox.ResumeLayout(false);
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
	}
}