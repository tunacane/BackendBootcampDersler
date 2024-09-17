namespace Project22_Inheritance;

class Bird
{
    public void Fly(){
        System.Console.WriteLine("Kuş uçuyor!");
    }
}

class Penguin : Bird
{
    public void Swim(){
        System.Console.WriteLine("Penguen yüzüyor");
    }
    
}


class Otomobil
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int ModelYili { get; set; }
}

class IctenYanmaliOtomobil : Otomobil
{
    public string YakitTipi { get; set; }
    public string MotorGücü { get; set; }
}

class ElektikliOtomobil : Otomobil
{
    public string Menzil { get; set; }
    public bool KendiniSarjEtme { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        ElektikliOtomobil elektikliOtomobil1 = new ElektikliOtomobil();
        elektikliOtomobil1.KendiniSarjEtme=true;






    //    Penguin penguin1 = new Penguin();
    //    penguin1.Swim();
    //    penguin1.Fly();
    }
}
