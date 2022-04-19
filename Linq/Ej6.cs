namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(palabra => palabra.Replace("ia", "*")).ToList();
        }
    }
}
