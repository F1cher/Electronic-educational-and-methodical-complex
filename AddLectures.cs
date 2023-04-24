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
    public partial class AddLectures : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public AddLectures()
        {
            InitializeComponent();
        }

        private void btn_obzor_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txt_pyt.Text = openFileDialog1.FileName;
        }

        private void AddLectures_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Predmeti". При необходимости она может быть перемещена или удалена.
            this.predmetiTableAdapter.Fill(this.dataBaseDataSet.Predmeti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_perdmet.SelectedIndex == -1 || txt_nazvanie.Text == "" || txt_pyt.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb");
            string query = "Insert into Lectures (Код_предмета, Название, Путь) values (@kod_p, @naz, @pyt)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@kod_P", cmb_perdmet.SelectedValue);
            cmd.Parameters.AddWithValue("@naz", txt_nazvanie.Text);
            cmd.Parameters.AddWithValue("@pyt", txt_pyt.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Файл успешно добавлен!");
        }
    }
}
