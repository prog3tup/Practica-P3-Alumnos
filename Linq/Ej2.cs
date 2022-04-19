namespace PracticaLinq
{
    internal class Ej2
    {
        public Ej2()
        {
            
        }
        public static List<string> PalabrasGrandesEnMayuscula (List<string> palabras)
        {
            palabras = palabras.Where(palabra => palabra.Length >= 5).ToList();
            palabras.ForEach(palabra => palabra.ToUpper());
            return palabras;
        }
    }
}
