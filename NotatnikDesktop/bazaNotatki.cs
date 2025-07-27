using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotatnikDesktop
{
    public static class bazaNotatek
    {
        private static readonly string sciezka = "Notatki.txt";

        public static void ZapiszNotatki()
        {
            List<string> linie = new List<string>();

            foreach (var para in Program.Notatki)
            {
                string login = para.Key;
                foreach (var notatka in para.Value)
                {
                    linie.Add($"{login}|{notatka}");
                }
            }

            File.WriteAllLines(sciezka, linie);
        }

        public static void WczytajNotatki()
        {
            Program.Notatki.Clear();

            if (!File.Exists(sciezka))
                return;

            var linie = File.ReadAllLines(sciezka);

            foreach (var linia in linie)
            {
                var podziel = linia.Split('|');

                if (podziel.Length >= 2)
                {
                    string login = podziel[0];
                    string notatka = string.Join("|", podziel.Skip(1)); 

                    if (!Program.Notatki.ContainsKey(login))
                        Program.Notatki[login] = new List<string>();

                    Program.Notatki[login].Add(notatka);
                }
            }
        }
    }


}
