namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            List <string> palabrasBR = palabras.Where(palabra => palabra.StartsWith("b") && palabra.EndsWith("r")).ToList();

            return palabrasBR;
        }
    }
}
