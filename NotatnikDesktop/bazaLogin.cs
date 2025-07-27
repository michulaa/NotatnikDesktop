using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotatnikDesktop
{
    class bazaLogin
    {
        public static void Zapislogow()
        {
            var linie = Program.LoginHaslo.Select(n => $"{n.Key}|{n.Value}");
            File.WriteAllLines("Bazalogi.txt", linie);

        }
        public static void WczytanieLogow()
        {
            if (File.Exists("Bazalogi.txt"))
            {
                var linie = File.ReadAllLines("Bazalogi.txt");

                foreach (var linia in linie)
                {
                    var dane = linia.Split('|');
                    if (dane.Length >= 2)
                    {
                        string login = dane[0].Trim();
                        string haslo = dane[1].Trim();

                        if (!Program.LoginHaslo.ContainsKey(login))
                        {
                            Program.LoginHaslo.Add(login, haslo);
                        }
                    }
                }
            }
        }
    }
}
    
