namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> string_list = new List<string>();
            string_list.Add("estudiar");
            string_list.Add("caminar");
            string_list.Add("dia");
            string_list.Add("señora");

            var final_string = string_list.Select(n => n.Replace("ia", "*")).ToList();

            foreach (var x in final_string)
            {
                Console.WriteLine(x);

            }
        public static IList<string> ReemplazarIa(List<string> strings)
        {
            throw new NotImplementedException();
            return strings.Select(x => x.Replace('ia', '*')).ToList();
            }
    }
}