using System;

namespace HellApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";     //определяем переменную и инициализируем ее

            Console.WriteLine(name);    //Tom

            name = "Bob";    //меняем значение переменной 
            Console.WriteLine(name);   //Bob

            Console.Read();
            
        }
    }
}
