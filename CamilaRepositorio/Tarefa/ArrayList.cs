using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {

        
        ArrayList x = new ArrayList();
        x.Add("Camila");
        x.Add("auahauh");
        x.Add("!");

       
        Console.WriteLine("x");
        Console.WriteLine("    Contador:    {0}", x.Count);
        Console.WriteLine("    Capacidade: {0}", x.Capacity);
        Console.Write("    Valores:");
        PrintValues(x);


        Console.ReadLine();
    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.Write("   {0}", obj);
        Console.WriteLine();
    }


}

