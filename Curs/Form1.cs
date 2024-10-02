using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Text;

namespace Curs
{
    public partial class Form1 : Form
    {
        public struct ParsGroup // структура данных для словаря
        {
            internal string NamePar;
            internal int CountPar;
        }

        // ВХОДНЫЕ ДАННЫЕ
        internal Dictionary<string, List<ParsGroup>> groups = new Dictionary<string, List<ParsGroup>>(); // входные данные
        private int WorkWeeks; // входные данные
        internal Dictionary<string, List<string>> prepodovat = new Dictionary<string, List<string>>(); // входные данные
        private int RabDays;
        // ОКОНЧАНИЕ ВХОДНЫХ ДАННЫХ

        // ПЕРЕМЕННЫЕ ДАННЫЕ
        internal Dictionary<string, List<List<string>>> raspgroupsfull = new Dictionary<string, List<List<string>>>(); // будем хранить итоговое расписание
        private double PPD; // хранить кол-во пар на день
        private string KeyFromComboBox;
        private byte chk; // чек для изм. группы
        private byte chk2; // чек для изм. пар группы
        private byte chk3 = 0;
        // ОКОНЧАНИЕ ПЕРЕМЕННЫХ ДАННЫХ

        // ПЕРЕМЕННАЯ СОХРАНЕНИЯ
        private Excel.Application excelapp = new Excel.Application();
        private string ispolfile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        internal string filePathEx;
        internal string filePathCSV;
        // ОКОНЧАНИЕ ПЕРЕМЕННАЯ СОХРАНЕНИЯ 

        public Form1()
        {
            InitializeComponent();
        }

        public int CreateRaspF(int WorkWeeks, int RabDays, string key) // добавим потом в передачу словарь
        {
            int days = WorkWeeks * RabDays; // кол-во раб дней
            int kolvo = 0; // сумма кол-ва пар на неделю
            List<List<string>> rand = new List<List<string>>(); // расписание одной группы

            var par_kolv = new Dictionary<string, int>(); // пара : кол-во на раб неделю, словарь

            int PPW = 0; // Количество часов всего
            int chkPPD;

            List<ParsGroup> list = groups[key];

            double o;

            foreach (ParsGroup grp in list)
            {
                string name = grp.NamePar;
                int count = grp.CountPar;
                PPW += count;
                if (count == 0)
                {
                    //Console.WriteLine($"Пара {name} имеет 0 часов."); // предупреждение
                }
                o = (double)count / WorkWeeks;
                if (((int)o == 0) && (count != 0))
                {
                    par_kolv.Add(name, 1); // добавление в словарь пара : кол-во
                    continue;
                }
                if ((o != 0) && (o > 0.2))
                {
                    par_kolv.Add(name, (int)Math.Round(o + 0.0001)); // добавление в словарь пара : кол-во
                }
            }

            PPD = (double)PPW / days; // пар в день
            PPD = Math.Ceiling(PPD);
            chkPPD = (int)PPD;

            foreach (var per in par_kolv)
            {
                kolvo += per.Value;
            }

            double NoPairCount = (int)PPD - (kolvo % PPD);

            if (NoPairCount == PPD)
            {
                NoPairCount = 0;
            }
            else
            {
                par_kolv.Add("-", (int)NoPairCount); // добавление пустышек
            }

            Random random = new Random(); // переменная отвечающая за рандомный номер
            Dictionary<string, int> par_kolv1 = par_kolv.ToDictionary(entry => entry.Key, entry => entry.Value); // создание копии словаря

            int count1 = 0; // для подсчёта кол-во попыток генерации расписания
            while (true)
            {
                for (int i = 0; i < RabDays; i++)
                {
                    List<string> random_subject = par_kolv.Keys.OrderBy(x => random.Next()).Take((int)PPD).ToList(); // генерирует расписание на день

                    rand.Add(random_subject); // добавляем массив с парами на день
                    foreach (string j in rand[i])
                    {
                        par_kolv[j] -= 1; // на i иттерации мы уменьшаем кол-во этого (j) предмета на 1
                        if (par_kolv[j] == 0)
                        {
                            par_kolv.Remove(j); // если кол-во этого предмета уже равно 0, то удаляем его из словаря
                        }
                    }
                }
                if (par_kolv.Keys.Count == 0)
                {
                    break; // если все пары растусованы, то мы заканчиваем цикл
                }
                else
                {
                    rand.Clear(); // очищаем массив с расписанием для того, чтобы заново сделать расписание
                    par_kolv.Clear(); // очистка словаря для дальнейшего восстановления через копию
                    par_kolv = new Dictionary<string, int>(par_kolv1); // обнуление и последующее использование копии словаря
                    count1++; // кол-во попыток составить расписание
                    if (count1 > 5500) // добавил проверку, если количество попыток превышает 500, то уже пора заканчивать, скорее невозможно составить расписание по заданным параметрам.
                    {
                        //Console.WriteLine($"Не получается составить расписание по заданным параметрам. Количество попыток создания расписания на рабочую неделю составляет {count1}.");
                        MessageBox.Show("Не удалось составить расписание с имеющимися данными для группы " + key + "\nКоличество попыток составляет " + count1, "Ошибка");
                        break;
                    }
                }
            }

            // начало обмена переменными
            for (int i = 0; i < rand.Count; i++)
            {
                //List<string> mas = rand[i];
                if (rand[i].Contains("-"))
                {
                    int index = rand[i].IndexOf("-");
                    string temp = rand[i][index];
                    rand[i][index] = rand[i][rand[i].Count - 1];
                    rand[i][rand[i].Count - 1] = temp;
                } // обмен переменными для того, чтобы пустышку постаивть в конец дня
            }

            // вывод расписания, можно будет закомментировать
            foreach (List<string> i in rand)
            {
                string a = string.Join(",", i);
                //Console.WriteLine($"A: {a}");
            }

            if (!raspgroupsfull.ContainsKey(key))
            {
                raspgroupsfull.Add(key, rand); // добавляем в словарь название группы + её расписание
            }

            else
            {
                return 0;
            }

            if (PPD < chkPPD)
            {
                PPD = chkPPD;
            }
            return 0; // чтобы точно завершилась
        } // КОНЕЦ ФУНКЦИИ СОЗДАНИЯ РАСПИСАНИЯ

