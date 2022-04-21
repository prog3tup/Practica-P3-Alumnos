namespace PracticaLinq
{
    public class Ej7
    {
        public Ej7()
        {
            var string = "Ejemplo";

            var list = DevolverPalabrasCapitales(string);

            foreach (var word in list)
            {
                Console.WriteLine(word);
            }       
        }    
        
        public static IList<string> DevolverPalabrasCapitales(string str)
        {
            throw new NotImplementedException();
            return str.Where(x => x.ToUpper == x).Tolist();
        }
    }
}