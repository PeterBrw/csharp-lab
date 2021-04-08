using entitati;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public abstract class ProdusAbstractMgr
    {
        protected static List<ProdusAbstract> elemente = new List<ProdusAbstract>(); 

        public void Write2Console()
        {
            elemente = (from prod in elemente
                                                           orderby prod.Nume
                                                           select prod
                                                          ).ToList();
            foreach (ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
