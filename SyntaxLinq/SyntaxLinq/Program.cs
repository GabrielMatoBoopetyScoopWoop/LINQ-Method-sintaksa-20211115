using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] rijeci = {"ime", "prezime", "nekarecenica"};

        var result = rijeci.Where(a => a.Contains("ime"));

        foreach (var odgovor in result)
        {
            Console.WriteLine(odgovor);
        }
        Console.ReadKey();
    }
}