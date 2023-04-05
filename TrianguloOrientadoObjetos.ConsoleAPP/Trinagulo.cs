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
        public bool podeSerTringulo = true;
        public bool isoceles , equilatero, escaleno;
        
        
       public bool VerificarSePodeSerTrinagulo()
        {
            if (lado1 + lado2 < lado3 || lado2 + lado3 < lado1 || lado3 + lado1 < lado2)
            {
                return false;
                
            }

            else
            {
                podeSerTringulo = true;
                VerificarTipoTriangulo();
                return true;
            }
        }

        public bool VerificarTipoTriangulo()
        {
            if (podeSerTringulo)
            {
                if(lado1 != lado2 && lado2 != lado3)
                {
                   escaleno = true;
                    return escaleno;
                }

                else if (lado1 == lado2 && lado2 == lado3)
                {
                    equilatero = true;
                    return equilatero;
                }

                else if (lado1 == lado2 && lado2 != lado3 || lado2 == lado3 && lado2 != lado1 || lado1 == lado3 && lado3 != lado2)
                {
                   isoceles = true;
                    return isoceles;
                }
            }
            return false;
        }
    }
}
