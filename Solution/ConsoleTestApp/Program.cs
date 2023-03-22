using Domain;

namespace ConsoleTestApp {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("This is a test!");

            ExampleService service = new();
            int result = service.Addition(5, 3);

            Console.WriteLine("5 + 3 = " + result.ToString());
        }
    }
}