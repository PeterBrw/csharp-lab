using entitati;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app1
{
    public abstract class ProdusAbstractMgr
    {
        protected static ListaGen<ProdusAbstract> elemente = new ListaGen<ProdusAbstract>(); 

        public void Write2Console()
        {
            var interogare = from prod in elemente
                             orderby prod.Nume
                             select prod;
            foreach (ProdusAbstract prod in interogare)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
