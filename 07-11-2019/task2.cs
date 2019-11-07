using System;

class GFG
{
    public static void Main(String[] args)
    {
        int[] arr = new int[] { 1, 9, 6, 7, 5, 10 };
        int temp;
        int i = 0;
        while (i < arr.Length )
        {
            int j = i + 1;
            while (j < arr.Length)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                j++;
            }
            i++;
        }

        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
}        