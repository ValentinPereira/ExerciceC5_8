using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir votre nom"); // demande à l'utilisateur de saisir son nom
            string name = Console.ReadLine(); // execution pour écrire son nom
            Console.WriteLine(name); // execution du nom 
            Console.WriteLine("Saisir votre prenom"); // demande à l'utilisateur de saisir son prenom
            string name2 = Console.ReadLine(); // execution pour ecrire son prenom
            Console.WriteLine(name2); // execution du prenom
            Console.WriteLine(" Bonjour nous somme le " + DateTime.Now.ToLongDateString() + " Comment allez-vous ? ");
              // Affiche la phrase pour dire bonjour et donner la date et l'heure du jour.

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString(" dd-MM-yyyy"));
            Console.ReadKey();

        }
}
}
