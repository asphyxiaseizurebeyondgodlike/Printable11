using System;

interface Printable 
{
    void Print();
}
    
class Book : Printable
{
    public void Print()
    {
        static void printBooks(Printable[] printables)
        {
            foreach (Printable Book in printables)
            {
                Console.WriteLine(Book);
            }
        }
    }
}

class Magazine : Printable
{
    public void Print()
    {
        static void printBooks(Printable[] printables)
        {
            foreach (Printable Magazine in printables)
            {
                Console.WriteLine(Magazine + "QWE");
            }
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Printable[] booksAndMagazines = { new Book(), new Magazine() };
        foreach (Printable i in booksAndMagazines)
        {
            i.Print();
        }
    }
}
    

