using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string sciezka = "ranking_raw.txt";
        string outpath = "ranking_clear.txt";
        if (!File.Exists(sciezka))
        {
            return;
        }
        string[] linieTablica = File.ReadAllLines(sciezka);
        if (linieTablica.Length == 0)
        {
            return;
            
        }
        List<string> wynik = new List<string>();
        string header = linieTablica[0];
        wynik.Add(header);
        
        for (int i = 1; i < linieTablica.Length; i++)
        {
            string linia = linieTablica[i];

            // pomijamy puste linie
            if (string.IsNullOrWhiteSpace(linia)) continue;
            // Rozbijamy linię na 5 pól
            string[] pola = linia.Split(';');

            // Sprawdzenie, czy rzeczywiście jest 5 elementów
            if (pola.Length != 5)
            {
                Console.WriteLine($"Linia {i} ma złą liczbę pól: {linia}");
                continue;
            }
            string nick = pola[0]; // ID
            string czas = pola[1]; // Nazwa
            string punktyTekst = pola[2]; // Kategoria
            string status = pola[3]; // Cena
            string opis = pola[4]; // Ilosc

            bool badTime = (czas == "00:00:01" || czas == "0:00:01");
            bool hacker = (status == "Hacker" || badTime);
            if (hacker)
            {
                continue;
            }

            int punkty;
            if (!int.TryParse(punktyTekst, out punkty))
            {
                punkty = 0;
            }

            string newLine = $"{nick};{czas};{punkty};{status};{opis}";
            wynik.Add(newLine);
        }
        File.WriteAllLines(outpath, wynik);
        string[] fixedLinie = File.ReadAllLines(outpath);
        // 5. Wyświetlamy nową zawartość pliku
        Console.WriteLine();
        
        foreach (string l in fixedLinie)
        {
            Console.WriteLine(l);
        }
    }
}