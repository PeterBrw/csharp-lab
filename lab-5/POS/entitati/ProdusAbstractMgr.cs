using entitati;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class ProdusAbstractMgr
    {
        protected static List<ProdusAbstract> produseServicii = new List<ProdusAbstract>(); // aici punem lista in loc de lista tipizata

        public void Write2Console()
        {
            produseServicii = (from prod in produseServicii
                                                           orderby prod.Nume
                                                           select prod
                                                          ).ToList();
            foreach (ProdusAbstract prod in produseServicii)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
