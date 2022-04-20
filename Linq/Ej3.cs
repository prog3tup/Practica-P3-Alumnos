namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
            List<string> list = new List<string>();
            list.Add("ventilador");
            list.Add("reloj");
            list.Add("buscador");
            var result = list.Where(w => w.StartsWith("b") && w[w.Length - 1].Equals('r')).ToList();
            foreach (var words in result)
            {
                Console.WriteLine(words);
            }
        }

        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(w => w.StartsWith("b") && w[w.Length - 1].Equals('r')).ToList();
            //throw new NotImplementedException();;
        }
    }
}
