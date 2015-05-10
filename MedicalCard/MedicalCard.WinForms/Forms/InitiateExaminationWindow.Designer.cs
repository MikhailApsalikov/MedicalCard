namespace MedicalCard.WinForms.Forms
{
	partial class InitiateExaminationWindow
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
			this.doctorListView = new System.Windows.Forms.ListView();
			this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.doctorListView);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 233);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите врача";
			// 
			// doctorListView
			// 
			this.doctorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.doctorListView.FullRowSelect = true;
			this.doctorListView.Location = new System.Drawing.Point(6, 19);
			this.doctorListView.MultiSelect = false;
			this.doctorListView.Name = "doctorListView";
			this.doctorListView.Size = new System.Drawing.Size(436, 178);
			this.doctorListView.TabIndex = 0;
			this.doctorListView.UseCompatibleStateImageBehavior = false;
			this.doctorListView.View = System.Windows.Forms.View.Details;
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
			// columnHeader2
			// 
			this.columnHeader2.Text = "Должность";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Телефон";
			this.columnHeader3.Width = 100;
			// 
			// InitiateExaminationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 456);
			this.Controls.Add(this.groupBox1);
			this.Name = "InitiateExaminationWindow";
			this.Text = "InitiateExaminationWindow";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView doctorListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnId;
	}
}