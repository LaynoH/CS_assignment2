// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 1. Copying an Array
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copyArr = new int[arr.Length];
for (int i =0; i<arr.Length;i++) copyArr[i] = arr[i];


// 2.
List<String> grocery = new List<String>();
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string inputItem = Console.ReadLine();
    if (inputItem[0] == '+') grocery.Add(inputItem[1..(inputItem.Length)]);
    else if (inputItem[0] == '-' && inputItem[1] != '-') grocery.Remove(inputItem[1..(inputItem.Length)]);
    else if (inputItem[0] == '-' && inputItem[1] == '-') grocery.Clear();
    
    foreach (var i in grocery) Console.WriteLine(i);
}



// 3.
/*
using System;
using System.Runtime.ConstrainedExecution;

namespace assign2
{
    class Program
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeTmp = new List<int>();
            for (int i = startNum; i<=endNum; i++)
            {
                int flag = 0;
                for (int j=2;j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag == 0 && i != 1) primeTmp.Add(i);
            }
            int[] prime = primeTmp.ToArray();
            return prime;
        }

        public static void Main()
        {
            Console.WriteLine("Enter range: ");
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int[] res = FindPrimesInRange(startNum, endNum);
            foreach (var i in res) Console.Write(i+" ");
            Console.WriteLine();
        }
    }
}
*/


// 4.
/*
using System;

string[] inputS = Console.ReadLine().Split(' ');
int rotate = int.Parse(Console.ReadLine());
int[] inputInt = Array.ConvertAll(inputS, int.Parse);
int[] sum = new int[inputInt.Length];
Array.Clear(array: sum, 0, inputInt.Length);

// rotation bigger than length then we can skip some loop
// cause rotation = length = 0
rotate = rotate % inputInt.Length;
// rotation
for (int i=1;i<=rotate;i++)
{
    // getting value of each location in array
    for (int j=0; j<inputInt.Length;j++)
    {
        int tmp = inputInt[(j + inputInt.Length - i) % inputInt.Length];
        Console.Write(tmp+" ");
        sum[j] += tmp;

    }
    Console.WriteLine();
}

foreach (var i in sum) Console.Write(i + " ");
*/


// 5.
/*
string[] inputS = Console.ReadLine().Split(' ');
int[] inputInt = Array.ConvertAll(inputS, int.Parse);
int longest = 1, tmpL = 1, tmpNum = inputInt[0], num = inputInt[0];

for (int i =1;i<inputInt.Length;i++)
{
    if (inputInt[i] == tmpNum)
    {
        tmpL++;
    }
    else
    {
        tmpNum = inputInt[i];
        tmpL = 1;
    }

    if (tmpL>longest)
    {
        longest = tmpL;
        num = tmpNum;
    }
}

for (int i=0; i<longest;i++)
{
    Console.Write(num + " ");
}
*/


// 7.
/*
using System;
using System.Linq;

string[] inputS = Console.ReadLine().Split(' ');
int[] inputInt = Array.ConvertAll(inputS, int.Parse);
int maxValue = inputInt.Max();
int[] freq = new int[maxValue+1];
int maxFreq = 0, flag=0;

for (int i=0;i<inputInt.Length;i++)
{
    freq[inputInt[i]]+=1;
}

for (int i=0;i<inputInt.Length;i++)
{
    if (freq[inputInt[i]]>maxFreq)
    {
        maxValue = inputInt[i];
        maxFreq = freq[inputInt[i]];
    }else if (freq[inputInt[i]] == maxFreq)
    {
        flag = 1;
    }
}

if (flag==0)
{
    Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", maxValue, maxFreq);
}
else
{
    Console.WriteLine("The leftmost number {0} that has the most frequent (occurs {1} times)", maxValue, maxFreq);
}
*/