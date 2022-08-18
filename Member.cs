using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    internal class Member:Program
    {
        public string Account { get; set; }
        public string Name { get; set; }
        public Member(string account, string name)
        {
            Account = account;
            Name = name;
        }
    }
}
