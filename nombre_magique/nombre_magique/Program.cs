using System;

namespace nombre_magique
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quele est le nombre magique ?");
            Console.WriteLine("Veuillez choisir un nombre entre 1 et 100:");
            Console.WriteLine();
            try
            {
                // Nombre hasard :
                Random rnd = new Random();
                int nombreMagique = rnd.Next(1, 101);

                int nombre = 0;

                while (nombre != nombreMagique)
                {
                    // nombre choisi
                    string nombreStr = Console.ReadLine();
                    nombre = int.Parse(nombreStr);

                    if (nombre > nombreMagique)
                    {
                        Console.WriteLine("Trop haut!");
                    }
                    else if (nombre < nombreMagique)
                    {
                        Console.WriteLine("Trop bas!");

                    }
                    else
                    {
                        Console.WriteLine("Bravo!");
                        break;
                    }
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

          
        }
    }
}
