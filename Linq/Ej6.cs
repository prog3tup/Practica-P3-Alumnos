/*
 6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"
*/

namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> palabras = new List<string> { "estudiar", "caminar", "dia" };

            var palabrasModificadas = palabras.Select(x => x.Replace("ia", "*")).ToList();

            foreach (var item in palabrasModificadas)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(x => x.Replace("ia", "*")).ToList();
        }
    }
}
