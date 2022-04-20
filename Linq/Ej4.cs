/*
 4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

 */

namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> list = new List<int>();
            list.Add(78);
            list.Add(-9);
            list.Add(23);
            list.Add(54);
            list.Add(21);
            list.Add(7);
            list.Add(86);

            List<int>? listaNueva = list.Where(numero => numero > 0).ToList();

            List<int>? listaOrdenada = listaNueva.OrderByDescending(numero => numero).ToList();

            List<int> listaFinal = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                listaFinal.Add(listaOrdenada[i]);
            }
            
            foreach(int numero in listaFinal) { Console.WriteLine(numero); }
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            List<int>? listaOrdenada = numeros.OrderByDescending(numero => numero).ToList();
            List<int> listaFinal = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listaFinal.Add(listaOrdenada[i]);
            }
            return listaFinal;
        }
    }
}
