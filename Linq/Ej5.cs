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
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(2);
            list.Add(30);
            List<int> listNumerosValidos = list.Where(num => num*num > 20).ToList();
            List<string> listaFinal = new List<string>();

            foreach (int num in listNumerosValidos)
            {
                listaFinal.Add($"{num} - {num * num}");
            }

            foreach (string par in listaFinal)
            {
                Console.WriteLine(par);
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List<int> listNumerosValidos = numeros.Where(num => num * num > 20).ToList();
            List<string> listaFinal = new List<string>();

            foreach (int num in listNumerosValidos)
            {
                listaFinal.Add($"{num} - {num * num}");
            }

            return listaFinal;
        }
    }
}
