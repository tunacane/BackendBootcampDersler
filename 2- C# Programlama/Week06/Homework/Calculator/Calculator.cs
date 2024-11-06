using System;

namespace CalculatorDivide;

public class Calculator
{
  public void Topla(double a, double b)
  {
    double toplam = a+b;
  }

    public void Cikar(double a, double b)
    {
        double fark = a-b;
    }

    public void Carpma(double a, double b)
    {
        double carpim = a*b;
    }

    public void Bolme (double a, double b)
    {
       

        if (b==0)
        {
          System.Console.WriteLine("b 0 olamaz");
        }
    double bolum = a / b;
  }
}
