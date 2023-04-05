namespace TrianguloOrientadoObjetos.ConsoleAPP
{
    internal class Program
    {
        private static void PegarValores(Trinagulo trinagulo)
        {
            Console.Write("Qual o lado 1: ");
            trinagulo.lado1 = int.Parse(Console.ReadLine());

            Console.Write("\nQual o lado 2: ");
            trinagulo.lado2 = int.Parse(Console.ReadLine());

            Console.Write("\nQual o lado 3: ");
            trinagulo.lado3 = int.Parse(Console.ReadLine());
        }

        private static void ImprimeResposta(Trinagulo trinagulo)
        {
            if (trinagulo.VerificarSePodeSerTrinagulo())
            {
                if (trinagulo.escaleno)
                {
                    Console.WriteLine("\nEh um triangulo escaleno!");
                }

                else if (trinagulo.isoceles)
                {
                    Console.WriteLine("\nEh um trinagulo isoceles");
                }

                else if (trinagulo.equilatero)
                {
                    Console.WriteLine("\nEh um triangulo equilatero!");
                }
            }

            else
            {
                Console.WriteLine("\nNao pode ser triangulo!");
            }
        }

        static void Main(string[] args)
        {
            Trinagulo trinagulo = new Trinagulo();

            PegarValores(trinagulo);

            trinagulo.VerificarSePodeSerTrinagulo();

            ImprimeResposta(trinagulo);

        }
    }
}