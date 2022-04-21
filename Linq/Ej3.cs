//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
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

            List<string>? listaNueva = list.Where(palabra => palabra.StartsWith('b') && palabra.EndsWith('r')).ToList();

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            throw new NotImplementedException();
        }
    }
}
