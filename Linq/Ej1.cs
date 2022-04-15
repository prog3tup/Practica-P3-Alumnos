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

            var listEj = new List<int>() { 67, 92, 153, 15 };

            var filterList = listEj.Where(n => n > 30 && n < 100);

            foreach (var item in filterList)
            {
                Console.WriteLine(item);
            }

        }
}
}