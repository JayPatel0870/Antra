namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            fb.FizzBuzzz(100);

            PrecedingCode pc = new PrecedingCode();
            pc.method();

            GuessGame gg = new GuessGame();
            gg.game();

            BirthDaytoDayCalculator bd = new BirthDaytoDayCalculator();
            bd.birthDaytoDayCalculator(2000, 2, 5);

            Greetings g = new Greetings();
            g.greets();

            Increment i = new Increment();
            i.inc();

            Pattern p = new Pattern();
            p.printPattern();
        }

    }
}
