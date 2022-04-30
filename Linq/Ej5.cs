namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] numeros = { 1, 3, 5, 32, 2, 12, 90, 4, 54 };

            foreach (var item in CalcularCuadrados(numeros))
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List<int> CuadradosMaYores20 = numeros.Where(num => Math.Pow(num, 2) >= 20).ToList();
            return CuadradosMaYores20.Select(num => num.ToString() + " - "+ Math.Pow(num, 2)).ToList();

        }
    }
}
