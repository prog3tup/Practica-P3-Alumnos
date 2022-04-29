namespace PracticaLinq
{
    public class Ej7
    {
        public Ej7()
        {
            var cadena = "ESTO es un EJEMPLO deL EJERcicio";

            var lista = DevolverPalabrasCapitales(cadena);

            foreach (var pal in lista)
            {
                Console.WriteLine(pal);
            }       
        }    
        
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            IList<string> listaCadena = cadena.Split(" ").ToList();
            IList<string> listaMayuscula = new List<string>();
            listaMayuscula = listaCadena.Where(cadena => cadena.ToUpper() == cadena).ToList();
            return listaMayuscula;
        }
    }
}
