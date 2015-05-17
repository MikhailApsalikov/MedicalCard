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
			this.manageButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// manageButtons
			// 
			this.manageButtons.Controls.Add(this.button2);
			this.manageButtons.Controls.Add(this.button1);
			this.manageButtons.Location = new System.Drawing.Point(532, 12);
			this.manageButtons.Name = "manageButtons";
			this.manageButtons.Size = new System.Drawing.Size(155, 290);
			this.manageButtons.TabIndex = 0;
			this.manageButtons.TabStop = false;
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
			this.textBox1.Location = new System.Drawing.Point(15, 157);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(494, 145);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 131);
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
			this.label3.Size = new System.Drawing.Size(409, 13);
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
			this.doctorLabel.Size = new System.Drawing.Size(409, 13);
			this.doctorLabel.TabIndex = 6;
			this.doctorLabel.Text = "label5";
			this.doctorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// patientLabel
			// 
			this.patientLabel.Location = new System.Drawing.Point(100, 96);
			this.patientLabel.Name = "patientLabel";
			this.patientLabel.Size = new System.Drawing.Size(409, 13);
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
			// AnalysisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 324);
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
	}
}