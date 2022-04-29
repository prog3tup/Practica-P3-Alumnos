//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato:
//"número - cuadrado" sólo si el cuadrado es mayor que 20. Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”


namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(2);
            list.Add(30);

            var cuadrados = list.Where(x => x * x > 20).Select(x => $" {x} - {x * x}").ToList();

            foreach (var i in cuadrados)
            {
                //Console.WriteLine(i);
            }


        }


        public static List<string> CalcularCuadrados(int[] numeros)
        {
            return numeros.Where(x => x * x > 20).Select(x => $" {x} - {x * x}").ToList();
        }
    }
}