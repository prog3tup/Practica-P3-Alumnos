/*
7) Implementar la función 

public static IList<string> DevolverPalabrasCapitales(string cadena)

que devuelva sólo las palabras en mayúsculas de la cadena.
Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO
*/


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
        
        public static List<string> DevolverPalabrasCapitales(string cadena)
        {
            List<string> lista = cadena.Split(" ").ToList();
            lista = lista.Where(item => item.ToUpper() == item).ToList();
            return lista;

        }
    }
}
