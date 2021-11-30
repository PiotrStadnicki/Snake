using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
     public class Meal
    {
        public Meal()
        {
            Random rand = new Random();
            var x = rand.Next(1, 20);
            var y = rand.Next(1, 20);
            CurrentTarget = new Coordinate(x, y);
            Draw();
        }
        public Coordinate CurrentTarget { get; set; }

        void Draw()
        {
            //okodować aby nie mógł sie pojawić w węzu
            Console.SetCursorPosition(CurrentTarget.X, CurrentTarget.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");
        }
        
    }
}
