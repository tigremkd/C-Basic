using SEDC.Oop.Class05.Homework.SchoolOfMagic.Models;
using System;

namespace SEDC.Oop.Class05.Homework.SchoolOfMagic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizards igor = new Wizards("Igor", 100, 24, new DateTime(31 / 03 / 2020), false);
            Wizards trajan = new Wizards("Trajan", 999, 33, new DateTime(31 / 03 / 1990), true);
            Wizards nikola = new Wizards("Nikola", 500, 30, new DateTime(31 / 03 / 2010), true);
            Wizards milos = new Wizards("Milos", 999, 28, new DateTime(31 / 03 / 2005), true);
            Wizards deda = new Wizards("Deda", 10000, 300, new DateTime(31 / 03 / 1850), true);

            Wizards[] wizzards = new Wizards[] { igor, trajan, nikola, milos};

            Creatures zombie = new Creatures("Zombie", 200, 90, false);
            Creatures goblin = new Creatures("Goblin", 50, 120, false);
            Creatures valkyr = new Creatures("Valkyr", 250, 200, false);
            Creatures ghoul = new Creatures("Ghoul", 35, 25, false);
            Creatures gryphon = new Creatures("Gryphon", 500, 1000, false);

            Creatures[] creatures = new Creatures[] {
                zombie, goblin, valkyr, ghoul, gryphon };

            //Duel(igor, valkyr);
            //Duel(igor, goblin);
            //Duel(nikola, gryphon);
            //Duel(deda,gryphon);
            //Duel(deda, zombie);
            TameCreature(wizzards, creatures);








            Console.ReadLine();
        }
        static void Duel(Wizards wiz, Creatures creature)
        {
            if (!creature.IsTamed)
            {
                if (wiz.PowerLevel > creature.PowerLevel)
                {
                    Console.WriteLine($"{wiz.Name} won the duel and {creature.Name} is now tamed");
                    creature.IsTamed = true;
                }
                else
                {
                    Console.WriteLine($"{creature.Name} power level is higher than the wizzard : {wiz.Name}.");
                }
            }
            else
            {
                Console.WriteLine($"{creature.Name} is already tamed");
            }
        }
        static void TameCreature(Wizards[] wizzards, Creatures[] creatures)
        {

            foreach (Wizards wiz in wizzards)
            {
                foreach (Creatures creature in creatures)
                {
                    if (wiz.PowerLevel > creature.PowerLevel)
                    {
                        creature.IsTamed = true;
                    }

                }
            }
            foreach (Creatures creature in creatures)
            {
                if (!creature.IsTamed)
                {
                    Console.WriteLine($"The creature {creature.Name} cannot be tamed by any wizzard.");
                }
               
            }
        }
    }
}
