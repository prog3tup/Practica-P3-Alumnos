namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            List<int> numerosDescendentes = numeros.OrderByDescending(n => n).ToList();
            List<int> primerosCinco = new();
            for (int i = 0; i < 4; i++)
            {
                primerosCinco.Add(numerosDescendentes[i]);
            }

            return  primerosCinco;
        }
    }
}
