using System;
namespace Learning04;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        assignment.GetSummary();

        MathAssignment mathAssignment = new("Roberto Rodriguez","Fractions","7.3", "8-19");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();

        WritingAssignment writingAssignment = new("Mary Waters","European History","The Causes of World War II by Mary Waters");
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();
    }
}