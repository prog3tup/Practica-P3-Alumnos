namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> palabras = new() { "estudiar", "caminar", "dia" };
            IList<string> palabras2 = ReemplazarIa(palabras);
            foreach (string palabra in palabras2)
                Console.WriteLine(palabra);
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            IList<string> result = palabras.Select(word=>word.Replace("ia", "*")).ToList();
            return result;
        }
    }
}
