/*Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
*/
namespace PracticaLinq
{
    public class Ej4
    {

        public Ej4()
        {
            List<int> numList = new List<int>();
            numList.Add(78);
            numList.Add(-9);
            numList.Add(0);
            numList.Add(23);
            numList.Add(54);
            numList.Add(21);
            numList.Add(7);
            numList.Add(86);
            
            var numList2 = numList.OrderByDescending(x => x).Take(5).ToList();

          foreach (int num in numList2)
            {
                Console.WriteLine(num);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            
            throw new NotImplementedException();
            return numeros.OrderByDescending(x => x).Take(5).ToList();
        }
    }
}
