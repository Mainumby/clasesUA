using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace intCsharp
{
    class Program
    {
        static void Main(string[] args) // punto de entrada
        {
            int a = 1; //declaracion de variables de tipo entero
            
            string b = "hola"; // declaracion de variable de tipo cadena
            int c= 5; //asignacion de valor
            Console.Write(a + " " + b); //impresion en consola de las variables a y b
            Console.Write(a);
           
            Console.WriteLine(c);
            

            //declaracion de una array de 3 elementos
           string[] telefono = new string[3];
            //carga de array metodo uno
           telefono[0] = "0971";
           telefono[1] = "0982";
           telefono[2] = "0991";

           Console.WriteLine(telefono[2]);
          
           for (int i = 0; i < 3; i++)
           {
               Console.WriteLine(telefono[i]);
           }

            //sentencias condicionales

           if (a==2)
           {
               Console.WriteLine("Verdadero");
           }
            else
           {
               Console.WriteLine("False");
           }
        

            //condicion while
           int x = 0; //declaracion
           while (x<10) // mientras x sea menor a 10
           {
               x++;
               Console.WriteLine(x);
           }

           int d;
           int e;

           d = int.Parse(Console.ReadLine());
           e = int.Parse(Console.ReadLine());
           Console.WriteLine(d+"+"+e+"="+(d+e));


         
            

           Console.ReadKey(); //pido una tecla

        }
    }
}

   