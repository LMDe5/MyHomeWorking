using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace plohoe_TZ_result_HZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Scene scene = new Scene(player);
            while (true)
            {
                Console.WriteLine("1. Показать все объекты");
                Console.WriteLine("2. Показать только интерактивные объекты");
                Console.WriteLine("3. Взаимодействовать с объектом по Id");
                Console.WriteLine("4. Отключить объект по Id");
                Console.WriteLine("5. Включить объект по Id");
                int chose = IntInput();
                switch (chose)
                {
                    case 1:
                        scene.PrintAll();
                        break;
                    case 2:
                        scene.PrintOnlyInteractableObjects();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        scene.OnObject(IntInput());
                        break;
                    case 5:
                        scene.OffObject(IntInput());
                        break;
                }
            }

        }
        static int IntInput()
        {
            while (true)
            {
                Console.WriteLine("Введите целое число!");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Введено недопустимое значение!");
                }
            }
        }
    }
}
