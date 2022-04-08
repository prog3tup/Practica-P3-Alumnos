/*
Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
*/

namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] array = new int[] { 78, -9, 0, 23, 54, 21, 7, 86 };
            List<int> result = PrimerosDescendiente(array);
            result.ForEach(Console.WriteLine);
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(x => x).Take(5).ToList();
        }
    }
}