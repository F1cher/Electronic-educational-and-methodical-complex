using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_educational_and_methodical_complex
{
    public partial class Registration : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.dataBaseDataSet1.Groups);
            fillByToolStripButton.PerformClick();

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Authorization Authorization = new Authorization();
            Authorization.Show();
            this.Hide();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (txt_fam.Text == "" || txt_name.Text == "" || txt_otch.Text == "" || cmb_group.SelectedIndex == -1 || txt_login.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb");
            string query = "Insert into Users (Фамилия, Имя, Отчество, Код_группы, Логин, Пароль, Доступ) values (@fam, @name, @otch, @k_group, @login, @pass, @access)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@fam", txt_fam.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@otch", txt_otch.Text);
            cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
            cmd.Parameters.AddWithValue("@login", txt_login.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            cmd.Parameters.AddWithValue("@access", "Студент");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Пользователь успешно добавлен!");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.groupsTableAdapter.FillBy(this.dataBaseDataSet1.Groups);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.groupsTableAdapter.FillBy(this.dataBaseDataSet1.Groups);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.groupsTableAdapter.FillBy(this.dataBaseDataSet1.Groups);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
