using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public int movements { get; set; }

        public Hanoi()
        {
            movements = 0;
        }
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty() || (!b.isEmpty() && a.Top > b.Top))
            {
                a.push(b.pop());
            }
            else if (b.isEmpty() || (!a.isEmpty() && b.Top > a.Top))
            {
                b.push(a.pop());
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            // Comprobamos si n es un número impar o no
            bool IMPAR = (n % 2 != 0);
            int movements = 0;
            while (fin.Elementos.Count < n)
            {
                if (IMPAR)
                {
                    mover_disco(ini, fin);
                    movements++;
                    if (fin.Elementos.Count < n)
                    {
                        mover_disco(ini, aux);
                        movements++;
                    }
                    if (fin.Elementos.Count < n)
                    {
                        mover_disco(aux, fin);
                        movements++;
                    }
                }
                else
                {
                    mover_disco(ini, aux);
                    movements++;
                    if (fin.Elementos.Count < n)
                    {
                        mover_disco(ini, fin);
                        movements++;
                    }
                    if (fin.Elementos.Count < n)
                    {
                        mover_disco(aux, fin);
                        movements++;
                    }
                }
            }
            return movements;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                mover_disco(ini, fin);
                movements++;
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                movements++;
                recursivo(n - 1, aux, fin, ini);
            }
            return movements;
        }


    }
}
