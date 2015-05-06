namespace MedicalCard.WinForms.Forms
{
	partial class DoctorMainWindow
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
			this.мояКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.записьКВрачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактироватьЛичныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
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
            this.мояКартаToolStripMenuItem,
            this.записьКВрачуToolStripMenuItem,
            this.редактироватьЛичныеДанныеToolStripMenuItem});
			this.медицинскаяКартаToolStripMenuItem.Name = "медицинскаяКартаToolStripMenuItem";
			this.медицинскаяКартаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.медицинскаяКартаToolStripMenuItem.Text = "ЭМК";
			// 
			// мояКартаToolStripMenuItem
			// 
			this.мояКартаToolStripMenuItem.Name = "мояКартаToolStripMenuItem";
			this.мояКартаToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.мояКартаToolStripMenuItem.Text = "Моя карта";
			// 
			// записьКВрачуToolStripMenuItem
			// 
			this.записьКВрачуToolStripMenuItem.Name = "записьКВрачуToolStripMenuItem";
			this.записьКВрачуToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.записьКВрачуToolStripMenuItem.Text = "Запись к врачу";
			// 
			// редактироватьЛичныеДанныеToolStripMenuItem
			// 
			this.редактироватьЛичныеДанныеToolStripMenuItem.Name = "редактироватьЛичныеДанныеToolStripMenuItem";
			this.редактироватьЛичныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.редактироватьЛичныеДанныеToolStripMenuItem.Text = "Редактировать личные данные";
			this.редактироватьЛичныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЛичныеДанныеToolStripMenuItem_Click);
			// 
			// DoctorMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 473);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DoctorMainWindow";
			this.Text = "DoctorMainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem медицинскаяКартаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem мояКартаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem записьКВрачуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактироватьЛичныеДанныеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
	}
}