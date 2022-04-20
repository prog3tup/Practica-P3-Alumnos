namespace PracticaLinq
{
    internal class Ej2
    {
        public Ej2()
        {
            List<string> palabras = new()
            {
                "computadora",
                "usb"
            };
            List<string> consulta = palabras.Where(palabra => palabra.Length >= 5).ToList();

            foreach (var palabra in consulta)
            {
                Console.WriteLine(palabra.ToUpper());
            }
        }
    }
}