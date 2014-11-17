// Паттерн Singleton. Описывает класс, у которого может быть один единственный экз. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single = Singleton.GetInstance();
            single.flag = true;
            Console.WriteLine("single.flag = " + single.flag);
            Console.ReadLine();

            Singleton single2 = Singleton.GetInstance();
            single2.flag = false;
            Console.WriteLine("single.flag = " + single.flag);
            Console.ReadLine();
        }
    }

    sealed class Singleton
    {
        private Singleton() { } // Закрыли конструктор, чтобы нельзя было извне создать экземпляр данного класса.

        private static Singleton instance = new Singleton();    // Объкт создается при первом обращении к классу.

        public static Singleton GetInstance()   // Возвращает ссылку на объект.
        {
            return instance;
        }

        public bool flag;   // Любой член, смысловая нагрузка класса.
    }
}
