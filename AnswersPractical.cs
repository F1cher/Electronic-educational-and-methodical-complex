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
    public partial class AnswersPractical : Form
    {
        int k_usr;
        DataSet ds;
        OleDbCommand cmd;
        OleDbConnection con;
        public AnswersPractical(string k_user)
        {
            InitializeComponent();
            k_usr = Convert.ToInt32(k_user);
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
            ds = new DataSet();
        }
        private void btn_obzor_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txt_pyt.Text = openFileDialog1.FileName;
        }

        private void Answers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Practical". При необходимости она может быть перемещена или удалена.
            this.practicalTableAdapter.Fill(this.dataBaseDataSet.Practical);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Predmeti". При необходимости она может быть перемещена или удалена.
            this.predmetiTableAdapter.Fill(this.dataBaseDataSet.Predmeti);
            GetCon();   
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_predmet.SelectedIndex == -1 || cmb_tema.SelectedIndex == -1 || txt_pyt.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            string query = "Select COUNT(*) from AnswersPractical where Код_пользователя = @k_user and Код_предмета = @k_predmet and Код_практики = @k_prac and Путь = @pyt";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@k_user", k_usr);
            cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
            cmd.Parameters.AddWithValue("@k_prac", cmb_tema.SelectedValue);
            cmd.Parameters.AddWithValue("@pyt", txt_pyt.Text);
            con.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Ответ для данной работы уже сохранен!");
                con.Close();
                return;
            }
          
            string query_2 = "Insert into AnswersPractical (Код_пользователя, Код_предмета, Код_практики, Путь) values (@k_user, @k_predmet, @k_prac, @pyt)";
            cmd = new OleDbCommand(query_2, con);
            cmd.Parameters.AddWithValue("@k_user", k_usr);
            cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
            cmd.Parameters.AddWithValue("@k_prac", cmb_tema.SelectedValue);
            cmd.Parameters.AddWithValue("@pyt", txt_pyt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            toolStripStatusLabel1.Text = "Ответ был добавлен!";
        }
    }
}