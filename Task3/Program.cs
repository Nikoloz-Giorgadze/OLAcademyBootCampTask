namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter rectangle sides: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area is: ");
            Method(length, width);
            Console.WriteLine("Enter a rectangular parallelepiped sides and height: ");
            int parallelepipedLength = Convert.ToInt32(Console.ReadLine());
            int parallelepipedWidth = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume is: ");
            Method(parallelepipedLength, parallelepipedWidth, height);

        }
        static void Method(int a, int b)
        {
            int area = a * b;
            Console.WriteLine(area);
        }
        static void Method(int a, int b, int h)
        {
            int volume = a * b * h;
            Console.WriteLine(volume);
        }

    }
}