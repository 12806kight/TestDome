﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDome
{
   class MalwareAnalysis
    {
        public static int[] Simulate(int[] entries)
        {
           throw new NotImplementedException("Waiting to be implemented.");
        }

        public static void Main(string[] args)
        {
            int[] records = new int[] { 1, 2, 0, 5, 0, 2, 4, 3, 3, 3 };
            var result = Simulate(records);
            Console.WriteLine(result);
        }
    }
}