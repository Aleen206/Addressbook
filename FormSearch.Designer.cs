namespace WindowsFormsApp1
{
    partial class FormSearch
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_searchContent = new System.Windows.Forms.Label();
            this.textBox_searchContent = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_searchContent
            // 
            this.label_searchContent.AutoSize = true;
            this.label_searchContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_searchContent.Location = new System.Drawing.Point(84, 24);
            this.label_searchContent.Name = "label_searchContent";
            this.label_searchContent.Size = new System.Drawing.Size(135, 20);
            this.label_searchContent.TabIndex = 0;
            this.label_searchContent.Text = "输入查询内容";
            // 
            // textBox_searchContent
            // 
            this.textBox_searchContent.Location = new System.Drawing.Point(290, 25);
            this.textBox_searchContent.Name = "textBox_searchContent";
            this.textBox_searchContent.Size = new System.Drawing.Size(253, 25);
            this.textBox_searchContent.TabIndex = 1;
            this.textBox_searchContent.TextChanged += new System.EventHandler(this.textBox_searchContent_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_Tel});
            this.listView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(89, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 310);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_searchContent);
            this.Controls.Add(this.label_searchContent);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_searchContent;
        private System.Windows.Forms.Label label_searchContent;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_Tel;
    }
}