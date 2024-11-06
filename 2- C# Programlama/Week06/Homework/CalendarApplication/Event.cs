using System;

namespace CalendarApplication;

public class Event
{
    public Event(string name, DateTime date, string location)
    {
        Name = name;
        this.date = date;
        Location = location;
    }

    public string Name { get; set; }
    public DateTime date { get; set; }
    public string Location { get; set; }

    public virtual void DefineEvent(){
        System.Console.WriteLine($"Name: {Name}\n Date: {DateTime.Now}\n Location: {Location}");
    }
}
