namespace BallAndColorApp
{
    public class Ball
    {
        public int Size { get; private set; }
        public Color Color { get; private set; }
        private int throwCount;

        // Constructor
        public Ball(int size, Color color)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be greater than or equal to 0.");

            Size = size;
            Color = color;
            throwCount = 0;
        }

        // Method to pop the ball
        public void Pop()
        {
            Size = 0;
        }

        // Method to throw the ball
        public void Throw()
        {
            if (Size > 0)
            {
                throwCount++;
            }
        }

        // Method to get the throw count
        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}
