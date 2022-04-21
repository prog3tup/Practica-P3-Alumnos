namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
       List<string> list = new List<string>();
           
            list.Add("ventilador");
            list.Add("reloj");
            list.Add("buscador");
           

            var palabras = list.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();

            foreach (var n in palabras)
            {
                Console.WriteLine(n);
            }

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        }
    }
}
