namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCOUNT MANAGEMENT SYSTEM");

            string username = "superuser";
            string password = "superuser123";

            Console.Write("Enter username: ");
            string usernameinput = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordinput = Console.ReadLine();



            if (usernameinput == username && passwordinput == password)
            {
                Console.WriteLine("Log in Successful!!");
            }
            else
            {
                Console.WriteLine(" Wrong Credentials!!");
            }


        }
    }
}