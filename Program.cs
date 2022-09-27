using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //System.Collections namespace

        ArrayList liste = new ArrayList();
        liste.Add("Ayşe");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        //İçerisindeki verilere erişim
        Console.WriteLine(liste[1]);

        foreach (var item in liste)
            Console.WriteLine(item);

        //AddRange birden fazla toplu eleman ekleme
        Console.WriteLine("***** AddRange *****");
        string[] renkler = {"Kırmızı","Sari","Yeşil"};
        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
        //liste.AddRange(renkler);
        liste.Clear();
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Sort
        Console.WriteLine("***** Sort *****");
        liste.Sort();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Binary Search
        Console.WriteLine("***** Binary Search *****");
        liste.BinarySearch(9);

        //Reverse
        Console.WriteLine("***** Reverse *****");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Clear
        Console.WriteLine("***** Clear *****");
        liste.Clear();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }
}