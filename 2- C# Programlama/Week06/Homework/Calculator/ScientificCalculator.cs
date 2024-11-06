using System;
using System.ComponentModel.Design;

namespace CalculatorDivide;

public class ScientificCalculator : Calculator
{
  public double Sin(double derece){
   // double radian = derece * (Math.PI /180);
    return Math.Sin(derece);
  }


 public double Cos(double derece)
    {
       // double radian = derece * (Math.PI / 180);
        return Math.Cos(derece);
    }

  }