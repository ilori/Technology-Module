namespace p06_Rectangle_Position
{
    public class Rectangle
    {
        public int Left;
        public int Top;
        public int Width;
        public int Height;
        public int Bottom;
        public int Right;

        public Rectangle(int left, int top, int width, int height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            Bottom = top - height;
            Right = left + width;
        }
    }
}