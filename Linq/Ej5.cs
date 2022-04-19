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

            numList.Add(2);
            numList.Add(0);
            numList.Add(3);
            numList.Add(21);
            numList.Add(7);
            numList.Add(5);

            var newList = Math.Pow(numList, 2).toList();
            
            foreach (var num in newList)
            {
                if( num >= 20){
                Console.WriteLine(numList[num] + newList[num]);
                }
            }
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            throw new NotImplementedException();
        }
    }
}
