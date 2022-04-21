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

            var newList = ReemplazarIa(list);
            foreach (var n in newList)
            {
                list.Add(n);
            }

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(n => n.Replace("ia", "*")).ToList();
        }
    }
}
