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
            var resultado = BuscarPalabrasPorLetras(list);
            resultado.ForEach(Console.WriteLine);
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(palabra => palabra[0] == 'b' && palabra[palabra.Length - 1] == 'r').ToList();
        }
    }
}
