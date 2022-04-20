namespace PracticaLinq
{
    public class Ej2
    {
        public Ej2()
        {
            List<string> list = new List<string>();
            list.Add("computadora");
            list.Add("usb");
            var listaNueva = list.Where(palabra => palabra.Length >= 5);
            foreach (var palabra in listaNueva)
            {
                Console.WriteLine(palabra.ToUpper());
            }
        }
    }
}
