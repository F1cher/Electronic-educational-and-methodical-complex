using System;
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
    public partial class AddPredmet : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public AddPredmet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nazvanie.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb");
            string query = "Insert into Predmeti (Предмет) values (@Predmet)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Predmet", txt_nazvanie.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Предмет успешно добавлен!");
        }
    }
}
