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
            List<int> enteros = new List<int>();
            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);

<<<<<<< HEAD
            var resultado = enteros.Where(x => x > 30 && x < 100).ToList();
=======
            var resultado = enteros.Select(x => x + 100).ToList();
>>>>>>> b4470cbe6d104f575a8d92bcf26a5facd6b32171

            foreach (var entero in resultado)
            {
                Console.WriteLine(entero);
            }
        }

    }
}
