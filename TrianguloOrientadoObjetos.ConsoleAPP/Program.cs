namespace TrianguloOrientadoObjetos.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trinagulo trinagulo = new Trinagulo();

            Console.Write("Qual o lado 1: ");
            trinagulo.lado1 = int.Parse(Console.ReadLine());

            Console.Write("\nQual o lado 2: ");
            trinagulo.lado2 = int.Parse(Console.ReadLine());

            Console.Write("\nQual o lado 3: ");
            trinagulo.lado3 = int.Parse(Console.ReadLine());

            trinagulo.VerificarSePodeSerTrinagulo();
        }
    }
}