namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {

        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List <string> NumerosYCuadrados = new List <string>();
            foreach (int numero in numeros)
            {
                if (Math.Pow(numero, 2) > 20)
                {
                    NumerosYCuadrados.Add($"{numero} - {Math.Pow(numero, 2)}");
                }
            }
            return NumerosYCuadrados;
        }
    }
}
