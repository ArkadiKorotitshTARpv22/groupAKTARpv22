using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace groupAKTAR
{

    public class Liik

    {

        public string _nimi;
        public int _age;
        public string _tegelane;
        public Liik(string nimi, int age, string tegelane)
        {
            this._nimi = nimi;
            this._age = age;
            this._tegelane = tegelane;
        }
        public Liik() { }

        public string Nimi
        {
            get => _nimi;
            set => _nimi = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Tegelane
        {
            get => _tegelane;
            set => _tegelane = value;
        }


        public void readinfo()
        {
            Console.WriteLine();
            Console.WriteLine("Nimi = " + Nimi);
            Console.WriteLine("Aastat vana = " + Age);
            Console.WriteLine("Race = " + Tegelane);
        }



    }
}
