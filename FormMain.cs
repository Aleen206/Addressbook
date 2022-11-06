using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Boolean ischange = true;

        public void addlistviewitem(String[] a)
        {
            ListViewItem item = new ListViewItem(a);
            listView1.Items.Add(item);
        }
        //保存
        public void save()
        {
            FileStream fs = new FileStream(@"通讯录.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                sw.WriteLine(string.Format("{0}|{1}", listView1.Items[i].SubItems[0].Text,
                    listView1.Items[i].SubItems[1].Text));
            }
            sw.Close();
            fs.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //读取通讯录.txt中的每一行保存到a[]中
            String[] a = File.ReadAllLines(@"通讯录.txt", Encoding.Default);
            for (int i = 0; i < a.Length; i++)
            {
                string[] ax = a[i].Split(new String[] { "|" }, StringSplitOptions.None);
                //分割通讯录的一行
                addlistviewitem(ax);//调用方法，添加每一行到表格中
            }


        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            ischange = true;
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.SelectedItems[i];
                listView1.Items.Remove(item);
            }
            save();

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            ischange = true;
            if (listView1.SelectedItems.Count >= 1)
            {
                ListViewItem item = listView1.SelectedItems[listView1.SelectedItems.Count - 1];
                if (!textBox_name.Text.Contains("|") && !textBox_telephone.Text.Contains("|"))
                {

                    if (textBox_name.Text != "")
                    {
                        item.SubItems[0].Text = textBox_name.Text;
                        //item.SubItems[1].Text = textBox_class.Text;
                        item.SubItems[2].Text = textBox_telephone.Text;
                        save();
                        MessageBox.Show("修改成功");
                        textBox_name.Clear();
                        //textBox_class.Clear();
                        textBox_telephone.Clear();
                        MessageBox.Show("请选中一行需要修改的数据");
                    }
                }
                else MessageBox.Show("修改失败，字符“|不是系统定义的特殊字符，请重新输入");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            else
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox_name.Text = item.SubItems[0].Text;
                //textBox_class.Text = item.SubItems[1].Text;
                textBox_telephone.Text = item.SubItems[1].Text;

            }
        }

       

        private void button_update2_Click(object sender, EventArgs e)
        {
            ischange = true;
            if (listView1.SelectedItems.Count >= 1)
            {
                ListViewItem item = listView1.SelectedItems[listView1.SelectedItems.Count - 1];
                if (!textBox_name.Text.Contains("|") && !textBox_telephone.Text.Contains("|"))
                {

                    if (textBox_name.Text != "")
                    {
                        item.SubItems[0].Text = textBox_name.Text;
                       // item.SubItems[1].Text = textBox_class.Text;
                        item.SubItems[1].Text = textBox_telephone.Text;
                        MessageBox.Show("修改成功");
                        textBox_name.Clear();
                        //textBox_class.Clear();
                        textBox_telephone.Clear();
                        MessageBox.Show("请选中一行需要修改的数据");
                    }
                }
                else MessageBox.Show("修改失败，字符“|不是系统定义的特殊字符，请重新输入");
            }
        }

        private void button_update3_Click(object sender, EventArgs e)
        {
            //读取通讯录.txt中的每一行保存到a[]中
            String[] a = File.ReadAllLines(@"通讯录.txt", Encoding.Default);
            for (int i = a.Length-1; i < a.Length; i++)
            {
                string[] ax = a[i].Split(new String[] { "|" }, StringSplitOptions.None);
                //分割通讯录的一行
                addlistviewitem(ax);//调用方法，添加每一行到表格中
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ischange)
            {
                DialogResult result = MessageBox.Show("是否应用到通讯录", "提示信息",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else if (result == DialogResult.Yes)
                {
                    save();
                    e.Cancel = false;
                }
            }
        }
    }
}
