using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotsVsDino
{
     class Robot
    {
        public string RoboName;
        public double RoboHealth;
        public double  RoboAtkPower;
        public double RoboPowerLevel;

        public Robot(string RoboName)
        {
            RoboPowerLevel = 99;
            RoboHealth = 999;
            this.RoboName = RoboName;
            RoboAtkPower = 9;
        }

        public void Attack(Dinosaur dinosaur)
        {
            RoboHealth -= 9;
            DisplayRobot();
        }
        public void DisplayRobot()
        {
            Console.WriteLine(RoboName);
            Console.WriteLine(RoboHealth);
            Console.WriteLine(RoboAtkPower);
            Console.WriteLine(RoboPowerLevel);
        }
            

       
           
    }
}
