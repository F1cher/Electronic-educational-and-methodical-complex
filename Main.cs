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
    public partial class Main : Form
    {
        string Access;
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbConnection con;
        public Main(string Saccess, string Group)
        {
            InitializeComponent();
            Access = Saccess;
            txt_group.Text = Group;
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb");
            ds = new DataSet();
        }
        public void Clear(TabPage tabPageName)
        {
            foreach (Control control in tabPageName.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedValue = -1;
                    (control as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сменить пользователя?", "Сменить пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Authorization Authorization = new Authorization();
                Authorization.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выйти из программы", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Электронный учебно-методический комплекс\nАвтор: Тиунов Максим, студент группы ИП-41");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.dataBaseDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.dataBaseDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Predmeti". При необходимости она может быть перемещена или удалена.
            this.predmetiTableAdapter.Fill(this.dataBaseDataSet.Predmeti);
            GetCon();

            if (Access == "Студент")
            {
                tabControl1.TabPages.Remove(tabPage4);
                Add_groups.Visible = false;
                Add_predmet.Visible = false;
                btn_addfile.Visible = false;
                btn_changefile.Visible = false;
                btn_deletefile.Visible = false;
            }
        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
            AddLectures AddLectures = new AddLectures();
            AddLectures.Show();
        }

        private void add_predmet_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.Show();
        }

        private void Add_groups_Click(object sender, EventArgs e)
        {
            AddGroups AddGroups = new AddGroups();
            AddGroups.Show();
        }

        private void btn_addgroups_Click(object sender, EventArgs e)
        {
            if (txt_fam.Text == "" || txt_name.Text == "" || txt_otch.Text == "" || cmb_group.SelectedIndex == -1 || txt_login.Text == "" || txt_pass.Text == "" || cmb_access.SelectedIndex ==-1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            string query = "Insert into Users (Фамилия, Имя, Отчество, Код_группы, Логин, Пароль, Доступ) values (@fam,@name,@otch,@k_group,@login,@pass,@access)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@fam", txt_fam.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@otch", txt_otch.Text);
            cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
            cmd.Parameters.AddWithValue("@login", txt_login.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            cmd.Parameters.AddWithValue("@access", cmb_access.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.studentsTableAdapter.Fill(this.dataBaseDataSet.Students);
            toolStripStatusLabel1.Text = "Пользователь был добавлен!";
        }

        private void btn_changegroups_Click(object sender, EventArgs e)
        {
            if (txt_fam.Text == "" || txt_name.Text == "" || txt_otch.Text == "" || cmb_group.SelectedIndex == -1 || txt_login.Text == "" || txt_pass.Text == "" || cmb_access.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать пользователя?", "Редактировать пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Users Set Фамилия=@fam, Имя=@name, Отчество=@otch, Код_группы=@k_group, Логин=@login, Пароль=@pass, Доступ=@access Where Код_пользователя=@k_user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@fam", txt_fam.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@otch", txt_otch.Text);
                cmd.Parameters.AddWithValue("@k_group", cmb_group.SelectedValue);
                cmd.Parameters.AddWithValue("@login", txt_login.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
                cmd.Parameters.AddWithValue("@access", cmb_access.Text);
                cmd.Parameters.AddWithValue("@k_user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.studentsTableAdapter.Fill(this.dataBaseDataSet.Students);
                toolStripStatusLabel1.Text = "Пользователь был изменен!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_deleteusers_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удалить пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Users Where Код_пользователя=@k_user";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_user", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.studentsTableAdapter.Fill(this.dataBaseDataSet.Students);
                toolStripStatusLabel1.Text = "Группа была удалена!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear(tabPage4);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_fam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_otch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_group.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_login.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_pass.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmb_access.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
