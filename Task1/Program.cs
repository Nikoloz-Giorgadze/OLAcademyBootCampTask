namespace Task1
{
    class Program
    {
        static void Main()
        {
            string username = "Nikoloz";
            string password = "Password";

            Console.WriteLine("Enter username: ");
            string consoleUsername = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string consolePassword = Console.ReadLine();

            if (username == consoleUsername && password == consolePassword)
            {
                Console.WriteLine("Sucess!");
            }
            else
            {
                for (int i = 0; i < 5;)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong password or username try again");
                    Console.WriteLine();

                    Console.WriteLine("Enter username: ");
                    string requestUsername = Console.ReadLine();

                    Console.WriteLine("Enter password: ");
                    string requestPassword = Console.ReadLine();

                    if (requestUsername != username && requestPassword != password)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sucess");
                        break;
                    }
                }
            }
        }
    }
}