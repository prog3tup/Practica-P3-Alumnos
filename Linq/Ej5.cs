/*
5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”
*/


namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] list = new int[] { 7, 2, 30 };
            List<string> listaCuadrados = CalcularCuadrados(list);
            
            foreach (var item in listaCuadrados)
            {
                Console.WriteLine(item);
            }

        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            numeros = numeros.Where(item => Math.Pow(item, 2) > 20).ToArray();
            return numeros.Select(item => $"{item} - {Math.Pow(item, 2)}").ToList();
        }
    }
}
