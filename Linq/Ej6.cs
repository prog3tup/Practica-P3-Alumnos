namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6() { 
        List<string> list = new List<string>();
            list.Add("estudiar");
            list.Add("caminar");
            list.Add("dia");
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Replace("ia", "*");
            }
            
            foreach (var palabra in list)
            {
                Console.WriteLine(list);
            }
        }

        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            for (int i = 0; i < palabras.Count; i++)
            {
                palabras[i] = palabras[i].Replace("ia", "*");
            }
            return palabras;
            //throw new NotImplementedException();
        }
    }
}
