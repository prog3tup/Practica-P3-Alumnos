
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
            list.Add("bdaras");

            // var listaFiltrada = list.Where(el => el.StartsWith('b'));
            // listaFiltrada = listaFiltrada.Where(el => el.EndsWith('r'));

            var listaFiltrada = BuscarPalabrasPorLetras(list);
            foreach (var el in listaFiltrada)
            {
                Console.WriteLine(el);
            }

        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            palabras = palabras.Where(el => el.StartsWith('b')).ToList();
            palabras = palabras.Where(el => el.EndsWith('r')).ToList();
            return palabras;
        }
    }
}
