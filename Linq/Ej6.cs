namespace PracticaLinq
{
    /*Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. 
     * Para simplificar escribir todo sin acento.
    Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"
    */
    public class Ej6
    {
        public Ej6()
        {
            List<string> list = new List<string>();
            list.Add("estudiar");
            list.Add("caminar");
            list.Add("dia");
            list.Add("señora");

            var newCadena = list.Select(x => x.Replace("ia", "*")).ToList();

            foreach (var word in newCadena)
            {
                Console.WriteLine(word);

            }
        }
            public static IList<string> ReemplazarIa(List<string> palabras)
            {

                return palabras.Select(x => x.Replace("ia", "*")).ToList();
            }
        
    }
}
