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
			this.manageButtons = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.visualComplaintsComboBox = new System.Windows.Forms.ComboBox();
			this.localizaionComboBox = new System.Windows.Forms.ComboBox();
			this.painComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.diseaseOccurenceDate = new System.Windows.Forms.DateTimePicker();
			this.patientFeature = new System.Windows.Forms.ComboBox();
			this.diseaseFeature = new System.Windows.Forms.ComboBox();
			this.lifeStyleFeature = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.deformation = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.diseaseLocalication = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.xray = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.diseaseForm = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.age = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.cause = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.recommendations = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.drugs = new System.Windows.Forms.TextBox();
			this.manageButtons.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// manageButtons
			// 
			this.manageButtons.Controls.Add(this.button5);
			this.manageButtons.Controls.Add(this.button4);
			this.manageButtons.Controls.Add(this.button3);
			this.manageButtons.Controls.Add(this.button2);
			this.manageButtons.Controls.Add(this.button1);
			this.manageButtons.Location = new System.Drawing.Point(984, 413);
			this.manageButtons.Name = "manageButtons";
			this.manageButtons.Size = new System.Drawing.Size(155, 164);
			this.manageButtons.TabIndex = 0;
			this.manageButtons.TabStop = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 101);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(143, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Посмотреть анализы";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 130);
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
			this.textBox1.Location = new System.Drawing.Point(192, 79);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(218, 71);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Комментарий жалобы:";
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
			this.label3.Size = new System.Drawing.Size(238, 13);
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
			this.label5.Size = new System.Drawing.Size(238, 13);
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
			this.historyListView.Size = new System.Drawing.Size(485, 167);
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
			this.historyIsEmptyLabel.Location = new System.Drawing.Point(111, 92);
			this.historyIsEmptyLabel.Name = "historyIsEmptyLabel";
			this.historyIsEmptyLabel.Size = new System.Drawing.Size(258, 16);
			this.historyIsEmptyLabel.TabIndex = 4;
			this.historyIsEmptyLabel.Text = "У пациента нет предыдущих осмотров";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.historyIsEmptyLabel);
			this.groupBox1.Controls.Add(this.historyListView);
			this.groupBox1.Location = new System.Drawing.Point(15, 380);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(503, 197);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Предыдущие осмотры:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.visualComplaintsComboBox);
			this.groupBox2.Controls.Add(this.localizaionComboBox);
			this.groupBox2.Controls.Add(this.painComboBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(15, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 156);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Жалобы:";
			// 
			// visualComplaintsComboBox
			// 
			this.visualComplaintsComboBox.AllowDrop = true;
			this.visualComplaintsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.visualComplaintsComboBox.FormattingEnabled = true;
			this.visualComplaintsComboBox.Location = new System.Drawing.Point(294, 44);
			this.visualComplaintsComboBox.Name = "visualComplaintsComboBox";
			this.visualComplaintsComboBox.Size = new System.Drawing.Size(116, 21);
			this.visualComplaintsComboBox.TabIndex = 10;
			// 
			// localizaionComboBox
			// 
			this.localizaionComboBox.AllowDrop = true;
			this.localizaionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.localizaionComboBox.FormattingEnabled = true;
			this.localizaionComboBox.Location = new System.Drawing.Point(127, 44);
			this.localizaionComboBox.Name = "localizaionComboBox";
			this.localizaionComboBox.Size = new System.Drawing.Size(153, 21);
			this.localizaionComboBox.TabIndex = 9;
			// 
			// painComboBox
			// 
			this.painComboBox.AllowDrop = true;
			this.painComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.painComboBox.FormattingEnabled = true;
			this.painComboBox.Location = new System.Drawing.Point(9, 44);
			this.painComboBox.Name = "painComboBox";
			this.painComboBox.Size = new System.Drawing.Size(99, 21);
			this.painComboBox.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(298, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Визуальные жалобы";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Локализация";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(41, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Боли";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.diseaseOccurenceDate);
			this.groupBox3.Controls.Add(this.patientFeature);
			this.groupBox3.Controls.Add(this.diseaseFeature);
			this.groupBox3.Controls.Add(this.lifeStyleFeature);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(12, 249);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(434, 125);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Анамнез";
			// 
			// diseaseOccurenceDate
			// 
			this.diseaseOccurenceDate.Location = new System.Drawing.Point(197, 99);
			this.diseaseOccurenceDate.Name = "diseaseOccurenceDate";
			this.diseaseOccurenceDate.Size = new System.Drawing.Size(231, 20);
			this.diseaseOccurenceDate.TabIndex = 14;
			// 
			// patientFeature
			// 
			this.patientFeature.AllowDrop = true;
			this.patientFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.patientFeature.FormattingEnabled = true;
			this.patientFeature.Location = new System.Drawing.Point(197, 72);
			this.patientFeature.Name = "patientFeature";
			this.patientFeature.Size = new System.Drawing.Size(231, 21);
			this.patientFeature.TabIndex = 13;
			// 
			// diseaseFeature
			// 
			this.diseaseFeature.AllowDrop = true;
			this.diseaseFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.diseaseFeature.FormattingEnabled = true;
			this.diseaseFeature.Location = new System.Drawing.Point(197, 45);
			this.diseaseFeature.Name = "diseaseFeature";
			this.diseaseFeature.Size = new System.Drawing.Size(231, 21);
			this.diseaseFeature.TabIndex = 12;
			// 
			// lifeStyleFeature
			// 
			this.lifeStyleFeature.AllowDrop = true;
			this.lifeStyleFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lifeStyleFeature.FormattingEnabled = true;
			this.lifeStyleFeature.Location = new System.Drawing.Point(197, 21);
			this.lifeStyleFeature.Name = "lifeStyleFeature";
			this.lifeStyleFeature.Size = new System.Drawing.Size(231, 21);
			this.lifeStyleFeature.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 75);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(174, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Особенности развития пациента";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(183, 13);
			this.label11.TabIndex = 2;
			this.label11.Text = "Дата возникновения заболевания";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(193, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Особенности развития заболевания";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Особенности образа жизни";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.deformation);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.diseaseLocalication);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.xray);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.diseaseForm);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.age);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.cause);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Location = new System.Drawing.Point(452, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(687, 101);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Диагноз";
			// 
			// deformation
			// 
			this.deformation.AllowDrop = true;
			this.deformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.deformation.FormattingEnabled = true;
			this.deformation.Location = new System.Drawing.Point(505, 75);
			this.deformation.Name = "deformation";
			this.deformation.Size = new System.Drawing.Size(176, 21);
			this.deformation.TabIndex = 26;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(338, 78);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 13);
			this.label20.TabIndex = 25;
			this.label20.Text = "Деформация";
			// 
			// diseaseLocalication
			// 
			this.diseaseLocalication.AllowDrop = true;
			this.diseaseLocalication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.diseaseLocalication.FormattingEnabled = true;
			this.diseaseLocalication.Location = new System.Drawing.Point(151, 75);
			this.diseaseLocalication.Name = "diseaseLocalication";
			this.diseaseLocalication.Size = new System.Drawing.Size(168, 21);
			this.diseaseLocalication.TabIndex = 24;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 78);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(144, 13);
			this.label19.TabIndex = 23;
			this.label19.Text = "Локализация искривления";
			// 
			// xray
			// 
			this.xray.AllowDrop = true;
			this.xray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.xray.FormattingEnabled = true;
			this.xray.Location = new System.Drawing.Point(505, 48);
			this.xray.Name = "xray";
			this.xray.Size = new System.Drawing.Size(176, 21);
			this.xray.TabIndex = 22;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(338, 51);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(131, 13);
			this.label18.TabIndex = 21;
			this.label18.Text = "Рентген-классификация";
			// 
			// diseaseForm
			// 
			this.diseaseForm.AllowDrop = true;
			this.diseaseForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.diseaseForm.FormattingEnabled = true;
			this.diseaseForm.Location = new System.Drawing.Point(151, 48);
			this.diseaseForm.Name = "diseaseForm";
			this.diseaseForm.Size = new System.Drawing.Size(168, 21);
			this.diseaseForm.TabIndex = 20;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 51);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(113, 13);
			this.label17.TabIndex = 19;
			this.label17.Text = "Форма искривления";
			// 
			// age
			// 
			this.age.AllowDrop = true;
			this.age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.age.FormattingEnabled = true;
			this.age.Location = new System.Drawing.Point(505, 19);
			this.age.Name = "age";
			this.age.Size = new System.Drawing.Size(176, 21);
			this.age.TabIndex = 18;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(338, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(146, 13);
			this.label16.TabIndex = 17;
			this.label16.Text = "Возраст диагностирования";
			// 
			// cause
			// 
			this.cause.AllowDrop = true;
			this.cause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cause.FormattingEnabled = true;
			this.cause.Location = new System.Drawing.Point(151, 19);
			this.cause.Name = "cause";
			this.cause.Size = new System.Drawing.Size(168, 21);
			this.cause.TabIndex = 16;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 22);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(133, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Причины возникновения";
			// 
			// groupBox5
			// 
			this.groupBox5.Location = new System.Drawing.Point(452, 119);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(681, 244);
			this.groupBox5.TabIndex = 11;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Осмотр";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Controls.Add(this.recommendations);
			this.groupBox6.Controls.Add(this.label13);
			this.groupBox6.Controls.Add(this.drugs);
			this.groupBox6.Location = new System.Drawing.Point(524, 369);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(454, 208);
			this.groupBox6.TabIndex = 12;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Лечение";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 121);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Рекомендации:";
			// 
			// recommendations
			// 
			this.recommendations.Location = new System.Drawing.Point(97, 118);
			this.recommendations.Multiline = true;
			this.recommendations.Name = "recommendations";
			this.recommendations.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.recommendations.Size = new System.Drawing.Size(340, 71);
			this.recommendations.TabIndex = 13;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 27);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "Лекарство:";
			// 
			// drugs
			// 
			this.drugs.Location = new System.Drawing.Point(97, 22);
			this.drugs.Multiline = true;
			this.drugs.Name = "drugs";
			this.drugs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.drugs.Size = new System.Drawing.Size(340, 71);
			this.drugs.TabIndex = 11;
			// 
			// ExaminationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 589);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.manageButtons);
			this.Name = "ExaminationForm";
			this.Text = "ExaminationForm";
			this.manageButtons.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
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
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox painComboBox;
		private System.Windows.Forms.ComboBox visualComplaintsComboBox;
		private System.Windows.Forms.ComboBox localizaionComboBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox patientFeature;
		private System.Windows.Forms.ComboBox diseaseFeature;
		private System.Windows.Forms.ComboBox lifeStyleFeature;
		private System.Windows.Forms.DateTimePicker diseaseOccurenceDate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox recommendations;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox drugs;
		private System.Windows.Forms.ComboBox deformation;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox diseaseLocalication;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox xray;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox diseaseForm;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox age;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cause;
		private System.Windows.Forms.Label label15;
	}
}