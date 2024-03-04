namespace Exercise16
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 0 or 1:");
            string a = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Comparision(result1);
            Console.WriteLine("Result is:" + result2);
        }

        public static int Comparision(int a)
        {
            if (a == 0)
                return 1;
            else if (a == 1)
                return 0;
            else
                return a;
        }
    }

}