﻿using System;

namespace Iterator
{
    /// <summary>
    /// Provide a way to access the elements of an aggregate object
    /// sequentially without exposing its underlying representation.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var tree = new Tree<string>("0")
            {
                LeftNode = new Tree<string>("1")
                {
                    LeftNode = new Tree<string>("2")
                    {
                        LeftNode = new Tree<string>("8"),
                        RightNode = new Tree<string>("9")
                    },
                    RightNode = new Tree<string>("5")
                },
                RightNode = new Tree<string>("3")
                {
                    LeftNode = new Tree<string>("6"),
                    RightNode = new Tree<string>("7")
                }
            };

            var list = tree.ToList();

            Console.WriteLine("Non iterator tree");
            Console.WriteLine(string.Join(" ", list));

            var tree2 = new TreeWithIterator<string>("0")
            {
                LeftNode = new TreeWithIterator<string>("1")
                {
                    LeftNode = new TreeWithIterator<string>("2")
                    {
                        LeftNode = new TreeWithIterator<string>("8"),
                        RightNode = new TreeWithIterator<string>("9")
                    },
                    RightNode = new TreeWithIterator<string>("5")
                },
                RightNode = new TreeWithIterator<string>("3")
                {
                    LeftNode = new TreeWithIterator<string>("6"),
                    RightNode = new TreeWithIterator<string>("7")
                }
            };

            Console.WriteLine();
            Console.WriteLine("Iterator tree");

            foreach (var item in tree2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Direct root children");

            foreach (var item in tree2.GetChildren())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
