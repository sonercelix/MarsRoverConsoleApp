using MarsRoverConsoleApp.Enums;
using System;

namespace MarsRoverConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Platform platform1 = new Platform(5, 5);
            Position position1 = new Position(1, 2);
            Vehicle vehicle1 = new Vehicle(platform1, position1, DirectionEnum.N);
            vehicle1.StepByStepRun("LMLMLMLMM");
            Console.WriteLine(vehicle1.ShowCurrentPosition());

            Platform platform2 = new Platform(5, 5);
            Position position2 = new Position(3, 3);
            Vehicle vehicle2 = new Vehicle(platform2, position2, DirectionEnum.E);
            vehicle2.StepByStepRun("MMRMMRMRRM");
            Console.WriteLine(vehicle2.ShowCurrentPosition());
            Console.ReadLine();
        }
    }
}