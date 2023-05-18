
namespace Electronic_educational_and_methodical_complex
{
    partial class AddGroups
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
            this.btn_addgroups = new System.Windows.Forms.Button();
            this.btn_changegroups = new System.Windows.Forms.Button();
            this.btn_deletegroups = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addgroups
            // 
            this.btn_addgroups.Location = new System.Drawing.Point(9, 12);
            this.btn_addgroups.Name = "btn_addgroups";
            this.btn_addgroups.Size = new System.Drawing.Size(87, 29);
            this.btn_addgroups.TabIndex = 0;
            this.btn_addgroups.Text = "Добавить";
            this.btn_addgroups.UseVisualStyleBackColor = true;
            this.btn_addgroups.Click += new System.EventHandler(this.btn_addgroups_Click);
            // 
            // btn_changegroups
            // 
            this.btn_changegroups.Location = new System.Drawing.Point(102, 12);
            this.btn_changegroups.Name = "btn_changegroups";
            this.btn_changegroups.Size = new System.Drawing.Size(87, 29);
            this.btn_changegroups.TabIndex = 1;
            this.btn_changegroups.Text = "Изменить";
            this.btn_changegroups.UseVisualStyleBackColor = true;
            this.btn_changegroups.Click += new System.EventHandler(this.btn_changegroups_Click);
            // 
            // btn_deletegroups
            // 
            this.btn_deletegroups.Location = new System.Drawing.Point(195, 12);
            this.btn_deletegroups.Name = "btn_deletegroups";
            this.btn_deletegroups.Size = new System.Drawing.Size(87, 29);
            this.btn_deletegroups.TabIndex = 2;
            this.btn_deletegroups.Text = "Удалить";
            this.btn_deletegroups.UseVisualStyleBackColor = true;
            this.btn_deletegroups.Click += new System.EventHandler(this.btn_deletegroups_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(288, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 29);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(12, 106);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 20);
            this.txt_group.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 277);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Группа";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electronic_educational_and_methodical_complex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(428, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 114);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_deletegroups);
            this.Controls.Add(this.btn_changegroups);
            this.Controls.Add(this.btn_addgroups);
            this.Name = "AddGroups";
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.AddGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addgroups;
        private System.Windows.Forms.Button btn_changegroups;
        private System.Windows.Forms.Button btn_deletegroups;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}