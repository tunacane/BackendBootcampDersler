using System;

namespace CalendarApplication;

public class Task : Event
{
    public Task(string name, DateTime date, string location) : base(name, date, location)
    {
    }

    public override void DefineEvent()
    {
        base.DefineEvent();
    }

    public void TaskComplete(){

        System.Console.WriteLine("Görev ile ilgili sonucu giriniz: ");
        string task= Console.ReadLine().ToLower();
       
        if (task == "1")
        {
            System.Console.WriteLine("Görev tamamlandı.");
        }
        else
        {
            System.Console.WriteLine("Görev henüz tamamlanmadı.");
        }
    }
}
