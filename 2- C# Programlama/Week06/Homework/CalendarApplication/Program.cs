namespace CalendarApplication;

class Program
{
    static void Main(string[] args)
    {
        DateTime birtday = new DateTime(1996, 12,10);
        Birthday birthday1= new Birthday("Tunacan", birtday, "Mersin");
        birthday1.DefineEvent();
        birthday1.BirthdayTime();

        System.Console.WriteLine("********************************************");

        Meeting meeting1= new Meeting("Software Development", DateTime.Now, "Zoom" );
        meeting1.DefineEvent();
        meeting1.MeetingDate();

        System.Console.WriteLine("********************************************");

        DateTime task = new DateTime(2024, 10, 10);
        Task task1 = new Task("New Program for HR", task, "Google Meet");
        task1.DefineEvent();
        task1.TaskComplete();


    }
}
