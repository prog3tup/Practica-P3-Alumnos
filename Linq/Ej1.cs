namespace PracticaLinq
{
   public class Ej1
    {
        public Ej1 ()
	    {
            List<int> enteros = new()
            {
                67, 92, 153, 15
            };

            var consulta = enteros.Where(num => num > 30 && num < 100).ToList();

            foreach (var entero in consulta)
            { 
                 Console.WriteLine(entero);
            }
        }
        
    }
}
