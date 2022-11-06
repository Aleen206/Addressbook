using System;
using System.Collections;
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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void AddlistViewItem(String[] a)//向列表中添加项的方法
        {
            ListViewItem item = new ListViewItem(a);
            listView1.Items.Add(item);
        }
        private void LoadList()
        {
            //读取通讯录.txt中的每一行保存到a[]中
            String[] a = File.ReadAllLines(@"通讯录.txt", Encoding.Default);
            for (int i = 0; i < a.Length; i++)
            {
                string[] ax = a[i].Split(new String[] { "|" }, StringSplitOptions.None);
                //分割通讯录的一行
                AddlistViewItem(ax);//调用方法，添加每一行到表格中
            }
        }
        private void search(string key)
        {
            string[] strArr = File.ReadAllLines(@"通讯录.txt", Encoding.Default);
            ArrayList findText = new ArrayList();
            foreach (string str in strArr)
            {

                if (str.IndexOf(key) != -1)
                {
                    findText.Add(str);
                }
            }

            listView1.Items.Clear();
            foreach (string str in findText)
            {
                string[] ax = str.Split(new String[] { "|" }, StringSplitOptions.None);
                //分割通讯录的一行
                AddlistViewItem(ax);
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void textBox_searchContent_TextChanged(object sender, EventArgs e)
        {
            search(textBox_searchContent.Text);
        }
    }
}
