using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cuadrado
{
    class Program
    {   
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("Ingresa el valor del lado de tu cuadrado");
            System.Console.WriteLine("----------------------------------------------");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            

            calcArea result1 = new calcArea();
            int ResultArea = result1.mult(lado1,2);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("El area del cuadrado es: {0}", ResultArea);
            Console.WriteLine("----------------------------------------------");

            calcPerimetro result2 = new calcPerimetro();
            int ResultPeri = result2.mult(lado1, 4);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("El perimetro del cuadrado es: {0}", ResultPeri);
            Console.WriteLine("----------------------------------------------");
        }

        class calcArea
        {
            private int lado, area;
            

            public int mult(int xLado1, int xArea1)
            {
                lado = xLado1;
                area = xArea1;

                
   
                return lado * area;
                
            }
        }

        class calcPerimetro
        {
            private int lado, Perimetro;


            public int mult(int xLado1, int xPerimetro1)
            {
                lado = xLado1;
                Perimetro = xPerimetro1;



                return lado * Perimetro;

            }
        }




    }
    
}
