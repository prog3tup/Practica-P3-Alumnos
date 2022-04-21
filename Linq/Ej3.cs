//Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
//Ejemplo: "ventilador", "reloj", "buscador" → "buscador"

namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

            List<string> list = new List<string>();
           
            list.Add("ventilador");
            list.Add("reloj");
            list.Add("buscador");
           

            var palabras = list.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();

            foreach (var i in palabras)
            {
                //Console.WriteLine(i);
            }

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        }
    }
}
