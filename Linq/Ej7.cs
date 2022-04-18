namespace PracticaLinq
{
    public class Ej7
    {
        public Ej7()
        {
            var cadena = "ESTO es un EJEMPLO del EJERcicio";

            var lista = DevolverPalabrasCapitales(cadena);

            foreach (var pal in lista)
            {
                Console.WriteLine(pal);
            }       
        }

        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            IList<string> capitales = new List<string>();
            IList<string> palabras = cadena.Split(" ");
            foreach (string palabra in palabras)
            {
                if (!palabra.Any(c => char.IsLower(c)))
                {
                    capitales.Add(palabra);
                }
            }
            return capitales;
        }
    }
}
