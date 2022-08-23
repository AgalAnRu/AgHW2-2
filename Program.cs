using System;

namespace AgHW2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = new string[6];
            menuItems[0] = "1. Добавить двойку к результату";
            menuItems[1] = "2. Вычесть тройку из результата";
            menuItems[2] = "3. Удвоить результат";
            menuItems[3] = "4. Разделить результат на 5";
            menuItems[4] = "5. Вычесть результат из ста";
            menuItems[5] = "6. Вывести результат и выйти из программы";
            double result = 0;
            char selectedItem;
            foreach (string item in menuItems)
            {
                Console.WriteLine(item);
            }
            do
            {
                selectedItem = Console.ReadKey(true).KeyChar;
                if (selectedItem == '1')
                    result += 2;
                if (selectedItem == '2')
                    result -= 3;
                if (selectedItem == '3')
                    result *= 2;
                if (selectedItem == '4')
                    result /= 5;
                if (selectedItem == '5')
                    result = 100 - result;
                if (selectedItem == '6')
                    Console.WriteLine("Результат вычислений: {0}", result);
            }
            while (selectedItem != '6');
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}
