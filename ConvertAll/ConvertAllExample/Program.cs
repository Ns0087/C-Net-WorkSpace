﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace ConvertAllExample
{
    class Program
    {
        static void Main()
        {
            //create source collection
            List<int> intCollection = new List<int>() { 1, 8, 2, 7 };

            //read each value into lambda expression; convert the same value into string
            List<string> strCollection = intCollection.ConvertAll<string>((n) =>
            {
                //string word;

                return  n switch
                {
                    1 => "One",
                    2 => "Two",
                    3 => "Three",
                    4 => "Four",
                    5 => "Five",
                    6 => "Six",
                    7 => "Seven",
                    8 => "Eight",
                    9 => "Nine",
                    _ => "",
                };

                //switch (n)
                //{
                //    case 1: word = "One"; break;
                //    case 2: word = "Two"; break;
                //    case 3: word = "Three"; break;
                //    case 4: word = "Four"; break;
                //    case 5: word = "Five"; break;
                //    case 6: word = "Six"; break;
                //    case 7: word = "Seven"; break;
                //    case 8: word = "Eight"; break;
                //    case 9: word = "Nine"; break;
                //    default: word = ""; break;
                //}

                //return word;
            });

            //print the result collection
            foreach (string item in strCollection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
