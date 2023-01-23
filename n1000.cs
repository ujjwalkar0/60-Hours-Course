namespace Program
{
    class N1000
    {
        public N1000()
        {
            int n = 1000;

            if (n < 500)
            {
                System.Console.WriteLine(1000);
            }
            else if (n % 1000 < 500)
            {
                int m = n / 1000;
                System.Console.WriteLine(m * 1000);
            }
            else if (n % 1000 > 500)
            {
                int m = n / 1000 + 1;
                System.Console.WriteLine(m * 1000);
            }
            else if (n >= 500)
            {
                System.Console.WriteLine(1000);
            }

        }
    }
}