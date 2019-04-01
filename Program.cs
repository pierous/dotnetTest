using System;
using enums;
using model;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            Area area = new Area(5, 5);

            // MMRMMRMRRM
            Drone dron1 = new Drone(3, 3, Orientation.E, area);
            dron1.run("MMRMMRMRRM");
            Console.WriteLine(dron1.getPosition());

            // LMLMLMLMMLMLMLMLMM
            Drone dron2 = new Drone(1, 2, Orientation.N, area);
            dron2.run("LMLMLMLMMLMLMLMLMM");
            Console.WriteLine(dron2.getPosition());

        }
    }
}
