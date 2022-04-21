namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            List<int> enteros = new List<int>();
            enteros.Add(7);
            enteros.Add(2);
            enteros.Add(30);

            var listaNueva = enteros.Select(x => x * x).Where(x => x > 20);

            foreach (var item in listaNueva)
            {
                Console.WriteLine(item);
            }

        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            throw new NotImplementedException();
        }
    }
}

/*5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900*/
