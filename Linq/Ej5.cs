namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
           List<int> lista = new();
            lista.Add(7);
            lista.Add(2);
            lista.Add(30);
            var result = lista.Where(num => num * num > 20);
            foreach (var num in result)
            {
                Console.WriteLine(num.ToString());
            }
        }
        public static List<string> CalcularCuadrados(int[] numeros)
        {
            //return numeros.Where(num => num * num > 20);
            throw new NotImplementedException();
        }
    }

    
}