        private int SortWithPrep() // Сортировка полученного расписания с преподавателями
        {
            List<List<string>> MainMas = new List<List<string>>();


            foreach (var keygrp in raspgroupsfull)
            {
                foreach (var oio in keygrp.Value)
                {
                    MainMas.Add(oio);
                }
            }

            int flager = 0;

            for (int i = 0; i < MainMas.Count; i++)
            {
                for (int j = 0; j < MainMas[i].Count; j++)
                {
                    try
                    {
                        string pair = MainMas[i][j];
                        if (prepodovat.ContainsKey(pair))
                        {
                            if (prepodovat[MainMas[i][j]] == prepodovat[MainMas[i + RabDays][j]])
                            {
                                //Console.WriteLine($"Педмет 1 гр: {MainMas[i][j]} [id] {i + 1} {j + 1} - {MainMas[i + 6][j]}");
                                flager++;
                                if (j < (int)(PPD / 2))
                                {
                                    string temp = MainMas[i][j];
                                    MainMas[i][j] = MainMas[i][j + 1];
                                    MainMas[i][j + 1] = temp;
                                }
                                if (j > (int)(PPD / 2) - 1)
                                {
                                    string temp = MainMas[i][j];
                                    MainMas[i][j] = MainMas[i][j - 1];
                                    MainMas[i][j - 1] = temp;
                                }
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        

            if (flager > 0)
            {
                try
                {
                    List<string> keyss = new List<string>();

                    foreach (var ioq in raspgroupsfull)
                    {
                        keyss.Add(ioq.Key);
                    }

                    raspgroupsfull.Clear();

                    foreach (string uu in keyss)
                    {
                        raspgroupsfull.Add(uu, new List<List<string>>());
                    }

                    foreach (var ttt in raspgroupsfull)
                    {
                        List<List<string>> temppp = new List<List<string>>();
                        for (int i = RabDays; i < MainMas.Count; i += RabDays)
                        {
                            temppp = MainMas.Take(i).ToList();
                            raspgroupsfull[ttt.Key] = temppp;
                        }
                    }
                }
                catch
                {
                    raspgroupsfull.Clear();
                    foreach (var iiii in groups)
                    {
                        CreateRaspF(WorkWeeks, RabDays, iiii.Key);
                    }
                }
            }

            return 0;
        }// КОНЕЦ ФУНКЦИИ сортировки расписания

        private void PrintItog() // вывод расписания в dataGridView1
        {
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Название группы", "Group");
                dataGridView1.Columns.Add("Day", "Day");
                dataGridView1.Columns.Add("Schedule", "Schedule");
            }

            foreach (var pair in raspgroupsfull)
            {
                string groupName = pair.Key;
                List<List<string>> temper = pair.Value;
                bool isFirstGroup = true;

                for (int i = 0; i < temper.Count; i++)
                {
                    string day = $"День {i + 1}";

                    // Выводить название группы только один раз
                    if (isFirstGroup)
                    {
                        DataGridViewRow groupRow = new DataGridViewRow();
                        groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = groupName });
                        groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        dataGridView1.Rows.Add(groupRow);
                        isFirstGroup = false;
                    }

                    DataGridViewRow dayRow = new DataGridViewRow();
                    dayRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                    dayRow.Cells.Add(new DataGridViewTextBoxCell { Value = day });
                    dayRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                    dataGridView1.Rows.Add(dayRow);

                    for (int j = 0; j < temper[i].Count; j++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = temper[i][j] });
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        } // КОНЕЦ функции

        private void SortPrepods() // Сортировка преподавателей.
        {
            var keys = new List<string>(prepodovat.Keys);
            for (int i = 0; i < keys.Count; i++)
            {
                string key1 = keys[i];
                List<string> name1 = new List<string>(prepodovat[key1]);
                for (int j = 0; j < keys.Count; j++)
                {
                    string key2 = keys[j];
                    if (key1 != key2)
                    {
                        List<string> name2 = new List<string>(prepodovat[key2]);
                        for (int k = 0; k < name1.Count; k++)
                        {
                            for (int l = 0; l < name2.Count; l++)
                            {
                                if (name1[k] == name2[l] && name1.Count > name2.Count)
                                {
                                    prepodovat[key2] = new List<string>(name1);
                                }
                                if (name1[k] == name2[l] && name1.Count < name2.Count)
                                {
                                    prepodovat[key1] = new List<string>(name2);
                                }
                            }
                        }
                    }
                }
            }
        } // Конец сортировки

        internal void SaveAsExcel() // Сохрание как файл Excel
        {
            List<string> daysweeks = new List<string>() { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            try
            {
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Расписание";

                worksheet.Cells[1, 1] = "Расписание в УО \"СГАЭК\"";
                worksheet.Cells[1, 1].Font.Size = 14;
                Excel.Range mergeName = worksheet.Range["A1:D1"];
                mergeName.Merge(); // 2 строчки объединяют ячейки с А1 до Д1 и помещают текст по центру

                int startstolb = 2; // начальная строка для расписания группы
                bool flagfordw = true;

                foreach (var inra in raspgroupsfull)
                {
                    int indfordw = 0;
                    int startcolondw = 3;
                    int startstr = 3;
                    string namegr = inra.Key;
                    worksheet.Cells[2, startstolb] = namegr;

                    List<List<string>> raspis = new List<List<string>>(inra.Value);
                    for (int i = 0; i < raspis.Count; i++)
                    {
                        if (flagfordw == true)
                        {
                            if (raspis.Count <= daysweeks.Count)
                            {
                                worksheet.Cells[startcolondw, 1] = daysweeks[indfordw];
                                indfordw++;
                            }

                            if (raspis.Count > daysweeks.Count)
                            {
                                worksheet.Cells[startcolondw, 1] = daysweeks[indfordw];
                                indfordw++;
                                if (indfordw > 5)
                                {
                                    indfordw = 0;
                                }
                            }

                            startstr = startcolondw;
                            startcolondw += ((int)PPD + 1);
                        }
                        else
                        {
                            startstr = startcolondw;
                            startcolondw += ((int)PPD + 1);
                        }

                        for (int j = 0; j < raspis[i].Count; j++)
                        {
                            worksheet.Cells[startstr, startstolb] = raspis[i][j];
                            startstr++;
                        }
                        startstr++;
                    }
                    flagfordw = false;
                    startstolb++;
                }

                // сохранение

                if (File.Exists(filePathEx))
                {
                    File.Delete(filePathEx);
                }

                MessageBox.Show("Успешно сохранено в " + filePathEx);

                workbook.SaveAs(filePathEx);
                excelapp.Quit();
                // конец сохранения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } // Конец функции сохранения

        internal void SaveAsCSV()
        {
            List<string> daysweeks = new List<string>() { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            try
            {
                using (StreamWriter write = new StreamWriter(filePathCSV, false, Encoding.UTF8))
                {
                    bool flagfordw = true;

                    write.WriteLine("Расписание в УО \"СГАЭК\"");

                    foreach (var inra in raspgroupsfull)
                    {
                        int indfordw = 0;
                        string namegr = inra.Key;
                        write.WriteLine(namegr);
                        write.WriteLine();

                        List<List<string>> raspis = new List<List<string>>(inra.Value);
                        for (int i = 0; i < raspis.Count; i++)
                        {
                            if (flagfordw == true)
                            {
                                if (raspis.Count <= daysweeks.Count)
                                {
                                    write.WriteLine(daysweeks[indfordw]);
                                    indfordw++;
                                }

                                if (raspis.Count > daysweeks.Count)
                                {
                                    write.WriteLine(daysweeks[indfordw]);
                                    indfordw++;
                                    if (indfordw > 5)
                                    {
                                        indfordw = 0;
                                    }
                                }

                            }

                            for (int j = 0; j < raspis[i].Count; j++)
                            {
                                write.WriteLine(raspis[i][j]);
                            }
                            write.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Успешно сохранено в " + filePathCSV + "\n\nПримечание: Cохранение вывода в формате CSV отличается от сохранения вывода сразу в Excel файле (xlsx)");

                // конец сохранения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(ispolfile, "Save");
            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            filePathEx = Path.Combine(folderPath, "Output_Rasp.xlsx");
            filePathCSV = Path.Combine(folderPath, "Output_Rasp.csv");
            panel2.Visible = false;
            panel1.Visible = true;
            CreateGroups.Visible = true;
            CreateRasp.Visible = true;
        }

        private void CreateRasp_Click(object sender, EventArgs e)
        {
            raspgroupsfull.Clear();
            //Console.WriteLine("0");
            foreach (var namegr in groups)
            {
                CreateRaspF(WorkWeeks, RabDays, namegr.Key);
            }
            //Console.WriteLine("1");
            SortWithPrep();
            //Console.WriteLine("2");
            PrintItog();
            dataGridView1.Visible = true;
            //Console.WriteLine("3");
        }

        private void CreateGroups_Click(object sender, EventArgs e) // Кнопка отвечающая за открытие панели, в которой будет происходить заполнение словаря "Группа : {Название пары: кол-во пар}"
        {
            LabelNameGrp.Visible = true;
            textBox1.Visible = true;
            AddGrp_bttn.Visible = true;
            EndOfEntrPars.Visible = false;
            CreateGroups.Visible = false;
            panel2.Visible = true;
            AddPars_Bttn.Visible = false;
            ParLabel.Visible = false;
            HrParsLabel.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void EndOfAddGrps_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            panel2.Visible = false;
            CreateGroups.Visible = true;
            HashSet<string> tempforcmbox = new HashSet<string>();

            foreach (var key1 in groups)
            {
                List<ParsGroup> val1 = new List<ParsGroup>(key1.Value);
                foreach (var val2 in val1)
                {
                    tempforcmbox.Add(val2.NamePar);
                }
            }

            foreach (string name in tempforcmbox)
            {
                comboBox2.Items.Add(name);
            }
        }

        private void AddGrp_bttn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9899")
            {
                if (chk3 == 0)
                {
                    chk3 = 1;
                    groups.Add("Б79", new List<ParsGroup>
                {
                    new ParsGroup { NamePar = "Матем", CountPar = 30},
                    new ParsGroup { NamePar = "Биология", CountPar = 20},
                    new ParsGroup { NamePar = "Англ", CountPar = 22},
                    new ParsGroup { NamePar = "Физра", CountPar = 30},
                    new ParsGroup { NamePar = "Инфа", CountPar = 25},
                    new ParsGroup { NamePar = "Рус. лит", CountPar = 15},
                    new ParsGroup { NamePar = "Всем. истр.", CountPar = 18},
                    new ParsGroup { NamePar = "Астрономия", CountPar = 19},
                    new ParsGroup { NamePar = "Бел. лит", CountPar = 23},
                    new ParsGroup { NamePar = "Черчение", CountPar = 26},
                    new ParsGroup { NamePar = "Физика", CountPar = 17},
                    new ParsGroup { NamePar = "Общество", CountPar = 20},
                });
                    groups.Add("П18", new List<ParsGroup>
                {
                    new ParsGroup { NamePar = "Черчение", CountPar = 17},
                    new ParsGroup { NamePar = "Матем", CountPar = 35},
                    new ParsGroup { NamePar = "Биология", CountPar = 27},
                    new ParsGroup { NamePar = "Физра", CountPar = 25},
                    new ParsGroup { NamePar = "Астрономия", CountPar = 13},
                    new ParsGroup { NamePar = "Англ", CountPar = 24},
                    new ParsGroup { NamePar = "Рус. лит", CountPar = 20},
                    new ParsGroup { NamePar = "Бел. истр.", CountPar = 28},
                    new ParsGroup { NamePar = "Бел. лит", CountPar = 20},
                    new ParsGroup { NamePar = "Физика", CountPar = 18},
                    new ParsGroup { NamePar = "География", CountPar = 12},
                    new ParsGroup { NamePar = "Общество", CountPar = 12},
                });
                    groups.Add("Л6", new List<ParsGroup>
                {
                    new ParsGroup { NamePar = "Химия", CountPar = 24},
                    new ParsGroup { NamePar = "Бел. лит", CountPar = 27},
                    new ParsGroup { NamePar = "Физра", CountPar = 29},
                    new ParsGroup { NamePar = "Матем", CountPar = 35},
                    new ParsGroup { NamePar = "Физика", CountPar = 21},
                    new ParsGroup { NamePar = "Информатика", CountPar = 23},
                    new ParsGroup { NamePar = "Астрономия", CountPar = 14},
                    new ParsGroup { NamePar = "Англ", CountPar = 30},
                    new ParsGroup { NamePar = "ДП", CountPar = 23},
                    new ParsGroup { NamePar = "Рус. лит", CountPar = 14},
                    new ParsGroup { NamePar = "Общество", CountPar = 19},
                });
                    prepodovat = new Dictionary<string, List<string>>()
                {
                    { "Матем", new List<string> { "Павловна" } },
                    { "Биология", new List<string> { "Багаева" } },
                    { "Англ", new List<string> { "Над" } },
                    { "Физра", new List<string> { "Кузьмич" } },
                    { "Инфа", new List<string> { "Стасевич" } },
                    { "Рус. лит", new List<string> { "Володько" } },
                    { "Всем. истр", new List<string> { "Бородич" } },
                    { "Астрономия", new List<string> { "Климович" } },
                    { "Бел. лит", new List<string> { "Чех" } },
                    { "Черчение", new List<string> { "Вероха" } },
                    { "Физика", new List<string> { "Климович" } },
                    { "Общество", new List<string> { "Бородич" } },
                    { "Бел. истр.", new List<string> { "Бородич" } },
                    { "География", new List<string> { "Бородич" } },
                    { "ДП", new List<string> { "Кузьмич" } },
                    { "Химия", new List<string> { "Филлип" } },
                };
                    label8.Text = "Код 9899 активирован";
                }
                else
                {
                    label8.Text = "Код 9899 уже был активирован";
                }
            }

            if (textBox1.Text != "9899")
            {
                if (groups.ContainsKey(textBox1.Text))
                {
                    label8.Text = "Эта группа уже была добавлена.\nЕсли желаете добавить пары для этой группы нажмите добавить название.";
                    if (chk < 2)
                    {
                        chk++;
                    }
                    if (chk == 2)
                    {
                        AddGrp_bttn.Visible = false;
                        LabelNameGrp.Visible = false;
                        textBox1.Visible = false;
                        ParLabel.Visible = true;
                        HrParsLabel.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        AddPars_Bttn.Visible = true;
                        EndOfEntrPars.Visible = true;
                    }
                }
                else
                {
                    groups.Add(textBox1.Text, new List<ParsGroup>());
                    AddGrp_bttn.Visible = false;
                    LabelNameGrp.Visible = false;
                    textBox1.Visible = false;
                    ParLabel.Visible = true;
                    HrParsLabel.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    AddPars_Bttn.Visible = true;
                    EndOfEntrPars.Visible = true;
                }
            }
        }

        private void AddPrepods_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            AddPrepods.Visible = false;
            AddPrepod.Visible = false;
            textBox4.Visible = false;
            label1.Visible = false;
            comboBox2.Visible = true;
            label2.Visible = true;
        }

        private void AddPars_Bttn_Click(object sender, EventArgs e)
        {
            List<ParsGroup> forgr = new List<ParsGroup>();
            forgr = groups[textBox1.Text];
            int cnt;
            bool found = false;
            int.TryParse(textBox3.Text, out cnt);
            if (!groups[textBox1.Text].Any(group => group.NamePar == textBox2.Text))
            {
                forgr.Add(new ParsGroup { NamePar = textBox2.Text, CountPar = cnt });
                label8.Text = "Группа: " + textBox1.Text + " Пара: " + textBox2.Text + " \nЧасы пары: " + textBox3.Text;
            }
            else
            {
                label8.Text = "Вы уже добавляли " + textBox2.Text + " в группу " + textBox1.Text;
                if (chk2 < 2)
                {
                    chk2++;
                }
                if (chk2 == 2)
                {
                    forgr = forgr.Select(group =>
                    {
                        if (group.NamePar == textBox2.Text)
                        {
                            group.CountPar = cnt;
                            found = true;
                        }
                        return group;
                    }).ToList();

                    if (!found)
                    {
                        forgr.Add(new ParsGroup { NamePar = textBox2.Text, CountPar = cnt });
                    }

                    groups[textBox1.Text] = forgr; // Обновляем значение в словаре

                    label8.Text = "Группа: " + textBox1.Text + " Пара (изменена): " + textBox2.Text + " \nЧасы пары (изменены): " + textBox3.Text;
                }

            }
        }

        private void EndOfEntrPars_Click(object sender, EventArgs e)
        {
            if (groups[textBox1.Text].Count == 0)
            {
                groups.Remove(textBox1.Text);
            }

            EndOfEntrPars.Visible = false;
            ParLabel.Visible = false;
            HrParsLabel.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            AddPars_Bttn.Visible = false;
            AddGrp_bttn.Visible = true;
            textBox1.Visible = true;
            LabelNameGrp.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void AddWeeks_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox6.Text, out WorkWeeks))
            {
                label10.Text = "Внимание, вы ввели не целочисленное значение.";
            }
            else
            {

                if (WorkWeeks < 1)
                {
                    label10.Text = "Не может быть " + textBox6.Text + " недель";
                }
                else
                {
                    label10.Text = "Количество рабочих недель " + textBox6.Text;
                }
            }
        }

        private void AddDays_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox7.Text, out RabDays))
            {
                label11.Text = "Внимание, вы ввели не целочисленное значение.";
            }
            else
            {
                if (RabDays < 4)
                {
                    label11.Text = "Слишком малеьнкое количество рабочих дней (" + textBox7.Text + ")";
                }
                else if (RabDays > 7)
                {
                    label11.Text = "Слишком большое количество рабочих дней (" + textBox7.Text + ")";
                }
                else
                {
                    label11.Text = "Количество рабочих дней " + textBox7.Text;
                }
            }
        }

        private void EndOfEntPrep_Click(object sender, EventArgs e) // завершить в панели добавления преподов
        {
            panel3.Visible = false;
            AddPrepods.Visible = true;
            SortPrepods();
        }

        private void AddPrepod_Click(object sender, EventArgs e)
        {
            List<string> temper = new List<string>(prepodovat[KeyFromComboBox]);
            temper.Add(textBox4.Text);
            prepodovat[KeyFromComboBox] = temper;

            label6.Text = "Предмет: " + KeyFromComboBox + "; \nФИО преподавателя: " + textBox4.Text;
        }

        private void EndOfEnterPrepod_Click(object sender, EventArgs e)
        {
            if (prepodovat[KeyFromComboBox].Count < 1)
            {
                prepodovat.Remove(KeyFromComboBox);
            }
            EndOfEnterPrepod.Visible = false;
            AddPrepod.Visible = false;
            textBox4.Visible = false;
            label1.Visible = false;
            comboBox2.Visible = true;
            label2.Visible = true;
            textBox4.Text = "";
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно желаете очистить данные?", "Предупреждение", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) 
            {
                groups.Clear();
                prepodovat.Clear();
                WorkWeeks = 0;
                RabDays = 0;
                raspgroupsfull.Clear();
                PPD = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label10.Text = "Количество рабочих недель 0";
                label11.Text = "Количество рабочих дней 0";
                label8.Text = "Вы пока не вводили данные";
                label6.Text = "Вы пока не вводили данные";
                dataGridView1.Rows.Clear();
                dataGridView1.Visible = false;
                comboBox1.Text = "Справочная";
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                chk3 = 0;
                panel2.Visible = false;
                panel3.Visible = false;
                MessageBox.Show("Данные успешно очищены", "Предупреждение");
            }

            else
            {
                MessageBox.Show("Вы отказались очищать данные", "Предупреждение");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = comboBox1.SelectedItem.ToString();

            if (selectItem == "Как пользоваться")
            {
                MessageBox.Show("Чтобы создать расписание необходимо: \n1 Ввести количество рабочих недель;\n1.2 Подтвердить;\n2 Провести такую же операцию для рабочих дней;\n3 Добавить группы следуя инструкции; \n4 Добавить преподавателей следуя инструкции; \n5 Создать расписание.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyFromComboBox = comboBox2.SelectedItem.ToString();
            if (prepodovat.ContainsKey(KeyFromComboBox))
            {
                label6.Text = "На эту пару уже имеются преподаватели.";
            }
            else
            {
                prepodovat.Add(KeyFromComboBox, new List<string>());
            }
            label1.Visible = true;
            textBox4.Visible = true;
            AddPrepod.Visible = true;
            EndOfEnterPrepod.Visible = true;
        }

        private void SaveExcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Примечание\nПри сохранении в формате Excel файла убедитесь: \n1. Установлен у вас Microsoft Office Excel? \n2. Есть ли место на диске (так как Excel файл весит больше CSV файла). \n\nВы можете отказаться от сохранения в Excel закрыв это окно или нажав на соответствующую кнопку.", "Предупреждение", MessageBoxButtons.YesNoCancel);
            
            if (result == DialogResult.Yes)
            {
                SaveAsExcel();
            }
            else
            {
                MessageBox.Show("Вы отказались от сохранения в Excel. (xlsx)", "Отказ");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            excelapp.Quit();
        }

        private void PrintGroups_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.PrintItog(groups);
            form2.groups = groups;
        }

        private void PrintPrepods_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.PrintItog(prepodovat);
            form3.prepodovat = prepodovat;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveCSV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Желаете сохранить полученный вывод в формате CSV? \nЕсли нет, просто закройте окно или нажмите на соответствующую кнопку.", "Предупреждение", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes )
            {
                SaveAsCSV();
            }
            else
            {
                MessageBox.Show("Вы отказались сохранять полученный вывод в формате CSV.", "Отказ");
            }
        }
    }
}
