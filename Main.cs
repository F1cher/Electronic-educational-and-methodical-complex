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
using Word = Microsoft.Office.Interop.Word;

namespace Electronic_educational_and_methodical_complex
{
    public partial class Main : Form
    {
        private Word.Application application;
        Word.Document document;
        Word.Paragraph wordparagraph;
        string Access, familia, ima, otches, Groups, pyt, k_user;
        DataSet ds;
        OleDbCommand cmd;
        OleDbConnection con;
        public Main(string Saccess, string Group, string fam, string name, string otch, string k_users)
        {
            InitializeComponent();
            Access = Saccess;
            Groups = Group;
            familia = fam;
            ima = name;
            otches = otch;
            k_user = k_users;
        }
        void GetCon()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DataBase.mdb;Jet OLEDB:Database Password=53605360");
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
                Main.ActiveForm.Hide();
                Authorization Authorization = new Authorization();
                Authorization.ShowDialog(this);
                Close();
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
        public void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.AnswersTestfull". При необходимости она может быть перемещена или удалена.
            this.answersTestfullTableAdapter.Fill(this.dataBaseDataSet.AnswersTestfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.AnswersPracticfull". При необходимости она может быть перемещена или удалена.
            this.answersPracticfullTableAdapter.Fill(this.dataBaseDataSet.AnswersPracticfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.uspfull". При необходимости она может быть перемещена или удалена.
            this.uspfullTableAdapter.Fill(this.dataBaseDataSet.uspfull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Vidi". При необходимости она может быть перемещена или удалена.
            this.vidiTableAdapter.Fill(this.dataBaseDataSet.Vidi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet2.usersfio". При необходимости она может быть перемещена или удалена.
            this.usersfioTableAdapter.Fill(this.dataBaseDataSet2.usersfio);
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
                Add_predmet_3.Visible = false;
                Add_lectures.Visible = false;
                Add_practical.Visible = false;
                Add_tests.Visible = false;
                txt_poiskfam.Visible = false;
                label17.Visible = false;
                label20.Visible = false;
                txt_poiskfam_3.Visible = false;
                txt_poiskfam.Text = familia + " " + ima + " " + otches;
                btn_uspadd.Visible = false;
                btn_uspchange.Visible = false;
                btn_uspdelete.Visible = false;
                button_clear.Visible = false;
                cmb_fio.Visible = false;
                cmbox_predmet.Visible = false;
                cmb_vid.Visible = false;
                cmb_tema.Visible = false;
                btn_export.Visible = false;
                txt_ocenka.Visible = false;
                label15.Visible = false;
                label2.Visible = false;
                label16.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                //Сортировка по группе (лекции)
                DataView filter_lec = new DataView(this.dataBaseDataSet.Lecturesfull);
                filter_lec.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = filter_lec;

                //Сортировка по группе (практика)
                DataView filter_prac = new DataView(this.dataBaseDataSet.Practicalfull);
                filter_prac.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.practicalfullBindingSource.DataSource = filter_prac;

                //Сортировка по группе (тесты)
                DataView filter_test = new DataView(this.dataBaseDataSet1.Testsfull);
                filter_test.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.testsfullBindingSource.DataSource = filter_test;

                //Сортировка по фамилии в успеваемости
                DataView famil = new DataView(this.dataBaseDataSet.uspfull);
                famil.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%'";
                this.uspfullBindingSource.DataSource = famil;

                //Сортировка по фамилии в ответах
                txt_poiskfam_3.Text = familia + ' ' + ima + ' ' + otches;

                dataGridView6.DataSource = null;
            }
            else
            {
                btn_save.Visible = false;
                btn_save_2.Visible = false;
            }
        }
        #endregion
        #region lectures
        private void add_predmet_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.ShowDialog();
        }
        private void Add_lectures_Click(object sender, EventArgs e)
        {
            Lectures Lectures = new Lectures();
            Lectures.ShowDialog();
        }
        private void Add_groups_Click(object sender, EventArgs e)
        {
            AddGroups AddGroups = new AddGroups();
            AddGroups.ShowDialog();
        }
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pyt = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pyt);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }
        private void cmb_predmet_Click(object sender, EventArgs e)
        {
            string query = "Select Предмет from Predmeti";
            cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmb_predmet.DataSource = tb;
            cmb_predmet.DisplayMember = "Предмет";
            con.Close();
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
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_fam.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == txt_name.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == txt_otch.Text && dataGridView1.Rows[i].Cells[4].Value.ToString() == cmb_group.Text)
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                    return;
                }
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == txt_login.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == txt_pass.Text)
                {
                    MessageBox.Show("Пользователь с таким паролем уже существует!");
                    return;
                }
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
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txt_fam.Text && dataGridView1.Rows[i].Cells[2].Value.ToString() == txt_name.Text && dataGridView1.Rows[i].Cells[3].Value.ToString() == txt_otch.Text && dataGridView1.Rows[i].Cells[4].Value.ToString() == cmb_group.Text && dataGridView1.Rows[i].Cells[5].Value.ToString() == txt_login.Text && dataGridView1.Rows[i].Cells[6].Value.ToString() == txt_pass.Text)
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                    return;
                }
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
        private void Add_practical_Click(object sender, EventArgs e)
        {
            Practical Practical = new Practical();
            Practical.ShowDialog();
        }
        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pyt = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pyt);
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
        private void cmb_predmet_2_Click(object sender, EventArgs e)
        {
            string query = "Select Предмет from Predmeti";
            cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmb_predmet_2.DataSource = tb;
            cmb_predmet_2.DisplayMember = "Предмет";
            con.Close();
        }
        #endregion
        #region tests
        private void Add_tests_Click(object sender, EventArgs e)
        {
            Tests Tests = new Tests();
            Tests.ShowDialog();
        }
        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pyt = dataGridView4.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pyt);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }
        private void Add_predmet_3_Click(object sender, EventArgs e)
        {
            AddPredmet AddPredmet = new AddPredmet();
            AddPredmet.ShowDialog();
        }
        private void cmb_predmet_3_Click(object sender, EventArgs e)
        {
            string query = "Select Предмет from Predmeti";
            cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmb_predmet_3.DataSource = tb;
            cmb_predmet_3.DisplayMember = "Предмет";
            con.Close();
        }
        #endregion
        #region poisk
        private void txt_naz_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Lecturesfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Lecturesfull);
                poisk.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = poisk;
            }
        }

        private void txt_naz_2_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Practicalfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Practicalfull);
                poisk.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = poisk;
            }
        }

        private void txt_naz_3_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet1.Testsfull);
                poisk.RowFilter = "Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
                this.testsfullBindingSource.DataSource = poisk;
            }
            else
            {
                DataView poisk = new DataView(this.dataBaseDataSet1.Testsfull);
                poisk.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
                this.testsfullBindingSource.DataSource = poisk;
            }
        }
        private void cmb_predmet_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Lecturesfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Lecturesfull);
                predmet.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz.Text + "%' AND Предмет LIKE '" + cmb_predmet.Text + "%'";
                this.lecturesfullBindingSource.DataSource = predmet;
            }
        }
        private void cmb_predmet_2_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Practicalfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet.Practicalfull);
                predmet.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz_2.Text + "%' AND Предмет LIKE '" + cmb_predmet_2.Text + "%'";
                this.practicalfullBindingSource.DataSource = predmet;
            }
        }
        private void cmb_predmet_3_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView predmet = new DataView(this.dataBaseDataSet1.Testsfull);
                predmet.RowFilter = "Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'"; ;
                this.testsfullBindingSource.DataSource = predmet;
            }
            else
            {
                DataView predmet = new DataView(this.dataBaseDataSet1.Testsfull);
                predmet.RowFilter = "Код_группы LIKE '" + Groups + "%' AND Название LIKE '" + txt_naz_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_3.Text + "%'";
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
        #region usp
        private void btn_uspadd_Click(object sender, EventArgs e)
        {
            if (cmb_fio.SelectedIndex == -1 || cmbox_predmet.SelectedIndex == -1 || cmb_vid.SelectedIndex == -1 || cmb_tema.SelectedIndex == -1 || txt_ocenka.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView5.RowCount; i++)
            {
                if (dataGridView5.Rows[i].Cells[1].Value.ToString() == cmb_fio.Text && dataGridView5.Rows[i].Cells[2].Value.ToString() == cmbox_predmet.Text && dataGridView5.Rows[i].Cells[3].Value.ToString() == cmb_vid.Text && dataGridView5.Rows[i].Cells[4].Value.ToString() == cmb_tema.Text)
                {
                    MessageBox.Show("Данному студенту уже поставлена оценка за эту работу!");
                    return;
                }
            }
            string query = "Insert into Usp (Код_пользователя, Код_предмета, Код_вида, Тема, Оценка) values (@k_user,@k_predmet,@k_vida,@tema,@ocenka)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@k_user", cmb_fio.SelectedValue);
            cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
            cmd.Parameters.AddWithValue("@k_vida", cmb_vid.SelectedValue);
            cmd.Parameters.AddWithValue("@tema", cmb_tema.SelectedValue);
            cmd.Parameters.AddWithValue("@ocenka", txt_ocenka.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.uspfullTableAdapter.Fill(this.dataBaseDataSet.uspfull);
            toolStripStatusLabel2.Text = "Оценка была добавлена!";
        }
        private void btn_uspchange_Click(object sender, EventArgs e)
        {
            if (cmb_fio.SelectedIndex == -1 || cmbox_predmet.SelectedIndex == -1 || cmb_tema.SelectedIndex == -1 || txt_ocenka.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView5.RowCount; i++)
            {
                if (dataGridView5.Rows[i].Cells[1].Value.ToString() == cmb_fio.Text && dataGridView5.Rows[i].Cells[2].Value.ToString() == cmbox_predmet.Text && dataGridView5.Rows[i].Cells[3].Value.ToString() == cmb_vid.Text && dataGridView5.Rows[i].Cells[4].Value.ToString() == cmb_tema.Text && dataGridView5.Rows[i].Cells[5].Value.ToString() == txt_ocenka.Text)
                {
                    MessageBox.Show("За данную работу уже поставлена такая же оценка!");
                    return;
                }
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать успеваемость?", "Редактировать успеваемость", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Usp Set Код_пользователя=@k_user, Код_предмета=@k_predmet, Код_вида=@k_vida, Тема=@tema, Оценка=@ocenka Where Код_успеваемости=@k_usp";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_user", cmb_fio.SelectedValue);
                cmd.Parameters.AddWithValue("@k_predmet", cmb_predmet.SelectedValue);
                cmd.Parameters.AddWithValue("@k_vida", cmb_vid.SelectedValue);
                cmd.Parameters.AddWithValue("@tema", cmb_tema.SelectedValue);
                cmd.Parameters.AddWithValue("@ocenka", txt_ocenka.Text);
                cmd.Parameters.AddWithValue("@k_usp", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.uspfullTableAdapter.Fill(this.dataBaseDataSet.uspfull);
                toolStripStatusLabel2.Text = "Пользователь был изменен!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_uspdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить успеваемость?", "Удалить успеваемость", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Usp Where Код_успеваемости=@k_usp";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@k_usp", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.uspfullTableAdapter.Fill(this.dataBaseDataSet.uspfull);
                toolStripStatusLabel2.Text = "Группа была удалена!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmb_fio.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            cmbox_predmet.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            cmb_vid.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            cmb_tema.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            txt_ocenka.Text = dataGridView5.CurrentRow.Cells[5].Value.ToString();
        }
        private void txt_poiskfam_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.uspfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam.Text + "%'";
                this.uspfullBindingSource.DataSource = poisk;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AnswersPractical AnswersPractical = new AnswersPractical(k_user);
            AnswersPractical.ShowDialog();
        }

        private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pyt);
            }
            catch
            {
                MessageBox.Show("Не удается найти указанный файл!\nПроверьте правильность указанного пути.");
            }
        }

        private void dataGridView6_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pyt = dataGridView6.CurrentRow.Cells[4].Value.ToString();
        }

        private void cmb_tema_Click(object sender, EventArgs e)
        {
            if (cmb_vid.SelectedIndex == 1)
            {
                string query = "Select Название from Practical";
                cmd = new OleDbCommand(query, con);
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                cmb_tema.DataSource = tb;
                cmb_tema.DisplayMember = "Название";
                con.Close();
            }

            if (cmb_vid.SelectedIndex == 2)
            {
                string query = "Select Название from Tests";
                cmd = new OleDbCommand(query, con);
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                cmb_tema.DataSource = tb;
                cmb_tema.DisplayMember = "Название";
                con.Close();
            }
        }

        private void btn_save_2_Click(object sender, EventArgs e)
        {
            AnswersTest AnswersTest = new AnswersTest(k_user);
            AnswersTest.ShowDialog();
        }

        private void rb_prac_CheckedChanged(object sender, EventArgs e)
        {
            this.answersPracticfullTableAdapter.Fill(this.dataBaseDataSet.AnswersPracticfull);
            dataGridView6.DataSource = answersPracticfullBindingSource;
            DataView poisk = new DataView(this.dataBaseDataSet.AnswersPracticfull);
            poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%'";
            this.answersPracticfullBindingSource.DataSource = poisk;

        }

        private void rb_test_CheckedChanged(object sender, EventArgs e)
        {
            this.answersTestfullTableAdapter.Fill(this.dataBaseDataSet.AnswersTestfull);
            dataGridView6.DataSource = answersTestfullBindingSource;
            DataView poisk = new DataView(this.dataBaseDataSet.AnswersTestfull);
            poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%'";
            this.answersTestfullBindingSource.DataSource = poisk;
        }

        private void txt_poiskfam_3_TextChanged(object sender, EventArgs e)
        {
            if (rb_prac.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersPracticfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersPracticfullBindingSource.DataSource = poisk;
            }
            if (rb_test.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersTestfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersTestfullBindingSource.DataSource = poisk;
            }
        }

        private void cmb_predmet_4_TextChanged(object sender, EventArgs e)
        {
            if (rb_prac.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersPracticfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersPracticfullBindingSource.DataSource = poisk;
            }
            if (rb_test.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersTestfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersTestfullBindingSource.DataSource = poisk;
            }
        }

        private void txt_poisktemy_2_TextChanged(object sender, EventArgs e)
        {
            if (rb_prac.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersPracticfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersPracticfullBindingSource.DataSource = poisk;
            }
            if (rb_test.Checked == true)
            {
                DataView poisk = new DataView(this.dataBaseDataSet.AnswersTestfull);
                poisk.RowFilter = "ФИО LIKE '" + txt_poiskfam_3.Text + "%' AND Предмет LIKE '" + cmb_predmet_4.Text + "%' AND Название LIKE '" + txt_poisktemy_2.Text + "%'";
                this.answersTestfullBindingSource.DataSource = poisk;
            }
        }

        private void btn_clear_2_Click(object sender, EventArgs e)
        {
            Clear(tabPage6);
        }

        private void txt_poiskfam_2_TextChanged(object sender, EventArgs e)
        {
            if (Groups == "1")
            {
                DataView poisk = new DataView(this.dataBaseDataSet.Students);
                poisk.RowFilter = "Фамилия LIKE '" + txt_poiskfam_2.Text + "%'";
                this.studentsBindingSource.DataSource = poisk;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear(tabPage5);
        }
        private void txt_ocenka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 54) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            application = new Word.Application
            {
                Visible = true
            };
            document = application.Documents.Add();
            wordparagraph = document.Paragraphs.Add();
            wordparagraph.Range.Text = "Успеваемость студентов";
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Font.Name = "Arial";
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph = document.Paragraphs.Add();
            wordparagraph = document.Paragraphs[2];
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Range.Font.Bold = 0;
            Word.Range wordrange = wordparagraph.Range;
            var row = dataBaseDataSet.uspfull.Rows.Count;
            var col = dataBaseDataSet.uspfull.Columns.Count;
            Word.Table wordtable1 = document.Tables.Add(wordrange, row + 1, col-1);
            Word.Range wordcellrange = document.Tables[1].Cell(1, 2).Range;
            wordtable1.Range.Font.Size = 9;
            wordtable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordtable1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordtable1.Rows[1].Range.Font.Color = Word.WdColor.wdColorBlack;
            for (int i = 1; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    wordcellrange = document.Tables[1].Cell(1, i).Range;
                    wordcellrange.Text = dataBaseDataSet.uspfull.Columns[i].ToString();
                    wordcellrange = document.Tables[1].Cell(j + 2, i).Range;
                    wordcellrange.Text = dataBaseDataSet.uspfull.Rows[j][i].ToString();
                }
            }
        }
        private void cmb_group_Click(object sender, EventArgs e)
        {
            string query = "Select Группа from Groups";
            cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmb_group.DataSource = tb;
            cmb_group.DisplayMember = "Группа";
            con.Close();
        }
        private void cmbox_predmet_Click(object sender, EventArgs e)
        {
            string query = "Select Предмет from Predmeti";
            cmd = new OleDbCommand(query, con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmbox_predmet.DataSource = tb;
            cmbox_predmet.DisplayMember = "Предмет";
            con.Close();
        }
#endregion
    }
}
