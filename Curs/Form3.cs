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
    public partial class Form3 : Form
    {
        public Dictionary<string, List<string>> prepodovat = new Dictionary<string, List<string>>();
        private string NamePar;
        public Form3()
        {
            Form1 form1 = new Form1();
            prepodovat = form1.prepodovat;
            NamePar = NamePar;
            InitializeComponent();
        }

        public void PrintItog(Dictionary<string, List<string>> prepodovat)
        {
            if (prepodovat.Count == 0)
            {
                dataGridView1.Visible = false;
                label1.Text = "Увы, нет данных об преподавателях.";
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
                comboBox1.Items.Add("Удалить все пары");
                comboBox2.Items.Clear();
                dataGridView1.Rows.Clear();

                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Название пары", "Para");
                    dataGridView1.Columns.Add("Преподаватель", "Prep");
                }

                foreach (var pair in prepodovat)
                {
                    string ParaName = pair.Key;
                    comboBox1.Items.Add(ParaName);
                    List<string> temper = new List<string>(pair.Value);
                    bool isFirstGroup = true;

                    foreach (var group in temper)
                    {
                        if (isFirstGroup)
                        {
                            DataGridViewRow groupRow = new DataGridViewRow();
                            groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = ParaName });
                            groupRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                            dataGridView1.Rows.Add(groupRow);
                            isFirstGroup = false;
                        }
                        DataGridViewRow parhrsRow = new DataGridViewRow();
                        parhrsRow.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        parhrsRow.Cells.Add(new DataGridViewTextBoxCell { Value = group });
                        dataGridView1.Rows.Add(parhrsRow);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (comboBox2.Visible == true)
            {
                comboBox2.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prepodovat.Count != 0)
            {
                comboBox2.Items.Clear();
                NamePar = comboBox1.SelectedItem.ToString();

                if (NamePar == "Удалить все пары")
                {
                    prepodovat.Clear();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    PrintItog(prepodovat);
                }
                else
                {
                    List<string> prep = new List<string>(prepodovat[NamePar]);
                    foreach (string pre in prep)
                    {
                        comboBox2.Items.Add(pre);
                    }
                    comboBox2.Visible = true;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prepodovat.Count != 0)
            {
                string NamePrepDel = comboBox2.SelectedItem.ToString();
                List<string> temp = new List<string>(prepodovat[NamePar]);
                int ind = temp.FindIndex(x => x == NamePrepDel);
                prepodovat[NamePar].Remove(temp[ind]);
                comboBox2.Items.Remove(NamePrepDel);
                comboBox1.Items.Remove(NamePar);
                comboBox1.Name = "";
                comboBox2.Name = "";
                label3.Text = NamePar + " удален преподаватель: " + NamePrepDel;

                if (prepodovat[NamePar].Count < 1)
                {
                    prepodovat.Remove(NamePar);
                }

                PrintItog(prepodovat);
                Form1 form1 = new Form1();
                form1.prepodovat = prepodovat;
            }
        }
    }
}
