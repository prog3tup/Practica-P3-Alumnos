namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> list = new List<string>();
            list.Add("estudiar");
            list.Add("caminar");
            list.Add("dia");

            var result = ReemplazarIa(list);

            result.ToList().ForEach(Console.WriteLine);
        }
        public static IList<string> ReemplazarIa(List<string> words)
        {
            return words.Select(word => word.Replace("ia", "*")).ToList();
        }
    }
}