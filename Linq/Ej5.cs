namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int [] array = new int[] { 7, 2, 30 };

            var resultado = CalcularCuadrados(array);

            resultado.ToList().ForEach(Console.WriteLine);
        }

        public static List<string> CalcularCuadrados(int[] numbers)
        {
            List<int> listInt = numbers.Where(num => (num * num) > 20).ToList();

            return listInt.Select(num => num.ToString() + " - " + (num * num).ToString()).ToList();
        }
    }
}
