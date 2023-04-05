using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoObjetos.ConsoleAPP
{
    public class Trinagulo
    {

        public int lado1;
        public int lado2;
        public int lado3;
        public bool podeSerTringulo = false;
        
       public void VerificarSePodeSerTrinagulo()
        {
            if (lado1 + lado2 < lado3 || lado2 + lado3 < lado1 || lado3 + lado1 < lado2)
            {
                Console.WriteLine("Nao pode ser um triangulo"); 
                
            }

            else
            {
                podeSerTringulo = true;
                VerificarTipoTriangulo();
                
            }
        }

        public void VerificarTipoTriangulo()
        {
            if (podeSerTringulo)
            {
                if(lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("Eh um Trinagulo Escaleno"); 
                }

                else if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Eh um tringulo Equilatero");
                }

                else if (lado1 == lado2 && lado2 != lado3 || lado2 == lado3 && lado2 != lado1 || lado1 == lado3 && lado3 != lado2)
                {
                    Console.WriteLine("Eh um triangulo Isoceles");
                }
            }
        }
    }
}
