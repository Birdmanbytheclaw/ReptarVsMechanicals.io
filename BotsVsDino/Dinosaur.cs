using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotsVsDino
{
    class Dinosaur
    {
        public string DinoName;
        public double DinoHealth;
        public double DinoAtkPower;
        public double DinoPowerLevel;

        public Dinosaur(string DinoName)
     
        {
         
            DinoHealth = 999;
            this.DinoName = DinoName;
            DinoPowerLevel = 99;
            DinoAtkPower = 9;
        }

        public void Attack(Robot robot)
        {
            DinoHealth -= 9;
            DisplayDino();

        }
        public void DisplayDino()
        {
            Console.WriteLine("Dino Name Is:  " + DinoName);
            Console.WriteLine("Dino Health Is:  " + DinoHealth);
            Console.WriteLine("Dino ATK Power is :  " + DinoAtkPower);
            Console.WriteLine ("Dino Power Level is:  " + DinoPowerLevel);
        }
        

        
        
    }
}
