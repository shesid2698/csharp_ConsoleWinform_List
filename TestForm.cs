using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{
    public partial class TestForm : Form
    {
        delegate string GetAccount(List<Member> list, string name); //委派方法
        List<Member> list = Program.GetList();
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            GetAccount getAccount = Program.GetNumber;
            MessageBox.Show(getAccount(list, TBoxSearch.Text));
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            Program.InsertList(list, TBoxAccount.Text, TBoxName.Text);
            if (TBoxAccount.Text != "" && TBoxName.Text != "") MessageBox.Show("新增成功");
            if (TBoxAccount.Text == "" || TBoxName.Text == "") MessageBox.Show("欄位不可空白!!");
        }
    }
}
