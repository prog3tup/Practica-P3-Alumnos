//4) Escriba una consulta que devuelva los 5 primeros números de la numerosEnterosa de enteros en
//orden descendente. Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {


            List<int> numerosEnteros = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };


            var ordenDescendente = numerosEnteros.Take(5).OrderByDescending(x => x).ToList();

            foreach (var i in ordenDescendente)
            {
                Console.WriteLine(i);
            }
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.Take(5).OrderByDescending(x => x).ToList();
        }
    }
}
