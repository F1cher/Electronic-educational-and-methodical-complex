
namespace Electronic_educational_and_methodical_complex
{
    partial class AddPredmet
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_predmet = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_deletepredmet = new System.Windows.Forms.Button();
            this.btn_changepredmet = new System.Windows.Forms.Button();
            this.btn_addpredmet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(508, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Предмет";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(487, 271);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txt_predmet
            // 
            this.txt_predmet.Location = new System.Drawing.Point(9, 106);
            this.txt_predmet.Name = "txt_predmet";
            this.txt_predmet.Size = new System.Drawing.Size(100, 20);
            this.txt_predmet.TabIndex = 12;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(291, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 29);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_deletepredmet
            // 
            this.btn_deletepredmet.Location = new System.Drawing.Point(198, 12);
            this.btn_deletepredmet.Name = "btn_deletepredmet";
            this.btn_deletepredmet.Size = new System.Drawing.Size(87, 29);
            this.btn_deletepredmet.TabIndex = 10;
            this.btn_deletepredmet.Text = "Удалить";
            this.btn_deletepredmet.UseVisualStyleBackColor = true;
            this.btn_deletepredmet.Click += new System.EventHandler(this.btn_deletepredmet_Click);
            // 
            // btn_changepredmet
            // 
            this.btn_changepredmet.Location = new System.Drawing.Point(105, 12);
            this.btn_changepredmet.Name = "btn_changepredmet";
            this.btn_changepredmet.Size = new System.Drawing.Size(87, 29);
            this.btn_changepredmet.TabIndex = 9;
            this.btn_changepredmet.Text = "Изменить";
            this.btn_changepredmet.UseVisualStyleBackColor = true;
            this.btn_changepredmet.Click += new System.EventHandler(this.btn_changepredmet_Click);
            // 
            // btn_addpredmet
            // 
            this.btn_addpredmet.Location = new System.Drawing.Point(12, 12);
            this.btn_addpredmet.Name = "btn_addpredmet";
            this.btn_addpredmet.Size = new System.Drawing.Size(87, 29);
            this.btn_addpredmet.TabIndex = 8;
            this.btn_addpredmet.Text = "Добавить";
            this.btn_addpredmet.UseVisualStyleBackColor = true;
            this.btn_addpredmet.Click += new System.EventHandler(this.btn_addpredmet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electronic_educational_and_methodical_complex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AddPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_predmet);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_deletepredmet);
            this.Controls.Add(this.btn_changepredmet);
            this.Controls.Add(this.btn_addpredmet);
            this.Name = "AddPredmet";
            this.Text = "Управление предметами";
            this.Load += new System.EventHandler(this.AddPredmet_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_predmet;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_deletepredmet;
        private System.Windows.Forms.Button btn_changepredmet;
        private System.Windows.Forms.Button btn_addpredmet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}