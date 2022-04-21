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
            List <int> numeros = new List<int> { 7, 2, 30 };

            var toString = numeros.Where(x => Math.Pow(x, 2) > 20).Select(x => x.ToString() + " - " + Math.Pow(x, 2).ToString()).ToList();

            foreach (var item in toString)
            {
                Console.WriteLine(item);
            }
        
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            return numeros.Where(x => Math.Pow(x, 2) > 20).Select(x => x.ToString() + " - " + Math.Pow(x, 2).ToString()).ToList(); ;
        }
    }
}
