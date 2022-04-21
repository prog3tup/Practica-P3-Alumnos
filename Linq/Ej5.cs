//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato:
//"número - cuadrado" sólo si el cuadrado es mayor que 20. Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”


namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {

            List<int> numerosEnteros = new List<int> {7, 2, 30};

            var numCuadrados = numerosEnteros.Where(x => x * x > 20 ).Select(x => $" {x} - {x * x}").ToList();

            foreach (var i in numCuadrados)
            {
                Console.WriteLine(i);
            }


        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            return numeros.Where(x => x * x > 20).Select(x => $" {x} - {x * x}").ToList();
        }
    }
}
