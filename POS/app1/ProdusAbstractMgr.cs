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
