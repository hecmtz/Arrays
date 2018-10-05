using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crear un array de 3 ints. Usar un for para pedir al usuario que 
            //introduzca valores a cada una de las posiciones. Usar otro for para mostrarlos en pantalla.

            /*
            int[] numeros = new int[3];


            for (int i =0; i<3; i++)
            {
                Console.WriteLine(" Introduce el valor del array : ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(numeros[j]);
               
                
            }
            Console.ReadLine();



            */



            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca
            // valores a cada una de las posiciones.Mirar los valores del array una vez tenga los
            // 3 valores y mostrar en pantalla el más pequeño.

            /*
            int[] numeros = new int[3];
            int compar =0 ;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" Introduce el numero : ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] >compar)
                {
                    compar = numeros[i];
                }
                
            }
            Console.WriteLine("  el numero mayor es : "+ compar);

            Console.ReadLine();
            */


            //Poner los nombres de los meses en un array de 12. 
            //Cuando el usuario introduce un número del 1 al 12,
            //mostrar el nombre de ese mes en pantalla.

            //string [] meses = new string [12] ;
            /*
            int numMes = 0;
            string[] meses =
            {
                "enero",
                "febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            };

            /*for(int i =0; meses.Length>i; i++)
            {
                Console.WriteLine("Ingresa el mes que deseas mostrar");
                numMes=Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine("Ingresa el mes que deseas mostrar");
            numMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El mes :" + meses[numMes-1]);
            Console.ReadLine();
            */


            //Hacer la media de 10 valores utilizando un array. eje

            int[] numeros = new int[10];



        }
    }
}
