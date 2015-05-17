namespace MedicalCard.WinForms.Forms
{
	partial class AnalysisListForm
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
			this.historyListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// historyListView
			// 
			this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
			this.historyListView.FullRowSelect = true;
			this.historyListView.Location = new System.Drawing.Point(12, 12);
			this.historyListView.MultiSelect = false;
			this.historyListView.Name = "historyListView";
			this.historyListView.Size = new System.Drawing.Size(632, 511);
			this.historyListView.TabIndex = 5;
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
			this.columnHeader6.Text = "Тип анализа";
			this.columnHeader6.Width = 150;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "ФИО лаборанта";
			this.columnHeader7.Width = 200;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Время";
			this.columnHeader8.Width = 120;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Статус";
			this.columnHeader1.Width = 120;
			// 
			// AnalysisListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 535);
			this.Controls.Add(this.historyListView);
			this.Name = "AnalysisListForm";
			this.Text = "AnalysisListForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView historyListView;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader1;
	}
}