namespace StackandHeapTasks_01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = { 4, 5, 7, 8 };
                
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                InsertArray(arr, 12, 14, 15, 16);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }



            }
             static void InsertArray(int[] number, params int[] numbers )
            {
                int newLength = numbers.Length + number.Length;
                int[] NewArray = new int[newLength];

                for (int i = 0; i < numbers.Length; i++)
                {
                    NewArray[i] = numbers[i];
                }
                for(int i=0; i < number.Length; i++)
                {
                    NewArray[numbers.Length + i] = number[i];
                }
                number = NewArray;
            }
            
        }

        
    }
}