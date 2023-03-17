using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maraton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> adatok = new List<Versenyzo>();

            foreach (var item in File.ReadAllLines("Maraton.txt").Skip(1))
            {
                adatok.Add(new Versenyzo(item));
            }

            List<string> orszagok = new List<string>();

            IDictionary<int, string> vesztesgeci = new Dictionary<int, string>();

            foreach (var item in adatok)
            {
                if (!orszagok.Contains(item.Orszag))
                {
                    string currentString = item.Orszag;
                    int currentInt = 0;
                    orszagok.Add(currentString);
                    foreach (var k in adatok)
                    {
                        if (k.Orszag == currentString)
                        {
                            currentInt++;
                        }

                        vesztesgeci.Add(currentInt, currentString);
                        currentInt = 0;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
