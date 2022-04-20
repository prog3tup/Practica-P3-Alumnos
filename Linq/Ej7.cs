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
            var uppercaseWord =  cadena.Split(' ')
						.Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal)).ToList();

			return uppercaseWord;
            //throw new NotImplementedException();
        }
    }
}
