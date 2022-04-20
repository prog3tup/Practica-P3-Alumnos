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


        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            palabras = palabras.Where(el => el.StartsWith('b')).ToList();
            palabras = palabras.Where(el => el.EndsWith('r')).ToList();
            return palabras;
        }
    }
}
