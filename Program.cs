namespace Tasks
{
    static class Program
    {
        public static void Main (string [] args)
        {
            Console.Clear();
            string stringLoad = "Введите номер задачи (от 1 до 3) => ";
            System.Console.Write(stringLoad);
            Tasks(NumberInTerminal(3,stringLoad));
        }
        static void Tasks(int num)
        {
            switch (num)
            {
                case 1:
                {
                    System.Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет ");
                    System.Console.WriteLine("все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.");
                    string firstLine = "Введите значение М =>");;
                    int firstNumber = NumberInTerminal(-1,firstLine);
                    string secondLine ="Введите значение N =>");
                    int secondNumber = NumberInTerminal(-1,secondLine);

                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
                    System.Console.WriteLine("Даны два неотрицательных числа m и n.");

                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы,");
                    System.Console.WriteLine("начиная с конца. Использовать рекурсию, не использовать циклы.");

                    break;
                }
            }
        }
        /*Функция ввода чисел в терминале*/
        public static int NumberInTerminal(int numberDigits, string repeatString)
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString,out numInt)) 
                    || !(numInt > 0) 
                    || !(numInt <= numberDigits)
                  )
            {
                System.Console.WriteLine("Ошибка ввода, повторите");
                System.Console.Write(repeatString);
                numString = Console.ReadLine(); 
            }
            return numInt;
        }

        public static void PrintArray(char [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output += array[i,j] + " ";
                }
                System.Console.WriteLine($"[ {output}]");
                output = "";
            }
        }
    }
}