using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace groupAKTAR
{

    public class Program
    {
        public static void Main()
        {

            Group group = new Group(Group.Generate_group_size());

            while (true)
            {
                Liik m1 = new Liik();
                group.GenerateInfo(m1);
                m1.readinfo();
                group.AddMember(m1);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Group.Read_key(keyInfo, group.Members);


            }

        }

    }
}