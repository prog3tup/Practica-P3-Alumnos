namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] numeros = { 1, 3, 5, 32, 2, 12, 90, 4, 54 };

            foreach (var item in PrimerosDescendiente(numeros))
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            List<int> numerosDescendentes = numeros.OrderByDescending(n => n).ToList();

            return numerosDescendentes.Where(x => x >= numerosDescendentes[4]).ToList();
        }
    }
}
