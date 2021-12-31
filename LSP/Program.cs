using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player player = new TennisPlayer();
            //player.FirstName = "Daniel";
            //player.LastName = "Alvarez";
            //player.SetCategory(PlayerCategory.Professional);

            Player player = new FootballPlayer();
            player.FirstName = "Daniel";
            player.LastName = "Alvarez";
            player.SetCategory(PlayerCategory.Professional);

            Console.WriteLine("LSP - Liskov Subtitution Principle\n");

            Console.WriteLine("Las clases que hereden de otras clases pueden ser utilizadas por el comportamiento minimo de la clase\n");
            
            Console.Write($"{player.FirstName} {player.LastName} categoria {player.Category}");
            Console.ReadLine();
        }
    }
}
