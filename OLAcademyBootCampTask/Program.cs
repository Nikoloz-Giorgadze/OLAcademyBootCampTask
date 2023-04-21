namespace OLAcademyBootCampTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username = "Nikoloz";
            string password = "Password";

            Console.WriteLine("Enter username: ");
            string? consoleUsername = Console.ReadLine();
            if (consoleUsername is null)
                Console.WriteLine("Enter username!");

            Console.WriteLine("Enter password: ");
            string? consolePassword = Console.ReadLine();
            if (consolePassword is null)
                Console.WriteLine("Enter password!");

            if (username == consoleUsername && password == consolePassword)
            {
                Console.WriteLine("Sucess");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong password or username try again");
                    Console.WriteLine();
                    Console.WriteLine("Enter username: ");
                    string? requestUsername = Console.ReadLine();
                    if (requestUsername is null)
                        Console.WriteLine("Enter username!");
                    Console.WriteLine("Enter password: ");
                    string? requestPassword = Console.ReadLine();
                    if (requestPassword is null)
                        Console.WriteLine("Enter password!");
                    if (consoleUsername == username && consoleUsername == password)
                    {
                        Console.WriteLine("Sucess");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Error!");
            }
        }
    }
}