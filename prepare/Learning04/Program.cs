using System;
namespace Learning04;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{assignment.GetSummary()}");

        MathAssignment mathAssignment = new("Roberto Rodriguez","Fractions","7.3", "8-19");
        Console.WriteLine($"{mathAssignment.GetSummary()}\n{mathAssignment.GetHomeworkList()}");

        WritingAssignment writingAssignment = new("Mary Waters","European History","The Causes of World War II by Mary Waters");
        Console.WriteLine($"{writingAssignment.GetSummary()}\n{writingAssignment.GetWritingInformation()}");
    }
}