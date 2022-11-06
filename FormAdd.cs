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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String s1 = textBox_name.Text;
           // String s2 = textBox_class.Text;
            String s3 = textBox_telephone.Text;
            //这里将字符“|”作为分隔符号，,如果用户的输入包括了这个字符，系统会提示输入
            //不合法并跳过添加，让用户修改自己的输入
            if (!s1.Contains("|") && !s3.Contains("|"))
            {
                if (s1 != "")//用户输入的姓名不能为空
                {

                    String s1a = s1.Trim();
                    //String s2a = s2.Trim();
                    String s3a = s3.Trim();
                    s1 = s1a + "|";
                    //s2 = s2a + "|";
                    s3 = s3a + Environment.NewLine; ;
                    String path = @"通讯录.txt";    //这里使用了绝对路径
                    File.AppendAllText(path, s1 + s3, Encoding.Default);
                    MessageBox.Show("添加成功");

                    textBox_name.Clear();
                   // textBox_class.Clear();
                    textBox_telephone.Clear();
                }
                else MessageBox.Show("用户输入姓名不能为空");
            }
            else
                MessageBox.Show("添加失败，字符“*&$为无效值");
        }
    }
}
