namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] ListInterger = new int[] { 7, 2, 30 };

            List<string> ListResult = CalcularCuadrados(ListInterger);

            foreach (var item in ListResult)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            numeros.Where(item => Math.Pow(item, 2) > 20).ToArray();
            return numeros.Select(item => $"{item} - {Math.Pow(item, 2)}").ToList();
        }
    }
}