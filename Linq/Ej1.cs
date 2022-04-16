﻿//Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
//Ejemplo: [67, 92, 153, 15] → 67, 92


namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1 ()
	    {
            List<int> enteros = new List<int> ();
            enteros.Add(67);
            enteros.Add(92);
            enteros.Add(153);
            enteros.Add(15);

            List<int> nuevaLista = enteros.Where(x => x > 30 && x < 100).ToList();

            foreach(int nro in nuevaLista)
            {
                Console.WriteLine(nro.ToString());
            }
	    }
    }
}