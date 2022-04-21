namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] list = new int[] { 7, 2, 30 };
            List<string> listaCuadrados = CalcularCuadrados(list);

            foreach (var n in listaCuadrados)
            {
                Console.WriteLine(n);   
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            nros = nros.Where(n => Math.Pow(n, 2) > 20).ToArray();
            return nros.Select(n => $"{n} - {Math.Pow(n, 2)}").ToList();
        }
    }
}
