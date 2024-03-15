// See https://aka.ms/new-console-template for more information
class ConsoleApp1
{
    public static void Main(string[] args)
    {
        int total = 0;
        int count =0;
        int[] arr = new[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
        
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
            count = i;
        }

        try
        {
            Console.WriteLine("avg = " + total/count);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(total/1);

        }
        
        
    }

    
}