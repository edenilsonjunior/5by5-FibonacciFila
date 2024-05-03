using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFila
{
    internal class FilaNumero
    {
        Numero? head;
        Numero? tail;
        int tamanho;

        public FilaNumero()
        {
            this.head = null;
            this.tail = null;
        }

        public void Enqueue(Numero aux)
        {
            if (IsEmpty())
            {
                head = aux;
                tail = aux;
            }
            else
            {
                tail.SetProximo(aux);
                tail = aux;
            }
            tamanho++;
        }

        public Numero? Dequeue()
        {
            if (!IsEmpty())
            {
                Numero aux = head;

                if (head == tail)
                    head = tail = null;
                else
                    head = head.GetProximo();

                tamanho--;

                return aux;
            }
            return null;
        }

        public int GetTamanho()
        {
            return tamanho;
        }

        public void Print()
        {

            if (IsEmpty())
            {
                Console.WriteLine("-->Fila vazia!");
            }
            else
            {
                Numero aux = head;

                while (aux != null)
                {
                    Console.WriteLine($"--> {aux}");
                    aux = aux.GetProximo();
                }
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
