// See https://aka.ms/new-console-template for more information
class ConsoleApp1
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Average(new []{1,9,2,8,3,8,4,7,6,5}));
    }

    static double Average(int[] arr)
    {
        double total = 0;
        int count =0;
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
            count = i;
        }

        try
        {
            return total/count;
        }
        catch (ArithmeticException e)
        {
            return total / 1;
        }
    }

    
}