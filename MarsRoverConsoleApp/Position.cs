using MarsRoverConsoleApp.Interfaces;

namespace MarsRoverConsoleApp
{
    public class Position : IPosition
    {
        private int _x;
        private int _y;
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
        public Position()
        {
        }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}