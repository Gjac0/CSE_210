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
        int largest = numbers.Max();
        
        Console.Write($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {largest}");
    }
}