<<<<<<< HEAD
﻿//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b"
//y terminan con la letra "r". Ejemplo: "ventilador", "reloj", "buscador" → "buscador"


namespace PracticaLinq
{
    namespace PracticaLinq
    {
        public class Ej3
=======
﻿namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
            List<string> list = new List<string>();
            list.Add("computadora");
            list.Add("usb");

            List<string>? listaNueva = list.Where(palabra => palabra.Length >= 5).Select(palabra => palabra.ToUpper()).ToList();

            foreach (var item in listaNueva)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
>>>>>>> b4470cbe6d104f575a8d92bcf26a5facd6b32171
        {
            public Ej3()
            {
                List<string> list = new List<string>();
                list.Add("destornillador");
                list.Add("buscador");
                list.Add("borrador");
                var result = BuscarPalabrasPorLetras(list);
                result.ForEach(Console.WriteLine);


            }
            public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
            {
                return palabras.Where(item => item[0] == 'b' && item[item.Length - 1] == 'r').ToList();
            }
        }
    }
}