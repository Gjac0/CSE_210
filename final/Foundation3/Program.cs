using System;
namespace Foundation03;
class Program
{

    public static void Main(string[] args)
    {
        Event lecture = new Lecture("AI and the Future", "Explore the potential of Artificial Intelligence", "2024-05-10", "18:00:00", new Address("1 Main St", "New York", "NY", "10001"), "Dr. Jane Smith", 100);
        Event reception = new Reception("Company Holiday Party", "Celebrate the year with colleagues!", "2023-12-15", "19:00:00", new Address("123 Elm St", "Chicago", "IL", "60601"), "events@company.com");
        Event gathering = new Outdoor("Community Picnic", "Bring a dish to share and enjoy the outdoors!", "2024-07-04", "12:00:00", new Address("Central Park", "New York", "NY", "N/A"), "Sunny with a high of 78 degrees Fahrenheit");

        Console.Write("Standard Details:");
        lecture.StandardDetails();
        reception.StandardDetails();
        gathering.StandardDetails();
        
        Console.Write("\nFull Details:");
        lecture.FullDetails();
        reception.FullDetails();
        gathering.FullDetails();

        Console.Write("\nShort Description:");
        lecture.ShortDescription();
        reception.ShortDescription();
        gathering.ShortDescription();
    }
}