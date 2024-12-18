namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool yesNo)
        {
            if (yesNo)
            {
                int sum = num1 + num2;
                if (sum > 1)
                {
                    return $"{num1 + num2} dollars";
                }
                else return $"{num1 + num2} dollar";
            }
            else return $"No dollars for you!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yes or no: ");
            string yesOrNo = Console.ReadLine();
            bool yesNo = yesOrNo == "yes";
            string result = Add(num1, num2, yesNo);
            Console.WriteLine(result);

            Console.WriteLine(Add(5, 3, true));
            
            Console.WriteLine(Add(4, 2) + " dollars");
            
            Console.WriteLine(Add(1.3m, 4.6m) + " dollars");
            
            
            
        }
    }
}
