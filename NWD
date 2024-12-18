namespace Algorithms
{
    // Najwyzszy wspolny dzielnik
    class Euklides
    {
        static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main()
        {
            int result = NWD(10, 15);
            Console.WriteLine($"NWD of 10 and 15 is: {result}");
        }
    }
}
