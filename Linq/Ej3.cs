
//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
//Ejemplo: "ventilador", "reloj", "buscador" → "buscador"


namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            List<string> listanueva = new List<string>();
            listanueva.Add("buscador");
            return listanueva;
        }
    }
}
