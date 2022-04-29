namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
            int[] numeros = { 7, 2, 20, 3 };
            List<int> numerosCuadradosMayorA20 = CalcularCuadrados(numeros);
            foreach (int numero in numerosCuadradosMayorA20)
                Console.WriteLine(numero);
        }

        public static List<int> CalcularCuadrados(int[] numeros)
        {
            List<int> cuadrados = numeros.Select(numero => numero*numero).ToList();

            return cuadrados.Where(numero => numero >20).ToList() ;
        }
    }
}
