﻿using System;

namespace Triangle_star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0; i<=num; i++)
            {
               
                for(int j=0; j<=i; j++)
                {
                   
                    Console.Write("*");
                }


                Console.WriteLine();
            }
           

            Console.ReadLine();
        }
    }
}
