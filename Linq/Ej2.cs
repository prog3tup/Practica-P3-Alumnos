﻿
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

            var listEj = new List<string>() { "usb", "computadora", "mouse", "mic", "teclado" };

            var filterList = listEj.Where(word => word.Length >= 5);

            foreach (var item in filterList)
            {
                Console.WriteLine(item.ToUpper());
            }

        }
    }
}