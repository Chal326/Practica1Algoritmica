using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //Declaramos Variables.
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        //Constructor Vacio
        public Pila()
        {
            Size = 0;
            Elementos = new List<Disco>();
            Top = 0;
        }

        //Constructor Pila
        public Pila(int size)
        {
            this.Size = size;  //tamaño de la pila
            Elementos = new List<Disco>(size);
            Top = -1;

            for (int i = 1; i <= this.Size; i++)
            {
                Elementos.Add(new Disco(this.Size - i + 1)); // Agrega un nuevo objeto Disco a la propiedad Elementos con el tamaño del disco decreciente y comenzando desde 1.
            }

            Top = Elementos.Last().Valor;
        }


        //Metodo para añadir un disco a la pila
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = Elementos.Last().Valor; // asignamos a TOP el valor del ultimo elemento de la lista
        }

        //Metodo para eliminar un disco de la pila
        public Disco pop()
        {
            Disco d = Elementos.Last();
            Elementos.Remove(d);
            int lastIndex = Elementos.Count - 1;
            if (lastIndex >= 0)
            {
                Top = Elementos.Last().Valor;
            }
            else
            {
                Top = 0;
            }

            return d;
        }

        //Metodo para saber si la lista elementos esta vacia.
        public bool isEmpty()
        {
            return !Elementos.Any();
        }

    }
}