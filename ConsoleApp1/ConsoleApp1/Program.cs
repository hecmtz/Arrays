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

                if (numeros[i] < compar)
                {
                    compar = numeros[i];
                }
                
            }
            Console.WriteLine("  el numero menor es : "+ compar);

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


            /*int sum = 0 , i=0;
            int[] numeros = new int[10];

            for ( ; numeros.Length>i; i++)
            {
                Console.WriteLine("Introduce el numero " + (i+1) + " :");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + numeros[i];
                
            }

            Console.WriteLine("La media de la suma de los " + i +"  numeros es : "+sum/i);
            Console.ReadLine();
            */

            /*
             * 
             * 
             * /*
 * Crear un array de 11 ints. Usar un for para asignar 0 a cada posición.
 * Pedir al usuario que introduzca valores entre 0 y 10. Cada vez que introduzca 
 * un dígito, añadir uno al valor en esa posición del array. Si por ejemplo introduce un 3,
 * sumar uno a la posición 3. Mostrar en pantalla los valores.
 * Si introduce un número mayor que 10, decir que ese número es incorrecto.
 * Si introduce un número negativo, mostrar en pantalla el número de cada posición y
 * el valor que contiene. Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
        0	0
        1	0
        2	0
        3	0
        4	0
        5	2
        6	1
        7	3
        8	0
        9	2
        10	1
*/

            /*
            int nN;
            int[] numeros = new int[11];

            for (int i= 0; numeros.Length > i; i++)
            {
                numeros[i] = 0;

                //Console.WriteLine("el Array " + (i + 1) + "es : "+ numeros[i]);
            }
            do
            {
                Console.WriteLine("Introduce un numero");
                nN = Convert.ToInt32(Console.ReadLine());
                if (nN >= 0 && nN<=10)
                {
                    numeros[nN]++;
                }
                else if(nN > 10){
                    Console.WriteLine("Numero equivocado");
                }
               
            } while (nN >= 0); // si es menor a 0 sale del programa

            //mostrar numeros
            for (int i = 0; numeros.Length > i; i++)
            {
               Console.WriteLine(i+" : " + numeros[i]);

                //Console.WriteLine("el Array " + (i + 1) + "es : "+ numeros[i]);
            }

            Console.ReadLine();

            */

            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. 
            //Pedir al usuario que introduzca un número entre 0 y 9. 
            //Cada vez que introduzca un valor entre 0 y 9, mostrar el valor 
            //de esa posición del array, y modificarlo multiplicando por 2.

            /*
            int nN, pos;
            int[] numeros = new int[10];

            for (int i = 0; numeros.Length > i; i++)
            {
                numeros[i] = 1;

                //Console.WriteLine("              Array " + (i + 1) + "es : "+ numeros[i]);
            }

            do
            {
                Console.WriteLine("Introduce un numero entre 0 y 9");
                pos = Convert.ToInt32(Console.ReadLine());
                nN = pos;
                if (nN <10 && nN >= 0)
                {
                    numeros[nN] = numeros[pos] * 2;
                    //Muestra los numeros
                }
                  
                Console.WriteLine(pos);
                Console.Clear();
            } while (pos > 0 && pos < 10);
            Console.WriteLine("           Array              |         Multiplicacion");
            for (int i = 0; numeros.Length > i; i++)
            {
                Console.WriteLine("\n            "+i + " :                  " + numeros[i]);
               
            }
            Console.ReadLine();
            */


            //Programa que lee las edades de 20 alumnos (validado entre 18 y 35),
            //las almacena en un array y calcula y escribe su media
            //(para probar, se pueden generar aleatoriamente entre 18 y 35). 

            /*
            int[] edades = new int[20];
            int sum=0 , nump=0;

            for ( int i =0; edades.Length> i; i++)
            {
                Console.WriteLine("Ingresa tu edad");
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades [i]>18 && edades[i] < 35)
                {
                    sum = sum + edades[i];
                    nump++;
                    //Console.WriteLine("Edad de array " + i + "edad :  " + edades[i]);
                }
                
            }
            for (int i = 0; edades.Length > i; i++)
            {
                Console.WriteLine("Edad de array " + (i+1) + " es :  " + edades[i]);
            }
            Console.WriteLine("La media es "+ (sum/nump));
            Console.ReadLine();
            */

            //

            //Cargar una tabla de 20 componentes enteros y calcular la suma 
            //de los componentes de posición par y  el producto de los componentes
            // de posición impar. Los valores se generarán aleatoriamente entre 1 y 100.




        }



    }

        }
    

