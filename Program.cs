namespace HW_GB_000
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(" ");
            if (input.Length == 3)
            {
                int result = 0;
                int number1 = int.Parse(input[0]);
                string operation = input[1];
                int number2 = int.Parse(input[2]);
                if (operation == "+")
                {
                    result = number1 + number2;
                }
                if (operation == "-")
                {
                    result = number1 - number2;
                }
                if (operation == "/")
                {
                    result = number1 / number2;
                }
                if (operation == "*")
                {
                    result = number1 * number2;
                }
                Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
            }
            else
                Console.WriteLine("Для использования программы введите: число пробел знак(+-/*) пробел число");
}
}
}