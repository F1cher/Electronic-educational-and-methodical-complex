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
    public partial class AddGroups : Form
    {
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbConnection con;
        public AddGroups()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
            ds = new DataSet();
        }
        void GetGroups()
        {
            GetCon();
            da = new OleDbDataAdapter("SELECT * FROM Groups", con);
            con.Open();
            da.Fill(ds, "Groups");
            dataGridView1.DataSource = ds.Tables["Groups"];
            dataGridView1.Columns[0].Visible = false;
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
        private void AddGroups_Load(object sender, EventArgs e)
        {
            GetGroups();
        }

        private void btn_addgroups_Click(object sender, EventArgs e)
        {
            if (txt_group.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_group.Text)
                {
                    MessageBox.Show("Группа с таким названием уже существует!");
                    return;
                }
            }
            string query = "Insert into Groups (Группа) values (@group)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@group", txt_group.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetGroups();
            toolStripStatusLabel1.Text = "Группа была добавлена!";
        }

        private void btn_changegroups_Click(object sender, EventArgs e)
        {
            if (txt_group.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_group.Text)
                {
                    MessageBox.Show("Группа с таким названием уже существует!");
                    return;
                }
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать группу?", "Редактировать группу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Groups Set Группа=@group Where Код_группы=@k_group";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@group", txt_group.Text);
                cmd.Parameters.AddWithValue("@k_group", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetGroups();
                toolStripStatusLabel1.Text = "Группа была изменена!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_deletegroups_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить группу?", "Удалить группу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Groups Where Код_группы=@k_group";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_group", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetGroups();
                toolStripStatusLabel1.Text = "Группа была удалена!";
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
            txt_group.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
