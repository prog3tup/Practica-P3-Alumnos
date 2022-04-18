namespace PracticaLinq
{
    internal class Ej2
    {
        public Ej2()
        {
            
        }
        public static List<string> PalabrasGrandesEnMayuscula (List<string> palabras)
        {
            List<string> palabrasGrandesEnMayuscula = new List<string>();
            foreach (string palabra in palabras)
            {
                if (palabra.Length >= 5)
                {
                    palabrasGrandesEnMayuscula.Add(palabra.ToUpper());
                }
            }
            return palabrasGrandesEnMayuscula;
        }
    }
}
