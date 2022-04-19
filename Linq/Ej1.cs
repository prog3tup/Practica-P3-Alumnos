/*
 Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
Ejemplo: [67, 92, 153, 15] → 67, 92

 */

namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1()
        {
            List<int> integers = new List<int>();
            integers.Add(67);
            integers.Add(92);
            integers.Add(153);
            integers.Add(15);

            var result = integers.Select(x => x <=100 && x > 30).ToList();

            foreach (var integer in result)
            {
                Console.WriteLine(integer);
            }
        }

    }
}
