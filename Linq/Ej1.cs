namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1()
        {

            var listEj = new List<int>() { 67, 92, 153, 15 };

            var filterList = listEj.Where(n => n > 30 && n < 100);

            foreach (var item in filterList)
            {
                Console.WriteLine(item);
            }

        }
}
}
