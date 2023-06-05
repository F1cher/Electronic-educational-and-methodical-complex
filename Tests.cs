﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_educational_and_methodical_complex
{
    public partial class Tests : Form
    {
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbConnection con;
        public Tests()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
            ds = new DataSet();
        }
        public void Clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedValue = -1;
                }
            }
        }
        private void Tests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.TestsAdd". При необходимости она может быть перемещена или удалена.
            this.testsAddTableAdapter.Fill(this.dataBaseDataSet.TestsAdd);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.dataBaseDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Predmeti". При необходимости она может быть перемещена или удалена.
            this.predmetiTableAdapter.Fill(this.dataBaseDataSet.Predmeti);
            GetCon();
        }
        private void btn_obzor_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txt_pyt.Text = openFileDialog1.FileName;
        }
        private void btn_addlectures_Click(object sender, EventArgs e)
        {
            if (cmb_predmet.SelectedIndex == -1 || cmb_group.SelectedIndex == -1 || txt_tema.Text == "" || txt_pyt.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == cmb_predmet.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == cmb_group.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == txt_tema.Text && dataGridView1.Rows[i].Cells[4].Value.ToString() == txt_pyt.Text)
                {
                    MessageBox.Show("Такой тест уже существует!");
                    return;
                }
            }
            string query = "Insert into Tests (Код_предмета, Код_группы, Название, Путь) values (@k_predmet, @k_group, @nazv, @pyt)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
            cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
            cmd.Parameters.AddWithValue("@naz", txt_tema.Text);
            cmd.Parameters.AddWithValue("@pyt", txt_pyt.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.testsAddTableAdapter.Fill(this.dataBaseDataSet.TestsAdd);
            toolStripStatusLabel1.Text = "Тест был добавлен!";
        }

        private void btn_changelectures_Click(object sender, EventArgs e)
        {
            if (cmb_predmet.SelectedIndex == -1 || cmb_group.SelectedIndex == -1 || txt_tema.Text == "" || txt_pyt.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == cmb_predmet.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == cmb_group.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == txt_tema.Text && dataGridView1.Rows[i].Cells[4].Value.ToString() == txt_pyt.Text)
                {
                    MessageBox.Show("Такой тест уже существует!");
                    return;
                }
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать тест?", "Редактировать тест", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Tests Set Код_предмета=@k_predmet, Код_группы=@k_group, Название=@naz, Путь=@pyt Where Код_теста=@k_test";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
                cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
                cmd.Parameters.AddWithValue("@naz", txt_tema.Text);
                cmd.Parameters.AddWithValue("@pyt", txt_pyt.Text);
                cmd.Parameters.AddWithValue("@k_test", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.testsAddTableAdapter.Fill(this.dataBaseDataSet.TestsAdd);
                toolStripStatusLabel1.Text = "Тест был изменен!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_deletelectures_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить тест?", "Удалить тест", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Tests Where Код_теста=@k_test";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_test", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.testsAddTableAdapter.Fill(this.dataBaseDataSet.TestsAdd);
                toolStripStatusLabel1.Text = "Тест был удален!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmb_predmet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmb_group.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tema.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_pyt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
