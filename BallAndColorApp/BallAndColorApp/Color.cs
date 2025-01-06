namespace BallAndColorApp
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        // Constructor with Red, Green, Blue, and Alpha
        public Color(int red, int green, int blue, int alpha)
        {
            Red = ValidateColorValue(red);
            Green = ValidateColorValue(green);
            Blue = ValidateColorValue(blue);
            Alpha = ValidateColorValue(alpha);
        }

        // Constructor with Red, Green, Blue (default Alpha = 255)
        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        // Method to validate color values (0-255)
        private int ValidateColorValue(int value)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException(nameof(value), "Color value must be between 0 and 255.");
            return value;
        }

        // Method to get grayscale value
        public int GetGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
