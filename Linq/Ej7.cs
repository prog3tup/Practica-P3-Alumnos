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
            bool result = true;
            foreach (var pal in listaCadena)
            {
                for (int i = 0; i < pal.Length; i++)
                {
                    result = Char.IsUpper(pal,i);
                    if (result is false)
                        break;
                }
                if (result) 
                    listaMayuscula.Add(pal);
            }
            return listaMayuscula;
        }
    }
}
