
// 5) Escriba una consulta que devuelva una lista de números y sus cuadrados
// en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
// Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”

namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            // List<int> list = new List<int>();
            // list.AddRange(new int[] { 7, 2, 30 });
            int[] list = new int[] { 7, 2, 30 };
            list = list.Where(el => Math.Pow( el, 2) > 20).ToArray();
            var listString = list.Select(i => CrearFormato(i));

            foreach (var el in listString)
            {
                Console.WriteLine(el);
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            numeros = numeros.Where(el => Math.Pow(el, 2) > 20).ToArray();
            var listString = numeros.Select(i => CrearFormato(i)).ToList();
            return listString;
        }

        public static string CrearFormato(int value)
        {
            double cuadrado = Math.Pow(value, 2);
            return $"{value} - {cuadrado}";

        }
    }
}
