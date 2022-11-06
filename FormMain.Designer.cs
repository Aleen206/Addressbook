namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.button_update2 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_telephone = new System.Windows.Forms.Label();
            this.button_update3 = new System.Windows.Forms.Button();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(29, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 44);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(157, 12);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 44);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_edit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_edit.Location = new System.Drawing.Point(425, 12);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 44);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "编辑";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_search.Location = new System.Drawing.Point(281, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 44);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "查找";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(588, 430);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "1";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Visible = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_Tel});
            this.listView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 325);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_telephone);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.textBox_telephone);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Location = new System.Drawing.Point(564, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 155);
            this.panel1.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(73, 20);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(235, 25);
            this.textBox_name.TabIndex = 7;
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(73, 94);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(235, 25);
            this.textBox_telephone.TabIndex = 8;
            // 
            // button_update2
            // 
            this.button_update2.Location = new System.Drawing.Point(737, 424);
            this.button_update2.Name = "button_update2";
            this.button_update2.Size = new System.Drawing.Size(81, 29);
            this.button_update2.TabIndex = 9;
            this.button_update2.Text = "2";
            this.button_update2.UseVisualStyleBackColor = true;
            this.button_update2.Visible = false;
            this.button_update2.Click += new System.EventHandler(this.button_update2_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(21, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(46, 18);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "姓名";
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_telephone.Location = new System.Drawing.Point(21, 95);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(46, 18);
            this.label_telephone.TabIndex = 10;
            this.label_telephone.Text = "电话";
            // 
            // button_update3
            // 
            this.button_update3.BackColor = System.Drawing.Color.OliveDrab;
            this.button_update3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_update3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update3.Location = new System.Drawing.Point(657, 12);
            this.button_update3.Name = "button_update3";
            this.button_update3.Size = new System.Drawing.Size(81, 44);
            this.button_update3.TabIndex = 7;
            this.button_update3.Text = "更新";
            this.button_update3.UseVisualStyleBackColor = false;
            this.button_update3.Click += new System.EventHandler(this.button_update3_Click);
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "姓名";
            this.columnHeader_name.Width = 200;
            // 
            // columnHeader_Tel
            // 
            this.columnHeader_Tel.Text = "电话";
            this.columnHeader_Tel.Width = 200;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.button_update2);
            this.Controls.Add(this.button_update3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Name = "FormMain";
            this.Text = "个人通讯录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_update;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_update2;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_update3;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_Tel;
    }
}

