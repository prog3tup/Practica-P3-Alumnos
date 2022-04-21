namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
            List<string> palabras = new List<string>();
            palabras.Add("ventilador");
            palabras.Add("buscador");
            palabras.Add("reloj");
            
            var palabras_letras = BuscarPalabrasPorLetras(palabras);

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(item => item.EndsWith("r") & item.StartsWith("b")).ToList();
        }
    }
}
