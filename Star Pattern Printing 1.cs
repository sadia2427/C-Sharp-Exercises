﻿using System;

public class StarPattern
{
    public static void Main(string[] args)
    {
        for (int row = 1; row <= 5; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
