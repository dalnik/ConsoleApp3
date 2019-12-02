using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запросить имя пользователя
            Console.Write("Введите имя и нажмите Enter:");
      
      // Прочесть данные; присвоить значение переменной \"name\"
            string name = Console.ReadLine();

            // \"name\" можно использовать как обычную переменную
            Console.WriteLine("Hello, " + name + "!");
      
      // Сделаем это снова, только теперь запросим тип пиццы
            Console.Write("Введите название пиццы и нажмите Enter: ");
      
            string pizza = Console.ReadLine();

            // А теперь используем обе переменные
            Console.WriteLine("Привет, {0}! Одна {1} пицца на подходе!", name, pizza);
      
      // Используем ReadLine() с численными типами
            Console.Write("Введите свой возраст и нажмите Enter: ");
      
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой рост и нажмите Enter (можно использовать дроби): ");
      
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значицца, вам {0} лет, а рост {1}.", age, height);

            // А теперь попросим пользователя нажать \"Enter\" для выхода из программы
            Console.Write("Программа завершена. Нажмите Enter");
      
            Console.ReadLine();
        }
    }
}
