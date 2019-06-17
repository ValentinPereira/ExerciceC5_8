using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string name2;
            int yearBirthday;
            Console.WriteLine("Saisir votre nom "); // demande d'indication avec la console 
            string name = Console.ReadLine(); // paramétrage du nom
            Console.WriteLine(" Saisir son prenom "); // execution du nom
            string name2 = Console.ReadLine(); // parametrage du prenom
            Console.WriteLine(name2); // execution du prenom
            yearBirthday = int.Parse(Console.ReadLine()); // parametrage de l'age avec la variable int
            int age = DateTime.Now.Year - yearBirthday;
            Console.WriteLine( "fiches de renseignement\n\Nom : " + name + "n\prenom : "+ name2 + "\nAge :")
        }
    }
}
