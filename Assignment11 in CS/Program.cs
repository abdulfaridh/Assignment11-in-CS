// See https://aka.ms/new-console-template for more information
class Assignment11
{
    static void Main(string[] args)
    {
        int max, secmax;
        max = 0;
        secmax = 0;
        Console.WriteLine("enter the number of elements in the array");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("enter the elements in the array");
        for (int i = 0;i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if(array[i] > max)
            {
                secmax = max;
                max = array[i];
            }
            else if (array[i] < max && array[i] > secmax)
            {
                secmax = array[i];
            }
        }
        Console.WriteLine($"second max is : {secmax}");
    }
}
