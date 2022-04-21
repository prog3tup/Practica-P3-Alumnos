namespace PracticaLinq
{
    internal class Ej2
    {
        public Ej2()
        {
            List<string> list = new List<string>();
            list.Add("computadora");
            list.Add("usb");

            var ListaNueva = list.Where(palabra => palabra.Length >= 5).Select(palabra => palabra.ToUpper()).ToList();


            foreach (var item in ListaNueva)
            {
                Console.Write(item);
            }
        }

    }
}
