namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jednostkę i wartość");
            Console.WriteLine("jednostka:");
            string unit = Console.ReadLine();
            Console.WriteLine("wartość:");
            float value = Convert.ToSingle(Console.ReadLine());
            if(unit == "km" || unit == "m")
            {
             KM_M(unit,value);
            }
            else if(unit == "min" || unit == "h")
            {
              MIN_H(unit , value);  
            }
            else if(unit == "ft" || unit == "m")
            {
              FT_M(unit , value);
            }
        }
        static void KM_M(string unit , float value)
        {
         if(unit == "km")
         {
          Console.WriteLine("Jest to " + value * 1000 +"m");
         }
         else
         {
          Console.WriteLine("Jest to " + value / 1000 + "km");
         }
        }
        static void MIN_H(string unit, float value)
        {
          if(unit == "min")
          {
            Console.WriteLine("Jest to "+value / 60 + "h");
          }
          else
          {
            Console.WriteLine("Jest to "+value * 60 + "min");
          }
        }
        static void FT_M(string unit, float value)
        {
          if(unit == "FT")
          {
            Console.WriteLine("Jest to "+ value * 0,3048 + "m");
          }
          else
          {
            Console.WriteLine("Jest to "+ value * 3,28084 + "ft");
          }
        }
    }
}
