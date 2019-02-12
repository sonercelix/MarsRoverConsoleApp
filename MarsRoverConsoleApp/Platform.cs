using MarsRoverConsoleApp.Interfaces;

namespace MarsRoverConsoleApp
{
    public class Platform : IPlatform
    {
        private int _height;
        private int _width;

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public Platform()
        {
        }

        public Platform(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}