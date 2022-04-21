namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] list = new int[] { 78, -9, 0, 23, 54, 21, 7, 86 };
            List<int> nroEntero = PrimerosDescendiente(list);

            foreach (var n in nroEntero)
            {
                Console.WriteLine(n);
            }

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(x => x).ToList();
        }
    }
}
