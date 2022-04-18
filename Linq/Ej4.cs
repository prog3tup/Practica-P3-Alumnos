namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {

        }
        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            List<int> biggestFiveDescendent = new List<int>();
            Array.Sort(numeros);
            Array.Reverse(numeros);
            for (int i = 0; i < 5; i++)
            {
                biggestFiveDescendent[i] = numeros[i];
            }
            return biggestFiveDescendent;
        }
    }
}
