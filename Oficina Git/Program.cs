using System; 
class progran
{
    static void Main(string[] args)
    {

        Console.WriteLine("\ndigite um numero:");
        double num = Convert.ToDouble(Console.ReadLine()); ;
        Console.WriteLine("digite outro numero:");
         double num2= Convert.ToDouble(Console.ReadLine());

        double resultado = num * num2;
        Console.WriteLine("\nresultado da sua multiplicação é"+ resultado);
        if (resultado == 0) { Console.WriteLine("numero invalidoo"); }
        if (resultado == 1) { Console.WriteLine("numero invalidoo"); }
        if (resultado == 2) { Console.WriteLine("numero invalidoo"); }




        Console.ReadKey();
    }



}