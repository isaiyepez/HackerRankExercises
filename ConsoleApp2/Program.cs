using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float[] counter = new float[3];

        for (int i = 0; i < arr.Count(); i++)
        {
            Console.WriteLine("Element to evaluate: " + arr[i]);

            if (arr[i] > 0)
            {
                counter[0] += 1;
                Console.WriteLine("Positive: " + arr[i]);
                Console.WriteLine("Count Positive: " + counter[0]);
            }
            else if (arr[i] < 0) {               
                counter[1] += 1;
                Console.WriteLine("Negative: " + arr[i]);
                Console.WriteLine("Count Negative: " + counter[1]);
            } 
            else
            {
                counter[2] += 1;
                Console.WriteLine("zero: " + arr[i]);
                Console.WriteLine("Count of zero: " + counter[2]);
            }
        }

        Console.WriteLine("Number of positives " + counter[0]);
        Console.WriteLine("Number of negatives " + counter[1]);
        Console.WriteLine("Number of zero " + counter[2] );

        Console.WriteLine(String.Format("{0:N6}", counter[0] / arr.Count));
        Console.WriteLine(String.Format("{0:N6}", counter[1] / arr.Count));
        Console.WriteLine(String.Format("{0:N6}", counter[2] / arr.Count));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int[] test = { 1, -2, 0, 3, -1 };
        Result.plusMinus(test.ToList());
    }
}
