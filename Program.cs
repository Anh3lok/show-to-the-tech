using System;

namespace nekit
{
    class Program
{
    static void Main(string[] args)
    {
        int num = 0; 
        // устанавливаем метод обратного вызова
        TimerCallback tm = new TimerCallback(Count);
        // создаем таймер
        Timer timer = new Timer(tm, num, 0, 1000);
        Console.ReadLine();
    }
    public static void Count(object obj)
    {
    
            for (int x= 0; x < 1; x++)
        {
            Console.WriteLine("саламуалейкум" );      
        }
    }
}
}