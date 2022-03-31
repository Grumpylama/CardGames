global using System;
global using System.Collections.Generic;
global using System.Linq;


// See https://aka.ms/new-console-template for more information


namespace CardGames{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Card card = new Card(4, 4);
            card.DisplayCard(1, 1, 123, 6);
            Console.ReadLine();
        }
    }
}



