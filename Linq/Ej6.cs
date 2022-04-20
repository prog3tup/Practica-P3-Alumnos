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

            var NewList = ReemplazarIa(list);


            foreach (var item in NewList)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(item => item.Replace("ia", "*")).ToList();
        }
    }
}
