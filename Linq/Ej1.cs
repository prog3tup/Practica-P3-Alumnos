/*
1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
Ejemplo: [67, 92, 153, 15] → 67, 92
*/

namespace PracticaLinq
{
    public class Ej1
    {
       public Ej1()
        {
            List<int> enteros = new List<int>();
            enteros.AddRange(new int[] { 67, 92, 153, 15 });

            var resultados = enteros.Where(item => item > 30 && item < 100).ToList();    

            foreach (var entero in resultados)
            {
                Console.WriteLine(entero);
            }
        }
    }
}
