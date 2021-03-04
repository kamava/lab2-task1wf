using System;

namespace lav2_task3
{
    
    public static class Myclass
    {
        public static string GetArray(this string list, params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                list += $"{strings[i]}";
            }
            return list;
        }
    }

    /*
     * Создайте расширяющий метод: public static T[] GetArray(this MyList list) 
     * Примените расширяющий метод к экземпляру типа MyList.
     * Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zapolnyte kol masiva");
            int r = Convert.ToInt32(Console.ReadLine());
            string[] mass = new string[r];
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("vvedite element massiva");
                mass[i] = Console.ReadLine();
            }
            try
            {
                string s = "result ".GetArray(mass);
                Console.WriteLine(s);
            }
            catch
            {
                Console.WriteLine("vvedite corectnoe znacheniye");
            }
           


        }
    }
}
