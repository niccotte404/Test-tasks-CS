using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Prog2
    {
        public static int Main(string[] args)
        {
            int start, end;
            FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end);
            Console.WriteLine($"{start} {end}");
            return 0;
        }
        
        public static void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;
            uint segmentSum = 0;
            int i = 0;
            while (i < list.Count()+1){
                if (segmentSum > sum)
                {
                    segmentSum -= list[start];
                    start++;
                    continue;
                }
                if (segmentSum == sum)
                {
                    end = i++;
                    return;
                }
                if (i >= list.Count())
                {
                    return;
                }
                segmentSum += list[i];
                i++;
            }
        }
    }

}