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

            var result = BuscarPalabrasPorLetras(list);

            result.ForEach(Console.WriteLine);
            
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> words)
        {
            return words.Where(word => word.StartsWith('b')  && word.EndsWith('r')).ToList();
        }
    }
}
