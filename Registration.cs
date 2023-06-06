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
            this.groupsTableAdapter.Fill(this.dataBaseDataSet1.Groups);
            fillByToolStripButton.PerformClick();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Registration.ActiveForm.Hide();
            Authorization Authorization = new Authorization();
            Authorization.ShowDialog(this);
            Close();
        }
        
        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (txt_fam.Text == "" || txt_name.Text == "" || txt_otch.Text == "" || cmb_group.SelectedIndex == -1 || txt_login.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");


            string query = "Select COUNT(*) from Users where Фамилия = @fam and Имя = @name and Отчество = @otch and Код_группы = @k_group and Логин = @login and Пароль = @pass";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@fam", txt_fam.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@otch", txt_otch.Text);
            cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
            cmd.Parameters.AddWithValue("@login", txt_login.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            con.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован!");
                con.Close();
                return;
            }
            string query_2 = "Insert into Users (Фамилия, Имя, Отчество, Код_группы, Логин, Пароль, Доступ) values (@fam, @name, @otch, @k_group, @login, @pass, @access)";
            cmd = new OleDbCommand(query_2, con);
            cmd.Parameters.AddWithValue("@fam", txt_fam.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@otch", txt_otch.Text);
            cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
            cmd.Parameters.AddWithValue("@login", txt_login.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            cmd.Parameters.AddWithValue("@access", "Студент");
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
