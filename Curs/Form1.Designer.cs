namespace Curs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateRasp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveCSV = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SaveExcel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearData = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddDays = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddWeeks = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PrintPrepods = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.EndOfEnterPrepod = new System.Windows.Forms.Button();
            this.AddPrepod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndOfEntPrep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AddPrepods = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintGroups = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EndOfEntrPars = new System.Windows.Forms.Button();
            this.HrParsLabel = new System.Windows.Forms.Label();
            this.ParLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddPars_Bttn = new System.Windows.Forms.Button();
            this.AddGrp_bttn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelNameGrp = new System.Windows.Forms.Label();
            this.EndOfAddGrps = new System.Windows.Forms.Button();
            this.CreateGroups = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateRasp
            // 
            this.CreateRasp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateRasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRasp.Location = new System.Drawing.Point(3, 609);
            this.CreateRasp.Name = "CreateRasp";
            this.CreateRasp.Size = new System.Drawing.Size(243, 65);
            this.CreateRasp.TabIndex = 0;
            this.CreateRasp.Text = "Создать расписание";
            this.CreateRasp.UseVisualStyleBackColor = true;
            this.CreateRasp.Click += new System.EventHandler(this.CreateRasp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.SaveCSV);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.SaveExcel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ClearData);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.AddDays);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddWeeks);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AddPrepods);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CreateGroups);
            this.panel1.Controls.Add(this.CreateRasp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 2;
            // 
            // SaveCSV
            // 
            this.SaveCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveCSV.Location = new System.Drawing.Point(27, 482);
            this.SaveCSV.Name = "SaveCSV";
            this.SaveCSV.Size = new System.Drawing.Size(219, 38);
            this.SaveCSV.TabIndex = 27;
            this.SaveCSV.Text = "Сохранить в CSV";
            this.SaveCSV.UseVisualStyleBackColor = true;
            this.SaveCSV.Click += new System.EventHandler(this.SaveCSV_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SaveExcel
            // 
            this.SaveExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveExcel.Location = new System.Drawing.Point(27, 438);
            this.SaveExcel.Name = "SaveExcel";
            this.SaveExcel.Size = new System.Drawing.Size(219, 38);
            this.SaveExcel.TabIndex = 25;
            this.SaveExcel.Text = "Сохранить в Excel";
            this.SaveExcel.UseVisualStyleBackColor = true;
            this.SaveExcel.Click += new System.EventHandler(this.SaveExcel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(920, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Итоговое расписание";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(24, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Небольшая справочная";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Как пользоваться"});
            this.comboBox1.Location = new System.Drawing.Point(27, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Справочная";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(27, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Количество рабочих дней 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(27, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Количество рабочих недель 0";
            // 
            // ClearData
            // 
            this.ClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearData.Location = new System.Drawing.Point(27, 335);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(219, 38);
            this.ClearData.TabIndex = 17;
            this.ClearData.Text = "Очистить данные";
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1072, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Использовать часы-кол-во (test)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(924, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 517);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // AddDays
            // 
            this.AddDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDays.Location = new System.Drawing.Point(27, 239);
            this.AddDays.Name = "AddDays";
            this.AddDays.Size = new System.Drawing.Size(219, 38);
            this.AddDays.TabIndex = 12;
            this.AddDays.Text = "Принять дни";
            this.AddDays.UseVisualStyleBackColor = true;
            this.AddDays.Click += new System.EventHandler(this.AddDays_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(27, 210);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 20);
            this.textBox7.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Рабочие дни";
            // 
            // AddWeeks
            // 
            this.AddWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWeeks.Location = new System.Drawing.Point(27, 113);
            this.AddWeeks.Name = "AddWeeks";
            this.AddWeeks.Size = new System.Drawing.Size(219, 39);
            this.AddWeeks.TabIndex = 9;
            this.AddWeeks.Text = "Добавить недели";
            this.AddWeeks.UseVisualStyleBackColor = true;
            this.AddWeeks.Click += new System.EventHandler(this.AddWeeks_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Рабочие недели";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PrintPrepods);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.EndOfEnterPrepod);
            this.panel3.Controls.Add(this.AddPrepod);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.EndOfEntPrep);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Location = new System.Drawing.Point(618, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 581);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // PrintPrepods
            // 
            this.PrintPrepods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintPrepods.Location = new System.Drawing.Point(0, 482);
            this.PrintPrepods.Name = "PrintPrepods";
            this.PrintPrepods.Size = new System.Drawing.Size(300, 35);
            this.PrintPrepods.TabIndex = 12;
            this.PrintPrepods.Text = "Просмотр преподавателей";
            this.PrintPrepods.UseVisualStyleBackColor = true;
            this.PrintPrepods.Click += new System.EventHandler(this.PrintPrepods_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(293, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // EndOfEnterPrepod
            // 
            this.EndOfEnterPrepod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndOfEnterPrepod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndOfEnterPrepod.Location = new System.Drawing.Point(0, 332);
            this.EndOfEnterPrepod.Name = "EndOfEnterPrepod";
            this.EndOfEnterPrepod.Size = new System.Drawing.Size(300, 38);
            this.EndOfEnterPrepod.TabIndex = 10;
            this.EndOfEnterPrepod.Text = "Прервать добавление преподавателей";
            this.EndOfEnterPrepod.UseVisualStyleBackColor = true;
            this.EndOfEnterPrepod.Visible = false;
            this.EndOfEnterPrepod.Click += new System.EventHandler(this.EndOfEnterPrepod_Click);
            // 
            // AddPrepod
            // 
            this.AddPrepod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPrepod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPrepod.Location = new System.Drawing.Point(0, 157);
            this.AddPrepod.Name = "AddPrepod";
            this.AddPrepod.Size = new System.Drawing.Size(300, 49);
            this.AddPrepod.TabIndex = 9;
            this.AddPrepod.Text = "Добавить преподавателя";
            this.AddPrepod.UseVisualStyleBackColor = true;
            this.AddPrepod.Visible = false;
            this.AddPrepod.Click += new System.EventHandler(this.AddPrepod_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вы пока не вводили данные";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Последние введенные данные";
            // 
            // EndOfEntPrep
            // 
            this.EndOfEntPrep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EndOfEntPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndOfEntPrep.Location = new System.Drawing.Point(0, 539);
            this.EndOfEntPrep.Name = "EndOfEntPrep";
            this.EndOfEntPrep.Size = new System.Drawing.Size(300, 42);
            this.EndOfEntPrep.TabIndex = 6;
            this.EndOfEntPrep.Text = "Завершить добавление";
            this.EndOfEntPrep.UseVisualStyleBackColor = true;
            this.EndOfEntPrep.Click += new System.EventHandler(this.EndOfEntPrep_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите предмет";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО Преподователя ";
            this.label1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(3, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Visible = false;
            // 
            // AddPrepods
            // 
            this.AddPrepods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPrepods.Location = new System.Drawing.Point(618, 33);
            this.AddPrepods.Name = "AddPrepods";
            this.AddPrepods.Size = new System.Drawing.Size(226, 37);
            this.AddPrepods.TabIndex = 5;
            this.AddPrepods.Text = "Добавить преподавателей";
            this.AddPrepods.UseVisualStyleBackColor = true;
            this.AddPrepods.Click += new System.EventHandler(this.AddPrepods_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PrintGroups);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.EndOfEntrPars);
            this.panel2.Controls.Add(this.HrParsLabel);
            this.panel2.Controls.Add(this.ParLabel);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.AddPars_Bttn);
            this.panel2.Controls.Add(this.AddGrp_bttn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.LabelNameGrp);
            this.panel2.Controls.Add(this.EndOfAddGrps);
            this.panel2.Location = new System.Drawing.Point(287, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 581);
            this.panel2.TabIndex = 4;
            // 
            // PrintGroups
            // 
            this.PrintGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintGroups.Location = new System.Drawing.Point(0, 482);
            this.PrintGroups.Name = "PrintGroups";
            this.PrintGroups.Size = new System.Drawing.Size(300, 35);
            this.PrintGroups.TabIndex = 19;
            this.PrintGroups.Text = "Просмотр групп";
            this.PrintGroups.UseVisualStyleBackColor = true;
            this.PrintGroups.Click += new System.EventHandler(this.PrintGroups_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вы пока не вводили данные";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Последние введенные данные";
            // 
            // EndOfEntrPars
            // 
            this.EndOfEntrPars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndOfEntrPars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndOfEntrPars.Location = new System.Drawing.Point(0, 332);
            this.EndOfEntrPars.Name = "EndOfEntrPars";
            this.EndOfEntrPars.Size = new System.Drawing.Size(300, 38);
            this.EndOfEntrPars.TabIndex = 14;
            this.EndOfEntrPars.Text = "Завершить набор пар";
            this.EndOfEntrPars.UseVisualStyleBackColor = true;
            this.EndOfEntrPars.Click += new System.EventHandler(this.EndOfEntrPars_Click);
            // 
            // HrParsLabel
            // 
            this.HrParsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HrParsLabel.AutoSize = true;
            this.HrParsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HrParsLabel.Location = new System.Drawing.Point(186, 97);
            this.HrParsLabel.Name = "HrParsLabel";
            this.HrParsLabel.Size = new System.Drawing.Size(40, 16);
            this.HrParsLabel.TabIndex = 13;
            this.HrParsLabel.Text = "Часы";
            // 
            // ParLabel
            // 
            this.ParLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParLabel.AutoSize = true;
            this.ParLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParLabel.Location = new System.Drawing.Point(4, 97);
            this.ParLabel.Name = "ParLabel";
            this.ParLabel.Size = new System.Drawing.Size(41, 16);
            this.ParLabel.TabIndex = 12;
            this.ParLabel.Text = "Пара";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(189, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(6, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 10;
            // 
            // AddPars_Bttn
            // 
            this.AddPars_Bttn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPars_Bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPars_Bttn.Location = new System.Drawing.Point(0, 157);
            this.AddPars_Bttn.Name = "AddPars_Bttn";
            this.AddPars_Bttn.Size = new System.Drawing.Size(300, 49);
            this.AddPars_Bttn.TabIndex = 7;
            this.AddPars_Bttn.Text = "Пара + часы";
            this.AddPars_Bttn.UseVisualStyleBackColor = true;
            this.AddPars_Bttn.Click += new System.EventHandler(this.AddPars_Bttn_Click);
            // 
            // AddGrp_bttn
            // 
            this.AddGrp_bttn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGrp_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGrp_bttn.Location = new System.Drawing.Point(0, 57);
            this.AddGrp_bttn.Name = "AddGrp_bttn";
            this.AddGrp_bttn.Size = new System.Drawing.Size(300, 28);
            this.AddGrp_bttn.TabIndex = 6;
            this.AddGrp_bttn.Text = "Добавить название группы";
            this.AddGrp_bttn.UseVisualStyleBackColor = true;
            this.AddGrp_bttn.Click += new System.EventHandler(this.AddGrp_bttn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 19);
            this.textBox1.TabIndex = 5;
            // 
            // LabelNameGrp
            // 
            this.LabelNameGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameGrp.AutoEllipsis = true;
            this.LabelNameGrp.AutoSize = true;
            this.LabelNameGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameGrp.Location = new System.Drawing.Point(4, 2);
            this.LabelNameGrp.Name = "LabelNameGrp";
            this.LabelNameGrp.Size = new System.Drawing.Size(123, 16);
            this.LabelNameGrp.TabIndex = 4;
            this.LabelNameGrp.Text = "Название группы";
            this.LabelNameGrp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndOfAddGrps
            // 
            this.EndOfAddGrps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EndOfAddGrps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndOfAddGrps.Location = new System.Drawing.Point(0, 539);
            this.EndOfAddGrps.Name = "EndOfAddGrps";
            this.EndOfAddGrps.Size = new System.Drawing.Size(300, 42);
            this.EndOfAddGrps.TabIndex = 3;
            this.EndOfAddGrps.Text = "Завершить добавление групп";
            this.EndOfAddGrps.UseVisualStyleBackColor = true;
            this.EndOfAddGrps.Click += new System.EventHandler(this.EndOfAddGrps_Click);
            // 
            // CreateGroups
            // 
            this.CreateGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateGroups.Location = new System.Drawing.Point(287, 33);
            this.CreateGroups.Name = "CreateGroups";
            this.CreateGroups.Size = new System.Drawing.Size(226, 37);
            this.CreateGroups.TabIndex = 2;
            this.CreateGroups.Text = "Добавить группы";
            this.CreateGroups.UseVisualStyleBackColor = true;
            this.CreateGroups.Click += new System.EventHandler(this.CreateGroups_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(99, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 39);
            this.label13.TabIndex = 28;
            this.label13.Text = "LSh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LSh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateRasp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EndOfAddGrps;
        private System.Windows.Forms.Label LabelNameGrp;
        private System.Windows.Forms.Button AddGrp_bttn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddPars_Bttn;
        private System.Windows.Forms.Label HrParsLabel;
        private System.Windows.Forms.Label ParLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddPrepods;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button EndOfEntPrep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button AddDays;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddWeeks;
        private System.Windows.Forms.Button EndOfEntrPars;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddPrepod;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button EndOfEnterPrepod;
        private System.Windows.Forms.Button SaveExcel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button PrintGroups;
        private System.Windows.Forms.Button PrintPrepods;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SaveCSV;
        private System.Windows.Forms.Label label13;
    }
}

