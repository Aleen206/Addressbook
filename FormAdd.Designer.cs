namespace WindowsFormsApp1
{
    partial class FormAdd
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
            this.label_add = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_telephone = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_add.Location = new System.Drawing.Point(255, 9);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(114, 20);
            this.label_add.TabIndex = 0;
            this.label_add.Text = "添加联系人";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(168, 76);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名";
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_telephone.Location = new System.Drawing.Point(168, 140);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(51, 20);
            this.label_telephone.TabIndex = 2;
            this.label_telephone.Text = "电话";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(269, 76);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(197, 25);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(269, 135);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(197, 25);
            this.textBox_telephone.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(259, 230);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 48);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_telephone);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_telephone);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_add);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.Button button_add;
    }
}