/*
Implementar la función 
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


            lista.ToList().ForEach(Console.WriteLine);
        }    
        
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            return cadena.Split(' ').Where(anItem => anItem.ToUpper() == anItem).ToList();
        }
    }
}