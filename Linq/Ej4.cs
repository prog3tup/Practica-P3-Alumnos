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
            List<int> list = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };

            List<int>? enteros = list.OrderByDescending(x => x).ToList();
            List<int>? primerosCinco = enteros.Where(x => x >= enteros[4]).ToList();

            foreach (var item in primerosCinco)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> PrimerosDescendiente(int[] enteros)
        {
            return enteros.Where(x => x >= enteros[4]).ToList();
        }
    }
}
