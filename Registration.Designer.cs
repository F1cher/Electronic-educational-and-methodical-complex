
namespace Electronic_educational_and_methodical_complex
{
    partial class Registration
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
            this.txt_fam = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_otch = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet1 = new Electronic_educational_and_methodical_complex.DataBaseDataSet();
            this.groupsTableAdapter = new Electronic_educational_and_methodical_complex.DataBaseDataSetTableAdapters.GroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fam
            // 
            this.txt_fam.Location = new System.Drawing.Point(104, 29);
            this.txt_fam.Name = "txt_fam";
            this.txt_fam.Size = new System.Drawing.Size(138, 20);
            this.txt_fam.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(104, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(138, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_otch
            // 
            this.txt_otch.Location = new System.Drawing.Point(104, 105);
            this.txt_otch.Name = "txt_otch";
            this.txt_otch.Size = new System.Drawing.Size(138, 20);
            this.txt_otch.TabIndex = 2;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(104, 193);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(138, 20);
            this.txt_login.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(104, 230);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(138, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(104, 276);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(123, 23);
            this.btn_reg.TabIndex = 12;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(104, 305);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(123, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_group
            // 
            this.cmb_group.DataSource = this.groupsBindingSource;
            this.cmb_group.DisplayMember = "Группа";
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(104, 150);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(138, 21);
            this.cmb_group.TabIndex = 14;
            this.cmb_group.ValueMember = "Код_группы";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dataBaseDataSet1;
            // 
            // dataBaseDataSet1
            // 
            this.dataBaseDataSet1.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 348);
            this.Controls.Add(this.cmb_group);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_otch);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_fam);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fam;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_otch;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_group;
        private DataBaseDataSet dataBaseDataSet1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DataBaseDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
    }
}