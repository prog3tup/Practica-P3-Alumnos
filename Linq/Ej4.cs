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
            var primeros5 = new List<int>();

            for (int i = 0; i < 5; i++) {
                primeros5.Add(numeros[i]);
            }
            return primeros5;
        }
    }
}
