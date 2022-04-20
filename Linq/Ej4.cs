namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] ListInterger = new int[] { 78, -9, 0, 23, 54, 21, 7, 86 };

            List<int> ListResult = PrimerosDescendiente(ListInterger);

            foreach (var item in ListResult)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(item => item).Take(5).ToList();
        }
    }
}
