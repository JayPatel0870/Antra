namespace Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = GenerateNumbers();
            //Reverse(numbers);
            //PrintNumbers(numbers);

            //lOOP THROUGH First 10 Fibonacci 
            Console.WriteLine("Looping Throught First 10 Fibonacci");
            int num1 = 1;
            int num2 = 1;
            int[] arr = new int[10];
            arr[0] = num1;
            arr[1] = num2;
            for (int i = 2; i < 10; i++)
            {
                arr[i] = num1 + num2;
                num1 = num2;
                num2 = arr[i];
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Fibonacci Number at a position Method Output: ");
            Fibonacci.FibonacciSequence(3);
        }

        public static int[] GenerateNumbers()
        {
            Console.WriteLine("Enter length of the array you want to create: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        public static void Reverse(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }

        public static void PrintNumbers(int[] arr)
        {
            Console.WriteLine("---------Printing Numbers-----");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


    }
}
