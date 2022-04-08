//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b"
//y terminan con la letra "r". Ejemplo: "ventilador", "reloj", "buscador" → "buscador"


namespace PracticaLinq
{
    namespace PracticaLinq
    {
        public class Ej3
        {
            public Ej3()
            {
                List<string> list = new List<string>();
                list.Add("destornillador");
                list.Add("cuadro");
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