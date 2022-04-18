namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1(){
            
        }
        public static List<int> MayorA30MenorA100 (List<int> numeros)
        {
            return numeros.Where(number => number > 30 && number < 100).ToList();
        }
    }
}
