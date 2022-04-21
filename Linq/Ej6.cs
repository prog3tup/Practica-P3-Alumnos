namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            List<string> reemplazos = new();

            for (int i = 0; i < palabras.Count; i++)
            {
                reemplazos.Add(palabras[i].Replace("ia", "*"));
            }
            return reemplazos;
        }
    }
}
