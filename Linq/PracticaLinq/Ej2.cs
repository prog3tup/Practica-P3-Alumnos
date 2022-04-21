namespace PracticaLinq
{
    public class Ej2
    {
        public Ej2()
        {
            List<string> devices_list = new List<string>();
            devices_list.Add("computadora");
            devices_list.Add("usb");

            var final_list = devices_list.Where(device => device.Length >= 5).Select(device => device.ToUpper()).ToList();

            foreach (var i in final_list)
            {
                Console.WriteLine(item);
            }
        }
    }
}