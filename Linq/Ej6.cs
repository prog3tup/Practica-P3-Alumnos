//6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada.
//Para simplificar escribir todo sin acento.Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"


namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {

            List<string> BuscarPalabrasIA  = new List<string>();

            BuscarPalabrasIA.Add("estudiar");
            BuscarPalabrasIA.Add("caminar");
            BuscarPalabrasIA.Add("dia");

            var palabrasIA = BuscarPalabrasIA.Select(x => x.Replace("ia", "*")).ToList();

            foreach (var i in palabrasIA)
            {
                Console.WriteLine(i);
            }



        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(x => x.Replace("ia", "*")).ToList();
        }
    }
}
