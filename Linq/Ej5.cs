namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {

        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            numeros = numeros.Where(numero => Math.Pow(numero, 2) > 20).ToArray();
            return numeros.Select(numero => $"{numero} - {Math.Pow(numero, 2)}").ToList();
        }
    }
}
