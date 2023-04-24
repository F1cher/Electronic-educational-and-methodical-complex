
namespace Electronic_educational_and_methodical_complex
{
    partial class AddLectures
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
            this.cmb_perdmet = new System.Windows.Forms.ComboBox();
            this.txt_nazvanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_obzor = new System.Windows.Forms.Button();
            this.dataBaseDataSet = new Electronic_educational_and_methodical_complex.DataBaseDataSet();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetiTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.PredmetiTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_pyt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_perdmet
            // 
            this.cmb_perdmet.DataSource = this.predmetiBindingSource;
            this.cmb_perdmet.DisplayMember = "Предмет";
            this.cmb_perdmet.FormattingEnabled = true;
            this.cmb_perdmet.Location = new System.Drawing.Point(32, 57);
            this.cmb_perdmet.Name = "cmb_perdmet";
            this.cmb_perdmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_perdmet.TabIndex = 0;
            this.cmb_perdmet.ValueMember = "Код_предмета";
            // 
            // txt_nazvanie
            // 
            this.txt_nazvanie.Location = new System.Drawing.Point(32, 118);
            this.txt_nazvanie.Name = "txt_nazvanie";
            this.txt_nazvanie.Size = new System.Drawing.Size(121, 20);
            this.txt_nazvanie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Путь";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_obzor
            // 
            this.btn_obzor.Location = new System.Drawing.Point(191, 187);
            this.btn_obzor.Name = "btn_obzor";
            this.btn_obzor.Size = new System.Drawing.Size(75, 23);
            this.btn_obzor.TabIndex = 7;
            this.btn_obzor.Text = "Обзор";
            this.btn_obzor.UseVisualStyleBackColor = true;
            this.btn_obzor.Click += new System.EventHandler(this.btn_obzor_Click);
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_pyt
            // 
            this.txt_pyt.Location = new System.Drawing.Point(32, 187);
            this.txt_pyt.Name = "txt_pyt";
            this.txt_pyt.Size = new System.Drawing.Size(153, 39);
            this.txt_pyt.TabIndex = 8;
            this.txt_pyt.Text = "";
            // 
            // AddLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 342);
            this.Controls.Add(this.txt_pyt);
            this.Controls.Add(this.btn_obzor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nazvanie);
            this.Controls.Add(this.cmb_perdmet);
            this.Name = "AddLectures";
            this.Text = "Добавить лекцию";
            this.Load += new System.EventHandler(this.AddLectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_perdmet;
        private System.Windows.Forms.TextBox txt_nazvanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_obzor;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private DataBaseDataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txt_pyt;
    }
}