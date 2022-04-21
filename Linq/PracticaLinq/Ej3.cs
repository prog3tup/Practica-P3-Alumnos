namespace PracticaLinq
{
    public class Ej3
    {
        public Ej3()
        {
            List<string> items_list = new List<string>();
            items_list.Add("ventilador");
            items_list.Add("reloj");
            items_list.Add("buscador");
            items_list.Add("batimovil");
            items_list.Add("joroba");

           var final_list = items_list.Where(n => n.StartsWith('b') && n.EndsWith('r')).ToList();

            foreach (var item in final_list)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> BuscarPalabrasPorLetras(List<string> items)
        {
            return items.Where(n => n.StartsWith('b') && n.EndsWith('r')).ToList();
        }
    }
}
