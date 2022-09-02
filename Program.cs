using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jednostkę i wartość");
            Console.WriteLine("jednostka:");
            string  unit = Console.ReadLine();
            Console.WriteLine("wartość:");
            double value = Convert.ToSingle(Console.ReadLine());
            var result =  KM_M(unit,value);
            if(unit.Equals("KM",StringComparison.InvariantCultureIgnoreCase) || unit.Equals("M",StringComparison.InvariantCultureIgnoreCase))
            {
              result = KM_M(unit,value);
            }
            else if(unit.Equals("MIN",StringComparison.InvariantCultureIgnoreCase)|| unit.Equals("H",StringComparison.InvariantCultureIgnoreCase))
            {
              result = MIN_H(unit,value);  
            }
            else if(unit.Equals("FT",StringComparison.InvariantCultureIgnoreCase) || unit.Equals("M",StringComparison.InvariantCultureIgnoreCase))
            {
              result =  FT_M(unit,value);
            }
            Console.WriteLine("jest to: "+result);
        }
        static double KM_M(string unit , double value)
        {
         if(unit == "km")
         {
          value = value * 1000;
         }
         else
         {
          value =  value / 1000;
         }
          return  value;
        }
        static double MIN_H(string unit, double value)
        {
          if(unit == "min")
          {
            value = value / 60;
          }
          else
          {
           value = value * 60 ;
          }
          return  value;
        }
        static double FT_M(string unit, double value)
        {
          if(unit == "FT")
          {
           value = value * 0.3048;
          }
          else
          {
            value = value * 3.28084;
          }
          return value;
        }
    }
}
