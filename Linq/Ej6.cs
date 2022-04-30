namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {
            List<string> palabras = new List<string>()
            {
                "dia",
                "hola",
                "barberia",
                "diametro",
                "casual",
                "santiago"
            };

            foreach (var item in ReemplazarIa(palabras))
            {
                Console.WriteLine(item);
            }
        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(palabra => palabra.Replace("ia", "*")).ToList();
    
        }
    }
}
