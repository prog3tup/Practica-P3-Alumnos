namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] array = new int[] { 7, 2, 30 };
            List<string> result = CalcularCuadrados(array);
            result.ForEach(Console.WriteLine);
        }

        public static List<string> CalcularCuadrados(int[] numbers)
        {
            return numbers.Where(number => (number * number) > 20).Select(number => number.ToString() + " - " + (number * number).ToString()).ToList();
        }
    }
}