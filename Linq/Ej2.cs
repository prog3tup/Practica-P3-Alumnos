
/*
 2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
Ejemplo: "computadora", "usb" → "COMPUTADORA"

 */
namespace PracticaLinq
{
    public class Ej2
    {
        public Ej2()
        {
            List<string> list = new List<string>();
            list.Add("computadora");
            list.Add("usb");

            var newList = list.Where(word => word.Length >= 5).Select(word => word.ToUpper()).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
