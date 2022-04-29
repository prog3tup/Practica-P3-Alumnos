namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            int[] listaEnteros = { 78, -9, 0, 23, 54, 21, 7, 84 };

            var primeros5Ordenados = PrimerosDescendiente(listaEnteros);
            
            foreach (int i in primeros5Ordenados)

            Console.WriteLine(i);

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            Array.Sort(numeros);
            Array.Reverse(numeros);
            List<int>? primeros5 = numeros.Take(5).ToList();
            return primeros5;
        }
    }
}
