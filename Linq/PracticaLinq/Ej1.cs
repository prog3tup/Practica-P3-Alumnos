namespace PracticaLinq
{
    public class Ej1
    {
        public Ej1()
        {
            List<int> number_list = new List<int>();
            number_list.Add(67);
            number_list.Add(92);
            number_list.Add(153);
            number_list.Add(15);

            var result = number_list.Where(n => n <=100 && x > 30).ToList();

            foreach (var number_list in result)
            {
                Console.WriteLine(number_list);
            }
        }

    }
}
