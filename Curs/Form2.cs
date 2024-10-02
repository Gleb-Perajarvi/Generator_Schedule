using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Curs.Form1;

namespace Curs
{
    public partial class Form2 : Form
    {
        public Dictionary<string, List<ParsGroup>> groups = new Dictionary<string, List<ParsGroup>>();
        private string NameGrp;

        public Form2()
        {
            Form1 form1 = new Form1();
            groups = form1.groups;
            NameGrp = NameGrp;
            InitializeComponent();
        }

        public void PrintItog(Dictionary<string, List<ParsGroup>> groups)
        {
            if (groups.Count == 0)
            {
                dataGridView1.Visible = false;
                label1.Text = "Увы, нет данных об группах.";
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Удалить все группы");
                comboBox2.Items.Clear();
                dataGridView1.Rows.Clear();

                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Название группы", "Group");
                    dataGridView1.Columns.Add("Пара", "Para");
                    dataGridView1.Columns.Add("Часы", "Hrs");
                }

                foreach (var pair in groups)
                {
                    string groupName = pair.Key;
                    comboBox1.Items.Add(groupName);
                    List<ParsGroup> temper = new List<ParsGroup>(pair.Value);
                    bool isFirstGroup = true;

                    foreach (var group in temper)
                    {
                        if (isFirstGroup)
                        {
                            DataGridViewRow groupRow = new DataGridViewRow();
                            groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = groupName });
                            groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                            groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                            dataGridView1.Rows.Add(groupRow);
                            isFirstGroup = false;
                        }
                        DataGridViewRow parhrsRow = new DataGridViewRow();
                        parhrsRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        parhrsRow.Cells.Add(new DataGridViewTextBoxCell { Value = group.NamePar });
                        parhrsRow.Cells.Add(new DataGridViewTextBoxCell { Value = group.CountPar });
                        dataGridView1.Rows.Add(parhrsRow);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groups.Count != 0)
            {
                comboBox2.Items.Clear();
                NameGrp = comboBox1.SelectedItem.ToString();

                if (NameGrp == "Удалить все группы")
                {
                    groups.Clear();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    PrintItog(groups);
                }
                else
                {
                    List<ParsGroup> pars = new List<ParsGroup>(groups[NameGrp]);
                    foreach (var par in pars)
                    {
                        comboBox2.Items.Add(par.NamePar);
                    }
                    comboBox2.Visible = true;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (comboBox2.Visible == true)
            {
                comboBox2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groups.Count != 0)
            {
                string NameParToDel = comboBox2.SelectedItem.ToString();
                List<ParsGroup> temp = new List<ParsGroup>(groups[NameGrp]);
                ParsGroup itemtodel = temp.Find(p => p.NamePar == NameParToDel);
                groups[NameGrp].Remove(itemtodel);
                comboBox2.Items.Remove(NameParToDel);
                comboBox1.Items.Remove(NameGrp);
                comboBox1.Name = "";
                comboBox2.Name = "";
                label3.Text = NameGrp + " удалена пара: " + NameParToDel;

                if (groups[NameGrp].Count < 1)
                {
                    groups.Remove(NameGrp);
                }

                PrintItog(groups);
                Form1 form1 = new Form1();
                form1.groups = groups;
            }
        }
    }
}