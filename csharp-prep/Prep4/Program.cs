using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args){
        List<int> numbers = new List<int>();
        int entry;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            entry = int.Parse(Console.ReadLine());
            numbers.Add(entry);

        } while (entry != 0);
        int sum = numbers.Sum();
        double average = Queryable.Average(numbers.AsQueryable());
        
        Console.Write("The sum is: {0}/nThe average is: {1}/nThe largest number is:{2}",sum,average,largest);
    }
}