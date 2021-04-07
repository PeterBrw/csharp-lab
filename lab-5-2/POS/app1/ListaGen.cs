using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class ListaGen<T> : IEnumerable<T>
    {
        int count = 0;
        private class Nod
        {
            public Nod(T t)
            {
                next = null;
                data = t;
            }
            private Nod next;
            public Nod Next
            {
                get {return next; }
                set { next = value; }
            }

            private T data;

            public T Data
            {
                get { return data; }
                set { data = value; }
            }

        } 

        private Nod inceput;

        public int Count { get => count; set => count = value; }

        public ListaGen()
        {
            inceput = null;
        }

        public void Insereaza(T t)
        {
            Nod n = new Nod(t);
            n.Next = inceput;
            inceput = n;
            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Nod current = inceput;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
