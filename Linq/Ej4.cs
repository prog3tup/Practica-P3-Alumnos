// 4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
// Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21


namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] {78, -9, 0, 23, 54, 21, 7, 86});
            list = list.OrderByDescending(x => x).ToList();
            list = list.Take(5).ToList();

            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(x => x).Take(5).ToList();
        }
    }
}
