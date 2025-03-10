class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Goodbye World");
        double[] arr = [1.0, 2.0, 4.0];
        Console.WriteLine("Avg value: " + sumValues(arr));
    }

    public static double sumValues(double[] arr)
    {
        double sum = 0.0;
        foreach (double numb in arr)
        {
            sum += numb;
        }
        
        return sum;
    }
}