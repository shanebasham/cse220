using System;
class Program
{
    static void Main(string[] args)
    {
        // Create events
        Lectures lectureEvent = new Lectures("Inspiring Talk", "Listen to a special motivational speaker!", new DateTime(2023, 12, 15, 18, 0, 0), "Conference Center", "Salt Lake City", "Utah", "Dr Dan Danielson", 150);
        Receptions receptionEvent = new Receptions("Holiday Party", "Join us for a festive celebration!", new DateTime(2023, 12, 22, 19, 0, 0), "Community Event Hall", "New York", "New York", "reception@gmail.com");
        OutdoorGatherings outdoorEvent = new OutdoorGatherings("Community Picnic", "Enjoy a day outdoors with friends and snacks!", new DateTime(2023, 12, 30, 12, 0, 0), "Lakeside Park", "Denver", "Colorado", "Sunny");
        // Display marketing messages for each event
        DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        DisplayEventDetails(outdoorEvent);
    }
    // Display all
    static void DisplayEventDetails(Event events)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(events.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(events.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(events.GetShortDescription());
        Console.WriteLine();
    }
}


// You have been hired by an event planning company. They help organize and market events throughout the world. They need you to write a program to track each of these events and produce the marketing material to distribute on social media. They typically handle a few main types of events:
// Lectures, which have a speaker and have a limited capacity.
// Receptions, which require people to RSVP, or register, beforehand.
// Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
// Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
// They would like the ability to generate three different messages:
// Standard details - Lists the title, description, date, time, and address.
// Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
// Short description - Lists the type of event, title, and the date.
// Program Specification
// Write a program that has a base Event class along with derived classes for each type of event. These classes should contain the necessary data and provide methods to return strings for each of the messages the company desires.
// Remember that any data or methods that are common among all types of events should be in the base class.
// Once you have the classes in place, write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
// In addition, your program must:
// Use inheritance to avoid duplicating shared attributes and methods.
// Use an address class for the addresses.
// Follow the principles of encapsulation, making sure each member variable is private.