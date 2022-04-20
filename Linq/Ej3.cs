namespace PracticaLinq
{
/*Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
Ejemplo: "ventilador", "reloj", "buscador" → "buscador"
*/
    public class Ej3
    {
        public Ej3()
        {
            List<string> list = new List<string>();
            list.Add("ventilador");
            list.Add("reloj");
            list.Add("buscador");
            list.Add("sarasa");
            list.Add("bokee");

           var newList = list.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> palabras)
        {
            throw new NotImplementedException();
            return palabras.Where(x => x.StartsWith('b') && x.EndsWith('r')).ToList();
        }
    }
}
}