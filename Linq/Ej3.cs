namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
            List<string> list = new List<string>();
            list.Add("computadora");
            list.Add("usb");
            list.Add("bartender");
            list.Add("buscador");

            var listaNueva = BuscarPalabrasPorLetras(list);


            foreach (var item in listaNueva)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(item => item.StartsWith("b") && item.EndsWith("r")).ToList();
        }
    }
}
