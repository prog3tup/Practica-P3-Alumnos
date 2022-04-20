namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1()
        {
            List<int> enteros = new();
            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);
            var consulta = enteros.Where(a => a > 30 && a < 100).ToList();
            foreach (var entero in consulta)
            {
                Console.WriteLine(entero.ToString());
            }
        }
    }
}
