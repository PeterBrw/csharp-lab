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
        protected static ColectieTipizata produseServicii = new ColectieTipizata();

        public void Write2Console()
        {
            foreach(ProdusAbstract prod in produseServicii)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
