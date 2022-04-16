
// 6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una
// lista de palabras dada. Para simplificar escribir todo sin acento.
// Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"



namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> list = new List<string>(){ "estudiar", "caminar", "dia" };
            list = list.Select(el => el.Replace("ia", "*")).ToList();
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(el => el.Replace("ia", "*")).ToList();
        }
    }
}
