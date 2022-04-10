using System;
using System.Collections.Generic;
using System.Linq;

namespace E4._03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heros = new Dictionary<string, Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string heroName = heroInfo[0];  
                int hitPoints = int.Parse(heroInfo[1]); 
                int manaPoints = int.Parse(heroInfo[2]);
                Hero Hero = new Hero(heroName, hitPoints, manaPoints);
                heros.Add(heroName,Hero); 
                
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] instructions = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = instructions[0];    
                string heroName = instructions[1];
                if (action == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(instructions[2]);
                    string spellName = instructions[3];
                    if (heros[heroName].ManaPoints>=manaPointsNeeded)
                    {
                        heros[heroName].ManaPoints -= manaPointsNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heros[heroName].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(instructions[2]);
                    string attacker = instructions[3];  
                    heros[heroName].HitPoints-=damage;
                    if (heros[heroName].HitPoints>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heros[heroName].HitPoints} HP left!");
                    }
                    else
                    {
                        heros.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(instructions[2]);
                    int startMP = heros[heroName].ManaPoints;
                    heros[heroName].ManaPoints += amount;  
                    if (heros[heroName].ManaPoints>200)
                    {
                        amount = 200 - startMP;
                        heros[heroName].ManaPoints = 200;   
                    }
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse (instructions[2]);  
                    int startHP = heros[heroName].HitPoints;
                    heros[heroName].HitPoints += amount;
                    if (heros[heroName].HitPoints>100)
                    {
                        amount=100 - startHP;
                        heros[heroName].HitPoints = 100;
                      
                    }
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
                        

                command = Console.ReadLine();
            }
            foreach (var hero in heros)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($" HP: {hero.Value.HitPoints}");
                Console.WriteLine($" MP: {hero.Value.ManaPoints}");
            }

        }
    }
    class Hero
    {
        public Hero(string heroName, int hitPoints, int manaPoints)
        {
            this.Name = heroName;
            this.HitPoints = hitPoints; 
            this.ManaPoints = manaPoints;   
        }

        public string Name { get; set; }    
        public int HitPoints { get; set; }  
        public int ManaPoints { get; set; }
    }
}
