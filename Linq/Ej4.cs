namespace PracticaLinq
{
    public class Ej4
    {
        public Ej4()
        {
            List<int> numbers = new();
            numbers.Add(78);
            numbers.Add(-9);
            numbers.Add(0);
            numbers.Add(23);
            numbers.Add(54);
            numbers.Add(21);
            numbers.Add(7);
            numbers.Add(86);
            var result = numbers.OrderByDescending(num => num).Take(5).ToList();
            foreach (var num in result)
            {
                Console.WriteLine(num.ToString());
            }
        }

        public static List<int> PrimerosDescendiente(int[] numeros)
        {
            return numeros.OrderByDescending(num => num).Take(5).ToList();
        }
    }
}
