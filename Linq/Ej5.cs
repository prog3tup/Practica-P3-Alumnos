//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
//Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”


namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            var numeros = new[] { 6, 7, 8, 9 };

            var lista = CalcularCuadrados(numeros);

            var cuadrado = from int n in numeros
                         let cuadrado_num = n * n
                           where cuadrado_num > 20
                           select new { n, cuadrado_num};

            foreach (var a in cuadrado)
                Console.WriteLine(a);
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            throw new NotImplementedException();
            return numeros.Select(x => x.ToString()).ToList();
        }
    }
}

