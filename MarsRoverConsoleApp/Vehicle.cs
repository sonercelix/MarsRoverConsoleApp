using MarsRoverConsoleApp.Enums;
using System;

namespace MarsRoverConsoleApp
{
    public class Vehicle
    {
        private Platform platform;
        private Position position;
        private DirectionEnum direction;
        public Platform Platform { get { return this.platform; } set { platform = value; } }
        public Position Position { get { return this.position; } set { position = value; } }
        public DirectionEnum Direction { get { return this.direction; } set { direction = value; } }

        public Vehicle()
        {
        }

        public Vehicle(Platform platform, Position position, DirectionEnum direction)
        {
            Platform = platform;
            Position = position;
            Direction = direction;
        }

        public void StepByStepRun(string commands)
        {
            foreach (char item in commands)
            {
                RunCommand(item);
            }
        }

        private void RunCommand(char item)
        {
            switch (item)
            {
                case 'L':
                    TurnLeft();
                    break;

                case 'R':
                    TurnRight();
                    break;

                case 'M':
                    Next();
                    break;

                default:
                    Console.WriteLine("Geçersiz parametre");
                    break;
            }
        }

        private void Next()
        {
            bool isAvailable = PlatformControl();
            if (isAvailable)
            {
                switch (Direction)
                {
                    case DirectionEnum.E:
                        Position.X++;
                        break;

                    case DirectionEnum.N:
                        Position.Y++;
                        break;

                    case DirectionEnum.W:
                        Position.X--;
                        break;

                    case DirectionEnum.S:
                        Position.Y--;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Gidilecek adım yok");
            }
        }

        private bool PlatformControl()
        {
            bool result = false;

            if (Direction == DirectionEnum.N) result = Position.Y < Platform.Height;
            if (Direction == DirectionEnum.S) result = Position.Y > 0
                    ;
            if (Direction == DirectionEnum.E) result = Position.X < Platform.Width;
            if (Direction == DirectionEnum.W) result = Position.X > 0;

            return result;
        }

        private void TurnRight()
        {
            Direction--;
            if ((int)Direction < 1) Direction = DirectionEnum.S;
        }

        private void TurnLeft()
        {
            Direction++;
            if ((int)Direction > 4) Direction = DirectionEnum.E;
        }

        public string ShowCurrentPosition() {
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Direction);
        }
    }
}