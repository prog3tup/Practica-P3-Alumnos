//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b"
//y terminan con la letra "r". Ejemplo: "ventilador", "reloj", "buscador" → "buscador"



namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {

            List<string> BuscarPalabras = new List<string>();

            BuscarPalabras.Add("ventilador");
            BuscarPalabras.Add("reloj");
            BuscarPalabras.Add("buscador");

            var palabrasBandR = BuscarPalabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();

            foreach (var i in palabrasBandR)
            {
                Console.WriteLine(i);
            }


        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            return palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        }
    }
}
