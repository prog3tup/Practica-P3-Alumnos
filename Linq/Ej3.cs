namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            List<string> palabrasPorLetras = new List<string>();
            foreach (var palabra in palabras)
            {
                char[] charArray = palabra.ToCharArray();
                if (charArray[0] == 'b' && charArray[palabra.Length -1] == 'r')
                {
                    palabrasPorLetras.Add(palabra);
                };
            }
            return palabrasPorLetras;
        }
    }
}
