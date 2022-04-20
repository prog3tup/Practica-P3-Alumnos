namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {

        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List<string> newList = new List<string>();
            foreach (int num in numeros)
            {
                if (Math.Pow(num, 2) > 20)
                {
                    newList.Add($"{num} - {Math.Pow(num, 2)}");
                }
            }
            return newList;
        }
    }
}