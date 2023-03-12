using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }
        public Pila()
        {
            Size = 0;
            Elementos = new List<Disco>();
            Top = 0;
        }

        public Pila(int size)
        {
            this.Size = Size;
            Elementos = new List<Disco>();
            Top = -1;

            int i = Size;
            while (i > 0)
            {
                Elementos.Add(new Disco(i));
                Top = Elementos.Last().Valor;
                i--;
            }
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = Elementos.Last().Valor;
        }

        public Disco pop()
        {
            Disco d = null;
            if (Elementos.Count > 0)
            {
                d = Elementos[Elementos.Count - 1];
                Elementos.RemoveAt(Elementos.Count - 1);
                if (Elementos.Count > 0)
                {
                    Top = Elementos[Elementos.Count - 1].Valor;
                }
                else
                {
                    Top = 0;
                }
            }
            return d;
        }

        public bool isEmpty()
        {
            return !Elementos.Any();
        }

    }
}
