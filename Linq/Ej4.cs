namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] array = new int[]{78, -9, 0, 23, 54, 21, 7, 86};

            List<int> result = PrimerosDescendiente(array);

            result.ToList().ForEach(Console.WriteLine);
        }
        public static List<int> PrimerosDescendiente(int[] numbers)
        {
            return numbers.OrderByDescending(num => num).Take(5).ToList();
        }
    }
}
