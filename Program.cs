// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Out.WriteLine("This is the miracle");
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();

        if (worker1 == worker2) {
            Console.Out.WriteLine("Equals!");
        }
    }

    interface ICanCode<> {
        
    }

    interface e {
        
    }

    class Worker {
        public Worker() {
            ;
        }
    }
}
