using System;

namespace data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayList = { 4, 7, 9, 1, 2, 4, 6, 8, 10, 19, 4, 21};
            Console.Write(TwoSums.answer(arrayList, 5));
            //bubbleSort.sort(arrayList);

            /*
            
            foreach (int p in arrayList)
            {
                Console.Write(p + " ");
            }
            Console.Read();

            */
            
        }
    }

    class bubbleSort
    {
        public static void sort(int[] array)
        {
            for(int i = 0; i <= array.Length - 2; i++)
            {
                for(int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }            
        }
    }

    class TwoSums
    { 
        public static int answer(int[] nums, int target)
        {
            int c; 
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.Write("FOUND: " + nums[i] + " + " + nums[j] +"\n");
                        return target;
                    }                   
                }
            }
            return 0;
        }
    }
}

 
