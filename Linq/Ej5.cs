/*
Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”
*/

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

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List<int> listInt = numeros.ToList().Where(x => (x * x) > 20).ToList();
            return listInt.Select(x => x.ToString() + " - " + (x * x).ToString()).ToList();
        }
    }
}
