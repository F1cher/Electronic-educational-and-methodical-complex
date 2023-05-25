
namespace Electronic_educational_and_methodical_complex
{
    partial class Lectures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_deletelectures = new System.Windows.Forms.Button();
            this.btn_changelectures = new System.Windows.Forms.Button();
            this.btn_addlectures = new System.Windows.Forms.Button();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Electronic_educational_and_methodical_complex.DataBaseDataSet();
            this.txt_tema = new System.Windows.Forms.TextBox();
            this.txt_pyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодлекцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.путьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturesAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_obzor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.predmetiTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PredmetiTableAdapter();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupsTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.GroupsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_naz = new System.Windows.Forms.TextBox();
            this.lecturesAddTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.LecturesAddTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesAddBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(294, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 29);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_deletelectures
            // 
            this.btn_deletelectures.Location = new System.Drawing.Point(201, 12);
            this.btn_deletelectures.Name = "btn_deletelectures";
            this.btn_deletelectures.Size = new System.Drawing.Size(87, 29);
            this.btn_deletelectures.TabIndex = 6;
            this.btn_deletelectures.Text = "Удалить";
            this.btn_deletelectures.UseVisualStyleBackColor = true;
            this.btn_deletelectures.Click += new System.EventHandler(this.btn_deletelectures_Click);
            // 
            // btn_changelectures
            // 
            this.btn_changelectures.Location = new System.Drawing.Point(108, 12);
            this.btn_changelectures.Name = "btn_changelectures";
            this.btn_changelectures.Size = new System.Drawing.Size(87, 29);
            this.btn_changelectures.TabIndex = 5;
            this.btn_changelectures.Text = "Изменить";
            this.btn_changelectures.UseVisualStyleBackColor = true;
            this.btn_changelectures.Click += new System.EventHandler(this.btn_changelectures_Click);
            // 
            // btn_addlectures
            // 
            this.btn_addlectures.Location = new System.Drawing.Point(15, 12);
            this.btn_addlectures.Name = "btn_addlectures";
            this.btn_addlectures.Size = new System.Drawing.Size(87, 29);
            this.btn_addlectures.TabIndex = 4;
            this.btn_addlectures.Text = "Добавить";
            this.btn_addlectures.UseVisualStyleBackColor = true;
            this.btn_addlectures.Click += new System.EventHandler(this.btn_addlectures_Click);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.DataSource = this.predmetiBindingSource;
            this.cmb_predmet.DisplayMember = "Предмет";
            this.cmb_predmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(12, 134);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_predmet.TabIndex = 8;
            this.cmb_predmet.ValueMember = "Код_предмета";
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_tema
            // 
            this.txt_tema.Location = new System.Drawing.Point(266, 134);
            this.txt_tema.Name = "txt_tema";
            this.txt_tema.Size = new System.Drawing.Size(100, 20);
            this.txt_tema.TabIndex = 9;
            // 
            // txt_pyt
            // 
            this.txt_pyt.Location = new System.Drawing.Point(372, 135);
            this.txt_pyt.Name = "txt_pyt";
            this.txt_pyt.Size = new System.Drawing.Size(155, 20);
            this.txt_pyt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Название лекции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Путь";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодлекцииDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.путьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturesAddBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(673, 311);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // кодлекцииDataGridViewTextBoxColumn
            // 
            this.кодлекцииDataGridViewTextBoxColumn.DataPropertyName = "Код_лекции";
            this.кодлекцииDataGridViewTextBoxColumn.HeaderText = "Код_лекции";
            this.кодлекцииDataGridViewTextBoxColumn.Name = "кодлекцииDataGridViewTextBoxColumn";
            this.кодлекцииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            this.предметDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // путьDataGridViewTextBoxColumn
            // 
            this.путьDataGridViewTextBoxColumn.DataPropertyName = "Путь";
            this.путьDataGridViewTextBoxColumn.HeaderText = "Путь";
            this.путьDataGridViewTextBoxColumn.Name = "путьDataGridViewTextBoxColumn";
            this.путьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturesAddBindingSource
            // 
            this.lecturesAddBindingSource.DataMember = "LecturesAdd";
            this.lecturesAddBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_obzor
            // 
            this.btn_obzor.Location = new System.Drawing.Point(533, 133);
            this.btn_obzor.Name = "btn_obzor";
            this.btn_obzor.Size = new System.Drawing.Size(75, 23);
            this.btn_obzor.TabIndex = 16;
            this.btn_obzor.Text = "Обзор";
            this.btn_obzor.UseVisualStyleBackColor = true;
            this.btn_obzor.Click += new System.EventHandler(this.btn_obzor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_group
            // 
            this.cmb_group.DataSource = this.groupsBindingSource;
            this.cmb_group.DisplayMember = "Группа";
            this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(139, 133);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(121, 21);
            this.cmb_group.TabIndex = 17;
            this.cmb_group.ValueMember = "Код_группы";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Группа";
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electronic_educational_and_methodical_complex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(592, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 114);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Введите название лекции";
            // 
            // txt_naz
            // 
            this.txt_naz.Location = new System.Drawing.Point(410, 28);
            this.txt_naz.Name = "txt_naz";
            this.txt_naz.Size = new System.Drawing.Size(160, 20);
            this.txt_naz.TabIndex = 20;
            this.txt_naz.TextChanged += new System.EventHandler(this.txt_naz_TextChanged);
            // 
            // lecturesAddTableAdapter
            // 
            this.lecturesAddTableAdapter.ClearBeforeFill = true;
            // 
            // Lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 498);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_naz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_group);
            this.Controls.Add(this.btn_obzor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pyt);
            this.Controls.Add(this.txt_tema);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_deletelectures);
            this.Controls.Add(this.btn_changelectures);
            this.Controls.Add(this.btn_addlectures);
            this.Name = "Lectures";
            this.Text = "Управление лекциями";
            this.Load += new System.EventHandler(this.AddLectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesAddBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_deletelectures;
        private System.Windows.Forms.Button btn_changelectures;
        private System.Windows.Forms.Button btn_addlectures;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.TextBox txt_tema;
        private System.Windows.Forms.TextBox txt_pyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_obzor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private DataBaseDataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DataBaseDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_naz;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lecturesAddBindingSource;
        private DataBaseDataSetTableAdapters.LecturesAddTableAdapter lecturesAddTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодлекцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn путьDataGridViewTextBoxColumn;
    }
}