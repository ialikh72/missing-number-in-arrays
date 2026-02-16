using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("INPUT NUMBERS");
        for(int i=0;i <arr.Length;i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }
        int start = arr[0];
        for (int i=0; i<arr.Length; i++)
        {
            if (arr[i] != start + i)
            {
                Console.WriteLine("Missing number is: " + (start + i));
                break;
            }
         
        }

    }
}
