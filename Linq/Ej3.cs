namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(palabra => palabra.StartsWith("b") && palabra.EndsWith("r")).ToList();
        }
    }
}
