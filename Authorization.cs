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
    public partial class Authorization : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Login.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            string login = Login.Text;
            string pass = Pass.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM Users where Логин='" + Login.Text + "' AND Пароль='" + Pass.Text + "'";
            cmd.CommandText = str;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string k_users = dr["Код_пользователя"].ToString();
                string fam = dr["Фамилия"].ToString();
                string name = dr["Имя"].ToString();
                string otch = dr["Отчество"].ToString();
                string Saccess = dr["Доступ"].ToString();
                string Group = dr["Код_группы"].ToString();
                MessageBox.Show("Добро пожаловать, " + fam + " " + name + " " + otch + "!");
                Authorization.ActiveForm.Hide();
                Main Main = new Main(Saccess, Group, fam, name, otch, k_users);
                Main.ShowDialog(this);
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
            con.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Authorization.ActiveForm.Hide();
            Registration Registration = new Registration();
            Registration.ShowDialog(this);
            Close();
        }
    }
}
