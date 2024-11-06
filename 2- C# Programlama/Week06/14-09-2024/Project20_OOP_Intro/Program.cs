namespace Project20_OOP_Intro;

class FirstClass{
    // Buraya sınıfın özellik ve davranışları kodlanır.
    //Özellik:  Property
    //Davranış: Method

    public string message; // başına bir şey gelmezse default mprivate kabul edilir dışarda görünür yapmak için başına public yazılmalı
    public string age;
    
    public void DisplayMessage(){
        Console.WriteLine(message);
    }
}


class Program
{
    static void Main(string[] args)
    {
        FirstClass firsClass1 = new FirstClass();
        firsClass1.message= "selam";
      //  System.Console.WriteLine(firsClass1.message);
      firsClass1.DisplayMessage();
    }
}

