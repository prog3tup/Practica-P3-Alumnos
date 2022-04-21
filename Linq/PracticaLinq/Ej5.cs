namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            List<double> int_list = new List<double>();

            int_list.Add(7);
            int_list.Add(0);
            int_list.Add(3);
            int_list.Add(21);
            int_list.Add(7);

            var second_int_list = int_list.Where(n => Math.Pow(n, 2) >= 20).ToArray();
            var final_int_list = second_int_list.Select($"{second_int_list} - {Math.Pow(second_int_list, 2)}".ToList());
           
            foreach (double word in final_int_list)
            {

                Console.WriteLine(word);

            }
        }

        public static List<string> CalcularCuadrados(int[] numbers)
        {
            throw new NotImplementedException();
            numbers = numbers.Where(x => Math.Pow(x, 2) >= 20).ToArray();
            return numbers.Select($"{numbers} - { Math.Pow(numbers, 2)}".ToList());
        }
    }
}
