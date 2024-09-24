using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is there life on Mars?");
            Console.WriteLine("Vad heter du?");
            var myName = Console.ReadLine();
            Console.WriteLine($"Välkommen {myName}!");

            Console.WriteLine("\n");

            var myName2 = "Joakim";
            Console.WriteLine($"Jag heter {myName2}!");

            Console.WriteLine("\n");

            Console.WriteLine("Hej, vad heter du?");
            var userName = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            var userAge = Console.ReadLine();
            Console.WriteLine($"Hej, {userName}, du är {userAge} år gammal!");

            //Comment
            /*Comment*/

            Console.WriteLine("In ten years you'll be " + (userAge + 10) + "years old");
            // userAge är en string och inte en int, därför blir det t.ex: 3010
        }
    }
}
