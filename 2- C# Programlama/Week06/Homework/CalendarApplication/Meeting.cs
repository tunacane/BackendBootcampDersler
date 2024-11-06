using System;

namespace CalendarApplication;

public class Meeting : Event
{
    public Meeting(string name, DateTime date, string location) : base(name, date, location)
    {
    }

    public override void DefineEvent()
    {
        base.DefineEvent();
    }

    public void MeetingDate(){
        DateTime meetindDay = DateTime.Now;
        System.Console.WriteLine(meetindDay +" tarihi için toplantı ayarlandı.");
    }
}
