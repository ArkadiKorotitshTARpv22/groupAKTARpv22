using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace groupAKTAR
{
    public class Group
    {
        public List<string> names = new List<string> { "Arkadi", "Luca", "Kirill", "Andrei", "Egor", "Oleksander", "Martin", "Artur", "Kristian", "Yaroslav" };
        public List<string> tegelaneL = new List<string> { "Sõbralik", "Huvitatud", "Lahke", "Agressiivne", "Seltskondlik" };
        public List<Liik> Members = new List<Liik>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public Group()
        {
        }



        public void AddMember(Liik member)
        {

            if (Members.Count >= _maxAmount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Grupp on täis");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (Members.Any(m => m.Nimi == member.Nimi && m.Age == member.Age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ruhmas on juba mees selle nime ja vanuse");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Members.Add(member);
                Console.WriteLine("Isik on lisatud gruppi");
                Console.ForegroundColor = ConsoleColor.Gray;
            }



        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liik member)
        {
            return (Members.Any(m => m.Nimi == member.Nimi));
        }

        public Liik GenerateInfo(Liik m2)
        {
            Random rnd = new Random();

            int Age = rnd.Next(16, 41);
            int elmentforfoundingrandomname = rnd.Next(0, 10);
            int elmentforfoundingrandomtegelane = rnd.Next(0, 5);
            string Name = names[elmentforfoundingrandomname];
            string Tegelane = tegelaneL[elmentforfoundingrandomtegelane];
            m2.Nimi = Name;
            m2.Age = Age;
            m2.Tegelane = Tegelane;


            return m2;
        }
        public static int Generate_group_size()
        {
            Random rnd = new Random();
            int counter = rnd.Next(2, 10);
            Console.WriteLine("Grupi suurus on {0}", counter);
            Console.WriteLine();
            return counter;
        }



        public static void Read_key(ConsoleKeyInfo keyInfo, List<Liik> Members)
        {

            if (keyInfo.KeyChar == 'n')
            {

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Kõik rühma liikmed: ");

                foreach (Liik item in Members)
                {
                    item.readinfo();
                }
                Console.WriteLine();
                Group.foundoldest(Members);
                Group.foundyoungest(Members);
                Group.DestroyProgram();

            }
            Console.WriteLine();
        }
        public static void DestroyProgram()
        {
            Console.ReadKey();
            Environment.Exit(30);
        }

        public static void foundoldest(List<Liik> Members)
        {
            Liik m1 = new Liik("Fill", 0, "Fill");
            foreach (Liik item in Members)
            {
                if (item.Age > m1.Age)
                {
                    m1 = item;
                }
            }
            Console.WriteLine("Vanim liige on {0} ja ta on {1}", m1.Nimi, m1.Age);
            Console.WriteLine();

        }

        public static void foundyoungest(List<Liik> Members)
        {
            Liik m1 = new Liik("Fill", 100, "Fill");
            foreach (Liik item in Members)
            {
                if (item.Age < m1.Age)
                {
                    m1 = item;
                }
            }
            Console.WriteLine("Noorim liige on {0} ja ta on {1}", m1.Nimi, m1.Age);
            Console.WriteLine();
        }
    }

}
