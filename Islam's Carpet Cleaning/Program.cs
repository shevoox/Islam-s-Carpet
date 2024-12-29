namespace Islam_s_Carpet_Cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet,\n");
            Console.Write("Number of small carpets: ");
            int smalCarpet =Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room 25$");
            Console.WriteLine("Price per Large room 35$\n");
            double cost = (smalCarpet * 25) + (largeCarpet * 35);
            double tax = cost*6/100;
            Console.WriteLine($"Cost:{cost}$");
            Console.WriteLine($"Tax:{tax}$");
            Console.WriteLine("===================");
            double total=cost+tax;
            Console.WriteLine($"Total Estimate:{total}$");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
