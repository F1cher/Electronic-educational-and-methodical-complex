
namespace Electronic_educational_and_methodical_complex
{
    partial class AnswersPractical
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
            this.txt_pyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Electronic_educational_and_methodical_complex.DataBaseDataSet();
            this.cmb_tema = new System.Windows.Forms.ComboBox();
            this.practicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_obzor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.predmetiTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PredmetiTableAdapter();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.practicalTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PracticalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pyt
            // 
            this.txt_pyt.Location = new System.Drawing.Point(266, 28);
            this.txt_pyt.Name = "txt_pyt";
            this.txt_pyt.Size = new System.Drawing.Size(210, 20);
            this.txt_pyt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл с ответом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите задание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите предмет";
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.DataSource = this.predmetiBindingSource;
            this.cmb_predmet.DisplayMember = "Предмет";
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(12, 28);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_predmet.TabIndex = 6;
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
            // cmb_tema
            // 
            this.cmb_tema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_tema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_tema.DataSource = this.practicalBindingSource;
            this.cmb_tema.DisplayMember = "Название";
            this.cmb_tema.FormattingEnabled = true;
            this.cmb_tema.Location = new System.Drawing.Point(139, 28);
            this.cmb_tema.Name = "cmb_tema";
            this.cmb_tema.Size = new System.Drawing.Size(121, 21);
            this.cmb_tema.TabIndex = 7;
            this.cmb_tema.ValueMember = "Код_практики";
            // 
            // practicalBindingSource
            // 
            this.practicalBindingSource.DataMember = "Practical";
            this.practicalBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // btn_obzor
            // 
            this.btn_obzor.Location = new System.Drawing.Point(482, 26);
            this.btn_obzor.Name = "btn_obzor";
            this.btn_obzor.Size = new System.Drawing.Size(75, 23);
            this.btn_obzor.TabIndex = 8;
            this.btn_obzor.Text = "Обзор";
            this.btn_obzor.UseVisualStyleBackColor = true;
            this.btn_obzor.Click += new System.EventHandler(this.btn_obzor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 136);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(266, 76);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 38);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Electronic_educational_and_methodical_complex.Properties.Resources.logo;
            this.pictureBox6.Location = new System.Drawing.Point(563, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(93, 114);
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // practicalTableAdapter
            // 
            this.practicalTableAdapter.ClearBeforeFill = true;
            // 
            // AnswersPractical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 158);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_obzor);
            this.Controls.Add(this.cmb_tema);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pyt);
            this.Name = "AnswersPractical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохранение ответов по практике";
            this.Load += new System.EventHandler(this.Answers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicalBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_tema;
        private System.Windows.Forms.Button btn_obzor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private DataBaseDataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.BindingSource practicalBindingSource;
        private DataBaseDataSetTableAdapters.PracticalTableAdapter practicalTableAdapter;
    }
}