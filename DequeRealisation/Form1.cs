using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DequeRealisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Add add = new Add();
        Remove remove = new Remove();
        Set set = new Set();


        int x = 0, p = 0, time = 0, c = 0;
        int[] statistika = new int[5];

        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                grbProperties.Enabled = false;
                if (dataGridViewDeque.ColumnCount == 0)
                {
                    progressBar1.Value = 0;
                    dataGridViewDeque.Columns.Clear();
                    time = Convert.ToInt32(tbTime.Text);
                    c = time;
                }
                while (time > 0)
                {
                    if (p == 0)
                    {
                        int y = rnd.Next(0, 2);
                        if (y == 0)//добавление 
                        {
                            int s = set.Distance(tbAdd1, tbAdd2);
                            int i = rnd.Next(0, 2);
                            if (i == 0)//для бесконечного дека (добавить слева)
                            {
                                int n = rnd.Next(0, 10);
                                if (rbtnInfinity.Checked == true)
                                    while (s > 0)
                                        s = add.AddLeft(s, dataGridViewDeque, n, statistika);
                                else // для ограниченного дека (добавить слева)
                                {
                                    x = Convert.ToInt32(tbSize.Text);
                                    while (s > 0)
                                        if (x - dataGridViewDeque.ColumnCount > 0)
                                            s = add.AddLeft(s, dataGridViewDeque, n, statistika);
                                        else
                                        {
                                            statistika = add.AddArray(statistika, 4); break;
                                        }
                                }
                            }
                            else //справа
                            {

                                int n = rnd.Next(0, 10);
                                if (rbtnInfinity.Checked == true)
                                    while (s > 0)
                                        add.AddRight(s, dataGridViewDeque, n, statistika);
                                else
                                    if (rbtnLimit.Checked == true)
                                    {
                                        x = Convert.ToInt32(tbSize.Text);
                                        while (s > 0)
                                            if (x > dataGridViewDeque.ColumnCount)
                                                add.AddRight(s, dataGridViewDeque, n, statistika);
                                            else
                                            {
                                                statistika = add.AddArray(statistika, 4); break;
                                            }

                                    }
                            }
                        }
                        else//удаление
                        {
                            int s = set.Distance(tbDel1, tbDel2);
                            int i = rnd.Next(0, 2);
                            if (i == 0)//слева
                                remove.RemoveLeft(s, dataGridViewDeque, statistika);
                            else //справа
                                remove.RemoveRight(s, dataGridViewDeque, statistika);
                        }

                        for (int i = 0; i < 50; i++)
                        {
                            Thread.Sleep(20);
                            Application.DoEvents();
                        }
                        time--;
                        set.MoveOn(progressBar1, c);
                        dataGridViewDeque.Refresh();

                    }
                    else
                    {
                        if (p == 2) //нажали стоп
                        {
                            time = 0;
                            break;
                        }
                        else //нажали паузу
                            break;
                    }
                }
                dataGridViewStatistics.Rows.Clear();
                for (int n = 0; n < dataGridViewStatistics.ColumnCount; n++)
                    dataGridViewStatistics[n, 0].Value = statistika[n];

                if (time == 0)
                    progressBar1.Value = progressBar1.Maximum;
                p = 0;

            }

            catch
            {
                MessageBox.Show("Ошибка.");
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            p = 1;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            p = 2;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewDeque.Columns.Clear();
            progressBar1.Value = 0;
            dataGridViewStatistics.Rows.Clear();
            tbTime.Text = "";
            tbAdd1.Text = "";
            tbDel1.Text = "";
            tbSize.Text = "";
            tbAdd2.Text = "";
            tbDel2.Text = "";
            grbProperties.Enabled = true;
            grbStatistics.Enabled = true;
            for (int u = 0; u <= 5; u++)
                statistika[u] = 0;

        }

        private void rbtnInfinity_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                tbSize.Enabled = false;
            }      
        }

        private void rbtnLimit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                tbSize.Enabled = true;
            }  
        }
    }

        public class Add
        {
            public int AddLeft(int s, DataGridView dataGridViewDeque, int n, int[] statistika)
            {
                var column1 = new DataGridViewTextBoxColumn();
                dataGridViewDeque.Columns.Insert(0, column1);
                dataGridViewDeque[0, 0].Value = n;
                statistika = AddArray(statistika, 0);
                s--;
                return s;
            }
            public int AddRight(int s, DataGridView dataGridViewDeque, int n, int[] statistika)
            {

                var column1 = new DataGridViewTextBoxColumn();
                dataGridViewDeque.Columns.Add(column1);
                dataGridViewDeque[dataGridViewDeque.ColumnCount - 1, 0].Value = n;
                statistika = AddArray(statistika, 1);
                s--;
                return s;
            }
            public int[] AddArray(int[] statistika, int n)
            {
                statistika[n] = statistika[n] + 1;
                return statistika;
            }
        }
        public class Remove
        {
            Add array = new Add();
            public void RemoveLeft(int s, DataGridView dataGridViewDeque, int[] statistika)
            {
                while (s > 0)
                {
                    if (dataGridViewDeque.ColumnCount != 0)
                    {
                        dataGridViewDeque.Columns.RemoveAt(0);
                        statistika = array.AddArray(statistika, 2);
                    }
                    s--;
                }
            }
            public void RemoveRight(int s, DataGridView dataGridViewDeque, int[] statistika)
            {

                while (s > 0)
                {
                    if (dataGridViewDeque.ColumnCount != 0)
                    {
                        dataGridViewDeque.Columns.RemoveAt(dataGridViewDeque.ColumnCount - 1);
                        statistika = array.AddArray(statistika, 3);
                    }
                    s--;
                }
            }
        }
        public class Set
        {
            public int Distance(TextBox tbAdd1, TextBox tbAdd2) //промежуток
            {
                Random rnd = new Random();
                int min = Convert.ToInt32(tbAdd1.Text) - Convert.ToInt32(tbAdd2.Text);
                int max = Convert.ToInt32(tbAdd1.Text) + Convert.ToInt32(tbAdd2.Text);
                int s = rnd.Next(min, max);
                return s;
            }

            public void MoveOn(ProgressBar progressBar1, int c) //продвинуть прогрессбар
            {
                progressBar1.Value = progressBar1.Value + progressBar1.Maximum / c;
            }
        }
    }

