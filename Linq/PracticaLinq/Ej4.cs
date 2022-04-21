namespace PracticaLinq
{
    public class Ej4
    {

        public Ej4()
        {
            List<int> int_list = new List<int>();
            int_list.Add(78);
            int_list.Add(-9);
            int_list.Add(0);
            int_list.Add(23);
            int_list.Add(54);
            int_list.Add(21);
            int_list.Add(7);
            int_list.Add(86);
            
            var fina_int_list = int_list.OrderByDescending(n => n).Take(5).ToList();

          foreach (int n in int_list)
            {
                Console.WriteLine(n);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numbers)
        {
            
            throw new NotImplementedException();
            return numbers.OrderByDescending(n => n).Take(5).ToList();
        }
    }
}
