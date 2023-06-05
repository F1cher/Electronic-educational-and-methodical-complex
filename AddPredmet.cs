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
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbConnection con;
        public AddPredmet()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
            ds = new DataSet();
        }
        void GetPredmet()
        {
            GetCon();
            da = new OleDbDataAdapter("SELECT * FROM Predmeti", con);
            con.Open();
            da.Fill(ds, "Predmeti");
            dataGridView1.DataSource = ds.Tables["Predmeti"];
            con.Close();
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
        private void AddPredmet_Load(object sender, EventArgs e)
        {
            GetPredmet();
        }

        private void btn_addpredmet_Click(object sender, EventArgs e)
        {
            if (txt_predmet.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_predmet.Text)
                {
                    MessageBox.Show("Группа с таким названием уже существует!");
                    return;
                }
            }
            string query = "Insert into Predmeti (Предмет) values (@predmet)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@predmet", txt_predmet.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetPredmet();
            toolStripStatusLabel1.Text = "Предмет был добавлен!";
        }

        private void btn_changepredmet_Click(object sender, EventArgs e)
        {
            if (txt_predmet.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_predmet.Text)
                {
                    MessageBox.Show("Группа с таким названием уже существует!");
                    return;
                }
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать предмет?", "Редактировать предмет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Predmeti Set Предмет=@predmet Where Код_предмета=@k_predmet";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@predmet", txt_predmet.Text);
                cmd.Parameters.AddWithValue("@k_predmet", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetPredmet();
                toolStripStatusLabel1.Text = "Предмет был изменен!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_deletepredmet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить предмет?", "Удалить предмет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Predmeti Where Код_предмета=@k_predmet";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_predmet", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetPredmet();
                toolStripStatusLabel1.Text = "Предмет был удален!";
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
            txt_predmet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
