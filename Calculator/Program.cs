namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result; 

            Console.WriteLine("Welcom To Our Simple Calculatour :)");
            Console.WriteLine("Please Enter The First Number :");
            int number01;
            bool Result01 = int.TryParse(Console.ReadLine() , out number01);

            //Console.WriteLine(number01);

            Console.WriteLine("Please Enter The Second Number :");
            int number02;
            bool Result02 = int.TryParse(Console.ReadLine() , out number02);

            //Console.WriteLine(number02);

            Console.WriteLine("Enter The Operation You Wanna Do : ");
            Console.WriteLine("Enter A for [+] , S for [-] , M for [*] , D for [/] ");

            char Operation;
            bool Result03 = char.TryParse(Console.ReadLine() , out Operation);
            
            if(Operation == 'A' || Operation == 'a')
            {
                Result = number01 + number02;
                Console.WriteLine($"{number01} + {number02} = {Result}");
            }

            else if (Operation == 'S' || Operation == 's')
            {
                Result = number01 - number02;
                Console.WriteLine($"{number01} - {number02} = {Result}");
            }

            else if (Operation == 'M' || Operation == 'm')
            {
                Result = number01 * number02;
                Console.WriteLine($"{number01} * {number02} = {Result}");
            }
            else if (Operation == 'D' || Operation == 'd')
            {
                Result = number01 / number02;
                Console.WriteLine($"{number01} / {number02} = {number01 / number02}");
            }
            else
                Console.WriteLine("Sorry , We Cant Make This Operation :( ");

            Console.WriteLine("Thanks For Using Our Calculator .");

        }
    }
}
