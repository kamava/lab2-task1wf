using System;

namespace lab2_task4
{

    public class MyClass<T> where T : new()
    {

        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    class Program
    {/*
      * Создайте класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(),
      * который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).  
        */
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
