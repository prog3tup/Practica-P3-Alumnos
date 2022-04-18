namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            IList<string> cadenasReemplazadas = new List<string>();
            foreach (string palabra in palabras)
            {
                cadenasReemplazadas.Add(palabra.Replace("ia", ""));
            }
            Console.WriteLine(cadenasReemplazadas.ToArray());
            return cadenasReemplazadas;
        }
    }
}
