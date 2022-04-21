namespace PracticaLinq
{
    public class Ej5
    {
        public Ej5()
        {
           
        }

        public static List<string> CalcularCuadrados(int[] numeros)
        {
            List<string> numerosCuadrados = new();
            for (int i = 0; i < numeros.Length; i++)
            {
                if(Math.Pow(numeros[i],2) > 20) { 
                numerosCuadrados.Add($"{numeros[i]} - {Math.Pow(numeros[i], 2)}");
                };
            }
            return numerosCuadrados;   
        }
    }
}
