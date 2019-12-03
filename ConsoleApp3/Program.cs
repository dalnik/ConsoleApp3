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
            // Запрос имени
            Console.Write("Введите свое имя ");
            
            // Прочесть данные; присвоить значение переменной \"name\"
            string name = Console.ReadLine();

            // \"name\" можно использовать как обычную переменную
            Console.WriteLine("Hello, " + name + "!");

            // выбор пиццы
            Console.Write("Выберите пиццу.Пицца Одесская, нажмите a, Пицца Южная, нажмите b, Пицца Восточная, нажмите c ");
            Console.ReadLine();

            // Сделаем это снова, только теперь запросим тип пиццы
            Console.Write("Укажите на каком корже: толстом или тонком и нажмите Enter: ");
      
            string pizza = Console.ReadLine();

           
            // Используем ReadLine() с численными типами
            Console.Write("Введите количество пиццы и нажмите Enter: ");
      
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Закажите сок, в стаканах (можно использовать дроби) и нажмите Enter: ");

            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы заказали {0} пиццы, и сок {1}. Нажмите Enter: ", age, height);

            Console.ReadLine();

            // А теперь используем обе переменные
            Console.WriteLine("Привет, {0}! {1} пицца на подходе!", name, pizza);

           

            // А теперь попросим пользователя нажать \"Enter\" для выхода из программы
            Console.Write("Программа завершена. Нажмите Enter");
      
            Console.ReadLine();
        }
    }
}
