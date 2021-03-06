﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregate = new ConcreteAggregate<string>
            {
                [0] = "A",
                [1] = "B",
                [2] = "C",
                [3] = "D"
            };

            var iterator = aggregate.CreateIterator();

            for (object e = iterator.First(); iterator.IsDone(); e = iterator.Next())
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
