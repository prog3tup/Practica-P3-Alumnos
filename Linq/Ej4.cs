namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(x => x).Take(5).ToList();
        }
    }
}
