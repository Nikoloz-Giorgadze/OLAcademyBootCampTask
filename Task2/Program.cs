namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            int temp;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                temp = decimalNumber % 2;
                decimalNumber /= 2;
                result = temp.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}