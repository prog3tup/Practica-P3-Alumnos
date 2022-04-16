
//2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
//Ejemplo: "computadora", "usb" → "COMPUTADORA"


namespace PracticaLinq
{
    public class Ej2
    {
        public Ej2()
        {
            List<string> lista = new List<string>();
            lista.Add("computadora");
            lista.Add("usb");

            List<string> lista2 = lista.Where(palabra => palabra.Length > 5).Select(palabra => palabra.ToUpper()).ToList();
            
            foreach(string str in lista2)
            {
                Console.WriteLine(str);
            }
        }
    }
}
