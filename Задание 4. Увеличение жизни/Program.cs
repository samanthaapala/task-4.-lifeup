using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4.Увеличение_жизни
{
    class Program
    {
        static void Main(string[] args)
        {
           
         
            Console.WriteLine("Введите число этажей");
            int Floor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число ступеней на лестнице");
            int Steps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сколько секунд занимает подъем на 1 ступень");
            int Seconds = Convert.ToInt32(Console.ReadLine());

            int lifeUp = (Floor * Steps * Seconds) / 60;

            Console.WriteLine($"Продолжительность вашей жизни увеличилась на {lifeUp} мин.!");
            Console.ReadKey();

        }
    }
}
