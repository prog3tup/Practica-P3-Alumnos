//6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
//Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"


namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> palabras = new List<string>();
            palabras.Add("estudiar");
            palabras.Add("caminar");
            palabras.Add("dia");

            var NuevasPalabras = ReemplazarIa(palabras);
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            palabras.Where(x => x.Replace('ia', '*')).ToList(); //Me tira error en 'ia'. Solo podia utilizar el replace dentro del public static
            throw new NotImplementedException();
            
        }
    }
}
