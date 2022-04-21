namespace PracticaLinq
{
    public class Ej4
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



            foreach (var n in asd)
            {
                Console.WriteLine(n);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.Take(5).OrderByDescending(x => x).ToList();

        }
    }
}
