using System;
using System.Threading;
using exercice3.classes;

namespace exercice3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //parfois il faut relancer deux fois le programme pour avoir des matricules différents, étant donnée que l'instanciation se fait
            //en même temps, et que rand se base sur le timestamp de l'horloge interne,
            //les valeurs sont les même, ce qui est normal. Mais pas dans le cadre du matricule.
            Employee[] listing = new Employee[10];
            listing[0] = new Ouvrier("Roméo", "Rioli", new DateTime(2003, 3, 5), new DateTime(2001, 5, 3));
            Thread.Sleep(1);
            listing[1] = new Ouvrier("Arthur", "Ryckbosh", new DateTime(2003, 3, 5), new DateTime(2001, 5, 3));
            Thread.Sleep(1);
            listing[2] = new Ouvrier("Valentin", "Michal", new DateTime(2003, 3, 5), new DateTime(2001, 5, 3));
            Thread.Sleep(1);
            listing[3] = new Ouvrier("Lucas", "Brenan", new DateTime(2003, 3, 5), new DateTime(2001, 5, 3));
            Thread.Sleep(1);
            listing[4] = new Ouvrier("Michel", "Vaudou", new DateTime(2003, 3, 5), new DateTime(2001, 5, 3));
            listing[5] = new Cadre("Damien", "Pelaez", new DateTime(1995, 3, 5), 2);
            Thread.Sleep(1);
            listing[6] = new Cadre("Mark", "Zuckerberg", new DateTime(1995, 3, 5), 2);
            Thread.Sleep(1);
            listing[7] = new Cadre("Victor", "Feuillage", new DateTime(1995, 3, 5), 2);
            Thread.Sleep(1);
            listing[8] = new Director("Bernard", "Madof", new DateTime(1982, 3, 5), 4_000_000, 30);
            Thread.Sleep(1);
            listing[9] = new Director("Jean Claude", "Vandam", new DateTime(1982, 3, 5), 4_000_000, 30);
            
            for (int i = 0; i < listing.Length; i++)
            {
                Console.WriteLine(listing[i]);
            }
        }
    }
}