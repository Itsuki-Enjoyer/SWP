using System;
using System.IO;
using System.Threading;


class Programm
{
    static void Main()
    {
        Console.WriteLine("Ihre Name eingeben");
        string name = Console.ReadLine();
        Console.WriteLine("Alter eingeben: ");
        int age = Int32.Parse(Console.ReadLine());

        SaveFile(name, age);
        Thread.Sleep(2000);
        ReadFile();
        Console.ReadKey();
    }

    static void SaveFile(string name, int age)
    {

        string data = $"Name: {name} \n Alter: {age}";
        if (File.Exists("Daten.txt"))
        {
            Console.WriteLine("Daten werden hinzugefügt...");
            File.AppendAllText("Daten.txt", Environment.NewLine + data);
            Thread.Sleep(2000);
            Console.WriteLine("Daten erfolgreich gespeichert!");
        }
        else
        {
            Console.WriteLine("Daten werden gespeichert...");
            File.WriteAllText("Daten.txt", data);
            Thread.Sleep(2000);
            Console.WriteLine("Daten erfolgreich gespeichert!");
            Console.WriteLine();
        }
        
        
    }
    static void ReadFile()
    {
        Console.WriteLine("Daten werden geladen...");
        Thread.Sleep(2000);
        string data = File.ReadAllText("Daten.txt");
        Console.WriteLine();
        Console.WriteLine(data);

    }

}