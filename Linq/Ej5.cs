namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
        public Ej5()
        {
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(2);
            list.Add(30);

            var cuadrados = list.Where(x => x * x > 20).Select(x => $" {x} - {x * x}").ToList();

            foreach (var n in cuadrados)
            {
                Console.WriteLine(n);
            }


        }


        public static List<string> CalcularCuadrados(int[] numeros)
        {
            return numeros.Where(x => x * x > 20).Select(x => $" {x} - {x * x}").ToList();
        }
    }
}
