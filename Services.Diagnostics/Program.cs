namespace Services.Diagnostics
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string PrintDiagnostics()
        {
            string message = "Hello from diagnostics service";
            Console.WriteLine(message);
            return message;
        }
    }
}