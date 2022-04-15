namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

            var palabras = new List<string>() { "usb", "computadora", "mouse", "mic", "teclado", "buscador", "balcon" };

            var specificList = BuscarPalabrasPorLetras(palabras);


            foreach (var item in specificList)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(words => words.StartsWith("b") && words.EndsWith("r")).ToList();
        }
    }
}
