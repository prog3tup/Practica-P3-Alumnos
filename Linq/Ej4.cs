//4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
//Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> nums = new List<int>();
            nums.Add(78);
            nums.Add(-9);
            nums.Add(0);
            nums.Add(23);
            nums.Add(54);
            nums.Add(21);
            nums.Add(7);
            nums.Add(86);

            var nums_sort = from i in nums

                            orderby i descending

                            select i;

            foreach (var i in nums_sort) // No se como hacer para que corte en 5, trate con un FOR pero no me andaba saliendo
            {

                Console.WriteLine(i);

            }

            static List<int> PrimerosDescendiente(int[] numeros) // No se donde declarar PrimerosDescendiente
            {
                throw new NotImplementedException();
                return numeros.OrderByDescending(item => item).ToList();
            }
        }
    }
}

