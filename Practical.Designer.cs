
namespace Electronic_educational_and_methodical_complex
{
    partial class Practical
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Electronic_educational_and_methodical_complex.DataBaseDataSet();
            this.btn_obzor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпрактикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.путьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicalAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pyt = new System.Windows.Forms.TextBox();
            this.txt_tema = new System.Windows.Forms.TextBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_deletepractical = new System.Windows.Forms.Button();
            this.btn_changepractical = new System.Windows.Forms.Button();
            this.btn_addpractical = new System.Windows.Forms.Button();
            this.predmetiTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PredmetiTableAdapter();
            this.groupsTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.GroupsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.practicalAddTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PracticalAddTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Группа";
            // 
            // cmb_group
            // 
            this.cmb_group.DataSource = this.groupsBindingSource;
            this.cmb_group.DisplayMember = "Группа";
            this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(139, 136);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(121, 21);
            this.cmb_group.TabIndex = 32;
            this.cmb_group.ValueMember = "Код_группы";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_obzor
            // 
            this.btn_obzor.Location = new System.Drawing.Point(610, 134);
            this.btn_obzor.Name = "btn_obzor";
            this.btn_obzor.Size = new System.Drawing.Size(75, 23);
            this.btn_obzor.TabIndex = 31;
            this.btn_obzor.Text = "Обзор";
            this.btn_obzor.UseVisualStyleBackColor = true;
            this.btn_obzor.Click += new System.EventHandler(this.btn_obzor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
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
            this.кодпрактикиDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.путьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.practicalAddBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(673, 309);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // кодпрактикиDataGridViewTextBoxColumn
            // 
            this.кодпрактикиDataGridViewTextBoxColumn.DataPropertyName = "Код_практики";
            this.кодпрактикиDataGridViewTextBoxColumn.HeaderText = "Код_практики";
            this.кодпрактикиDataGridViewTextBoxColumn.Name = "кодпрактикиDataGridViewTextBoxColumn";
            this.кодпрактикиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            this.предметDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // practicalAddBindingSource
            // 
            this.practicalAddBindingSource.DataMember = "PracticalAdd";
            this.practicalAddBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Путь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Название практики";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Предмет";
            // 
            // txt_pyt
            // 
            this.txt_pyt.Location = new System.Drawing.Point(449, 136);
            this.txt_pyt.Name = "txt_pyt";
            this.txt_pyt.Size = new System.Drawing.Size(155, 20);
            this.txt_pyt.TabIndex = 25;
            // 
            // txt_tema
            // 
            this.txt_tema.Location = new System.Drawing.Point(266, 137);
            this.txt_tema.Name = "txt_tema";
            this.txt_tema.Size = new System.Drawing.Size(177, 20);
            this.txt_tema.TabIndex = 24;
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.DataSource = this.predmetiBindingSource;
            this.cmb_predmet.DisplayMember = "Предмет";
            this.cmb_predmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(12, 137);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_predmet.TabIndex = 23;
            this.cmb_predmet.ValueMember = "Код_предмета";
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(294, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 29);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_deletepractical
            // 
            this.btn_deletepractical.Location = new System.Drawing.Point(201, 12);
            this.btn_deletepractical.Name = "btn_deletepractical";
            this.btn_deletepractical.Size = new System.Drawing.Size(87, 29);
            this.btn_deletepractical.TabIndex = 21;
            this.btn_deletepractical.Text = "Удалить";
            this.btn_deletepractical.UseVisualStyleBackColor = true;
            this.btn_deletepractical.Click += new System.EventHandler(this.btn_deletepractical_Click);
            // 
            // btn_changepractical
            // 
            this.btn_changepractical.Location = new System.Drawing.Point(108, 12);
            this.btn_changepractical.Name = "btn_changepractical";
            this.btn_changepractical.Size = new System.Drawing.Size(87, 29);
            this.btn_changepractical.TabIndex = 20;
            this.btn_changepractical.Text = "Изменить";
            this.btn_changepractical.UseVisualStyleBackColor = true;
            this.btn_changepractical.Click += new System.EventHandler(this.btn_changepractical_Click);
            // 
            // btn_addpractical
            // 
            this.btn_addpractical.Location = new System.Drawing.Point(15, 12);
            this.btn_addpractical.Name = "btn_addpractical";
            this.btn_addpractical.Size = new System.Drawing.Size(87, 29);
            this.btn_addpractical.TabIndex = 19;
            this.btn_addpractical.Text = "Добавить";
            this.btn_addpractical.UseVisualStyleBackColor = true;
            this.btn_addpractical.Click += new System.EventHandler(this.btn_addpractical_Click);
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electronic_educational_and_methodical_complex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(592, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 114);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // practicalAddTableAdapter
            // 
            this.practicalAddTableAdapter.ClearBeforeFill = true;
            // 
            // Practical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 498);
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
            this.Controls.Add(this.btn_deletepractical);
            this.Controls.Add(this.btn_changepractical);
            this.Controls.Add(this.btn_addpractical);
            this.Name = "Practical";
            this.Text = "Управление практиками";
            this.Load += new System.EventHandler(this.Practical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.Button btn_obzor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pyt;
        private System.Windows.Forms.TextBox txt_tema;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_deletepractical;
        private System.Windows.Forms.Button btn_changepractical;
        private System.Windows.Forms.Button btn_addpractical;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private DataBaseDataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DataBaseDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource practicalAddBindingSource;
        private DataBaseDataSetTableAdapters.PracticalAddTableAdapter practicalAddTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпрактикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn путьDataGridViewTextBoxColumn;
    }
}