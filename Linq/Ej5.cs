/*5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”
*/

namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            List<double> numList = new List<double>();

            numList.Add(7);
            numList.Add(0);
            numList.Add(3);
            numList.Add(21);
            numList.Add(7);

            var numList2 = numList.Where(x => Math.Pow(x, 2) >= 20).ToArray();
            var sarasa = numList2.Select($"{numList2} - {Math.Pow(numList2, 2)}".ToList());
           
            foreach (double jaja in sarasa)
            {

                Console.WriteLine(jaja);

            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            throw new NotImplementedException();
            numeros = numeros.Where(x => Math.Pow(x, 2) >= 20).ToArray();
            return numeros.Select($"{numeros} - { Math.Pow(numeros, 2)}".ToList());
        }
    }
}
