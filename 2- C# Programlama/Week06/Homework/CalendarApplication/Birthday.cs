using System;

namespace CalendarApplication;

public class Birthday : Event
{
    public Birthday(string name, DateTime date, string location) : base(name, date, location)
    {
    }

    public override void DefineEvent()
    {
        base.DefineEvent();       
    }

    public void BirthdayTime(){
        DateTime managerBirthday = new DateTime(2024, 12, 12);
        System.Console.WriteLine($"Manager's birthday is settled for {managerBirthday}");
    }
}
