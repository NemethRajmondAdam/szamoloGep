using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace szamoloGep
{
    internal class Program
    {

        static List<int> Sorrend(string input)
        {
            List<int> sorrend = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*' || input[i] == '/')
                {
                    sorrend.Add(i);
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-')
                {
                    sorrend.Add(i);
                }
            }

            return sorrend;
        }
        static bool Zarojel(string input)
        {
            bool van = false;

            if (input.Contains("("))
            {
                van = true;
            }

            return van;
        }

        static void Osszesito(int id,List<int> muveletek)
        {
            for(int i = id; i < S)
        }
        
        static List<int> ZarojelKereso(string input)
        {
            List<int> indexek = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == ')')
                {
                    indexek.Add(i);
                }
            }

            return indexek;
        }
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            List<int> szamokIndexe = new List<int>();
            List<int> muveletek = new List<int>();
            List<int> zarojelek = new List<int>();

            Console.Write("Adjon egy egy műveletet: ");
            string input = Console.ReadLine();

            //Ehhez internetes segítséget kértem

            Regex regex = new Regex(@"\d+");

            MatchCollection matches = regex.Matches(input);

            int index = 0;

            foreach (Match match in matches)
            {
                int number;
                if (int.TryParse(match.Value, out number))
                {
                    szamok.Add(number);
                    szamokIndexe.Add(match.Index);
                    index++;
                }
            }


            muveletek = Sorrend(input);
            float eredmeny = 0;

            if (Zarojel(input))
            {
                zarojelek = ZarojelKereso(input);
                if (zarojelek.Count() ==1)
                {
                    int sv = zarojelek[0];

                    for (int i = sv; i < input.Length; i++)
                    {
                        if (!muveletek.Contains(i) && i!=sv)
                        {
                            if (szamokIndexe.Contains(i))
                            {
                                for (int j = 0; j < szamokIndexe.Count(); j++)
                                {
                                    if (szamokIndexe[j] == i)
                                    {
                                        Console.WriteLine(szamok[j]);
                                        if (muveletek.Count >= muveletek[j+1])
                                        {
                                            Console.WriteLine(muveletek[j + 1]);
                                        }
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
