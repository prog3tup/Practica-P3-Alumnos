namespace PracticaLinq
{
    public class Ej7
    {
        public Ej7()
        {
            var cadena = "ESTO es un EJEMPLO del EJERcicio";

            var lista = DevolverPalabrasCapitales(cadena);

            lista.ToList().ForEach(Console.WriteLine) ;
        }    
        
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            return cadena.Split(' ').ToList().Where(word => word.ToUpper() == word).ToList();
        }
    }
}
