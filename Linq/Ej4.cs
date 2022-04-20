namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> numList = new List<int>();
            numList.Add(2);
            numList.Add(100);
            numList.Add(86);
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(x => x).Take(5).ToList();
        }
    }
}
