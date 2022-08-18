using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{
    class Program
    {
        public static List<Member> GetList()
        {
            List<Member> listMember = new List<Member>() //泛型
            {
                new Member("M01","小明"),
                new Member("M02","小龍"),
                new Member("M03","小白"),
                new Member("shesid2698","Sid"),
            };
            return listMember;
        }
        static void Main(string[] args)
        {
            //List<int> listInt = new List<int>();
            //listInt.Add(123);
            //listInt.Add(789);
            //listInt.Insert(1,456);

            //foreach(int i in listInt)
            //{
            //    Console.WriteLine(i+"\n");
            //}

            //------------
            //List<Member> list = GetList();
            //InsertList(list, "apple123", "app");
            //Console.WriteLine(list.FindIndex(r=>r.Name.StartsWith("app")));
            //Console.ReadLine();
            //------------




            ////listMember.RemoveAt(1);  //去除索引值1的資料
            //Console.WriteLine(listMember[1].Name);
            //int a= listMember.FindIndex(r => r.Name.StartsWith("小白")); //lamda的查詢方法

            TestForm form = new TestForm();
            form.ShowDialog();

        }
        public static string GetNumber(List<Member> list,string name)
        {
            string account = "";
            int a = list.FindIndex(r=>r.Name.StartsWith(name));
            if (a >= 0)
            {
                account=list[a].Account;
            }
            return account;
        }

        public static void InsertList(List<Member> list,string account,string name)
        {
            list.Add(new Member(account,name));
        }
    }
}
