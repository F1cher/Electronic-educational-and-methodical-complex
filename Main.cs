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
        #region menu
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
        #endregion
        #region main_load
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Testsfull". При необходимости она может быть перемещена или удалена.
            this.testsfullTableAdapter.Fill(this.dataBaseDataSet1.Testsfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Testsfull". При необходимости она может быть перемещена или удалена.
            this.testsfullTableAdapter.Fill(this.dataBaseDataSet1.Testsfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Testsfull". При необходимости она может быть перемещена или удалена.
            this.testsfullTableAdapter.Fill(this.dataBaseDataSet1.Testsfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Practicalfull". При необходимости она может быть перемещена или удалена.
            this.practicalfullTableAdapter.Fill(this.dataBaseDataSet.Practicalfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Lecturesfull". При необходимости она может быть перемещена или удалена.
            this.lecturesfullTableAdapter.Fill(this.dataBaseDataSet.Lecturesfull);
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
                Add_predmet_2.Visible = false;
                btn_uprlectures.Visible = false;
                btn_uprpractical.Visible = false;
                btn_uprtests.Visible = false;

                //Сортировка по группе (переделать)
                DataView filter = new DataView(this.dataBaseDataSet.Lecturesfull);
                filter.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = filter;
            }
        }
        #endregion
        #region lectures
        private void btn_uprlectures_Click(object sender, EventArgs e)
        {
            Lectures Lectures = new Lectures();
            Lectures.Show();
        }
        private void add_predmet_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.ShowDialog();
        }
        private void Add_groups_Click(object sender, EventArgs e)
        {
            AddGroups AddGroups = new AddGroups();
            AddGroups.ShowDialog();
        }
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_pyt.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txt_pyt.Text);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }
        #endregion
        #region users
        private void btn_addusers_Click(object sender, EventArgs e)
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
        private void btn_changeusers_Click(object sender, EventArgs e)
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
        #endregion
        #region practical
        private void btn_uprlpractical_Click(object sender, EventArgs e)
        {
            Practical Practical = new Practical();
            Practical.ShowDialog();
        }
        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_pyt_2.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txt_pyt.Text);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }
        private void Add_predmet_2_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.ShowDialog();
        }
        #endregion
        #region tests
        private void btn_uprtests_Click(object sender, EventArgs e)
        {
            Tests Tests = new Tests();
            Tests.ShowDialog();
        }
        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_pyt_3.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txt_pyt.Text);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }
        private void btn_addpredmet_3_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.ShowDialog();
        }
        #endregion
        #region poisk
        private void txt_naz_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Lecturesfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Lecturesfull);
                poisk.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = poisk;
            }
        }

        private void txt_naz_2_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Practicalfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Practicalfull);
                poisk.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = poisk;
            }
        }

        private void txt_naz_3_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet1.Testsfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
                this.testsfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet1.Testsfull);
                poisk.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
                this.testsfullBindingSource.DataSource = poisk;
            }
        }
        private void cmb_predmet_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Lecturesfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Lecturesfull);
                predmet.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = predmet;
            }
        }
        private void cmb_predmet_2_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Practicalfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Practicalfull);
                predmet.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = predmet;
            }
        }
        private void cmb_predmet_3_TextChanged(object sender, EventArgs e)
        {
            if (txt_group.Text == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet1.Testsfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'"; ;
                this.testsfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet1.Testsfull);
                predmet.RowFilter = "Код_группы LIKE '" + txt_group.Text + "%' AND Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
                this.testsfullBindingSource.DataSource = predmet;
            }
        }
        #endregion
        #region btn_update
        private void button4_Click(object sender, EventArgs e)
        {
            this.lecturesfullTableAdapter.Fill(this.dataBaseDataSet.Lecturesfull);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.practicalfullTableAdapter.Fill(this.dataBaseDataSet.Practicalfull);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.testsfullTableAdapter.Fill(this.dataBaseDataSet1.Testsfull);
        }
        #endregion
    }
}
