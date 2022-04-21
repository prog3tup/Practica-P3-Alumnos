namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> list = new List<string>();
            list.Add("estudiar");
            list.Add("caminar");
            list.Add("dia");

            var listaNueva = list.Select(x => x.Replace("ia", "*")).ToList();

            foreach (var entero in listaNueva)
            {
                Console.WriteLine(entero);
            }
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            throw new NotImplementedException();
        }
    }
}

/*6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"*/

