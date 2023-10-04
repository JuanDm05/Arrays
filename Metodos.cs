using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Metodos
    {
        public void Arreglos()
        {
            int[] arregloNumerico = new int[5];
            for (int i = 0; i < arregloNumerico.Length; i++)
            {
                Console.WriteLine($"Ingresar numero  {i + 1}");
                arregloNumerico[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int muestra in arregloNumerico)
            {
                Console.WriteLine("Los numeros son"+muestra);
            }

        }

        public void Media(int tamaño)
        {
            int[]arreglo = new int[10] {2,2,2,2,2,2,2,2,2,2};
           
            int suma = 0;
            foreach (int valor in arreglo)
            {
                suma += valor;
            }
            double media = suma / arreglo.Length;
            foreach (int valor in arreglo)
            {
                Console.WriteLine(valor+"");
            }
            Console.WriteLine();
            Console.WriteLine("Media de los valores del arreglo "+ media);
        }
        public void Multiplos()
        {
            Console.WriteLine("Ingresa la longitud de tu arreglo");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] arreglob = new int[tamaño];
         
            Console.WriteLine("ingresa numero para la funcion del arreglo");
            int numeroMultiplo = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= tamaño; i++)
            {
                Console.WriteLine($" Los numero multiplo son: {numeroMultiplo * i}");
            }


        }
        public void Cadenas()
        {
            Console.WriteLine("Ingresa tamaño de los arreglos");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            string[] nombre = new string[tamaño];
            int[] longitud = new int[tamaño];
            for (int i = 0; i< tamaño;i++)
            {
                Console.WriteLine($"ingrese nombre {i +1}");
                nombre[i] = Console.ReadLine();
                longitud[i] = nombre[i].Length;

            }
          for (int i = 0; i< tamaño; i++)
            {
                Console.WriteLine($"EL nombre es : {nombre[i]} y su numero de palabras son {longitud[i]}");

            }
         

        }
    }
}
