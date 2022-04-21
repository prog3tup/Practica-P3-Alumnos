namespace PracticaLinq
{
    class Ej1
    {
        public Ej1()
        {
            List<int> enteros = new List<int>();
            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);

            var numeros = enteros.Select(x => x + 100);

            foreach (var entero in numeros)
            {
                Console.WriteLine(entero);
            }

        }
    }

}

