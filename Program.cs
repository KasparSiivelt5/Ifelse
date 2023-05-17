using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valige meetod (1, 2 või 3):");
        int valik = int.Parse(Console.ReadLine());

        if (valik == 1)
        {
            TeeFailDesktopile();
        }
        else if (valik == 2)
        {
            LoobFailiSisuga();
        }
        else if (valik == 3)
        {
            LoobFailiFailiUrliga();
        }
        else
        {
            Console.WriteLine("Vigane valik!");
        }
    }

    static void TeeFailDesktopile()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiNimi = "fail.txt";
        string failiTee = Path.Combine(desktopPath, failiNimi);

        File.Create(failiTee);
        Console.WriteLine("Fail loodud desktopile: " + failiTee);
    }

    static void LoobFailiSisuga()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiNimi = "fail.txt";
        string failiTee = Path.Combine(desktopPath, failiNimi);

        string sisu = "See on faili sisu, mille olete määranud.";
        File.WriteAllText(failiTee, sisu);

        Console.WriteLine("Fail loodud desktopile sisuga: " + failiTee);
    }

    static void LoobFailiFailiUrliga()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string failiNimi = "fail.txt";
        string failiTee = Path.Combine(desktopPath, failiNimi);

        string url = "https://www.minuurl.com/fail.txt";
        File.WriteAllText(failiTee, url);

        Console.WriteLine("Fail loodud desktopile URL-iga: " + failiTee);
    }
}
