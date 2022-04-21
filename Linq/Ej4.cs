//4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
//Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> list = new List<int>();
            list.Add(78);
            list.Add(-9);
            list.Add(0);
            list.Add(23);
            list.Add(54);
            list.Add(21);
            list.Add(7);
            list.Add(86);

           
            var asd = list.Take(5).OrderByDescending(x => x).ToList();



            foreach (var i in asd)
            {
                //Console.WriteLine(i);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.Take(5).OrderByDescending(x => x).ToList();

        }
    }
}