using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Berek2020
{
  class Program
  {
    static List<Dolgozo> dolgozok = new List<Dolgozo>();
    static string reszleg;
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladt();

      Console.ReadKey();
    }

    private static void HetedikFeladt()
    {
      Console.WriteLine("7. feladat: Statisztika");

      Dictionary<string, int> stat = new Dictionary<string, int>();

      foreach (var d in dolgozok)
      {
        if (!stat.ContainsKey(d.Reszleg))
        {
          stat.Add(d.Reszleg, 1);
        }
        else
        {
          stat[d.Reszleg]++;
        }
      }

      foreach (var s in stat)
      {
        Console.WriteLine($"\t{s.Key} - {s.Value} fő");
      }
    }

    private static void HatodikFeladat()
    {
      Console.WriteLine("6. feladat: A legtöbbet kereső dolgozó az adott részlegen");
      int i = 0;
      while (dolgozok[i].Reszleg != reszleg)
      {
        i++;
      }
      Dolgozo temp = dolgozok[i];

      while (i < dolgozok.Count)
      {
        if (dolgozok[i].Reszleg == reszleg && dolgozok[i].Fizetes > temp.Fizetes)
        {
          temp = dolgozok[i];
        }
        i++;
      }

      Console.WriteLine(temp.ToString());
    }

    private static void OtodikFeladat()
    {
      Console.Write("5. feladat: Kérem egy részleg nevét: ");
      reszleg = Console.ReadLine();
    }

    private static void NegyedikFeladat()
    {
      Console.Write("4. feladat: Bérek átlaga:");

      int szum = 0;
      foreach (var d in dolgozok)
      {
        szum += (d.Fizetes);
      }

      Console.WriteLine($" {Math.Round(((double)szum / 1000) / dolgozok.Count,1 )} eFt");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: Dolgozók száma: {dolgozok.Count} fő");
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");

      StreamReader be = new StreamReader("berek2020.txt");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');

        dolgozok.Add(new Dolgozo(
            a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])
          ));
      }


      be.Close();
    }
  }
}
