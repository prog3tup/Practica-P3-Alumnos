namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> enteros = new List<int>();
            enteros.Add(78);
            enteros.Add(-9);
            enteros.Add(0);
            enteros.Add(23);
            enteros.Add(54);
            enteros.Add(21);
            enteros.Add(7);
            enteros.Add(86);

            var cinco = enteros.Take(5).ToList();
            var test = cinco.OrderByDescending(x => x).ToList();

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            throw new NotImplementedException();
        }
    }
}

/*4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21*/
