namespace moodleOppgave06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another one...");
            int num2 = Convert.ToInt32(Console.ReadLine());

            static bool checkkIfEqual(int num1, int num2)
            {
                if (num1 == num2)
                {
                    return true;
                }
                return false;
            }

            Console.WriteLine($"Are these numbers equal?: {checkkIfEqual(num1, num2)}");
        }
    }
}