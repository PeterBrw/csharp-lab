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
            //elemente = (from prod in elemente
            //            orderby prod.Nume
            //            select prod
            //            ).ToList();
            foreach (ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
        public void Filtrare()
        {
            FiltrareCriteriu filtrare = new FiltrareCriteriu();
            foreach(ProdusAbstract prod in filtrare.Filtrare(elemente, new CriteriuPret(10000)))
            {
                Console.WriteLine(prod.Descriere());
            }

            Console.WriteLine("\n");

            foreach (ProdusAbstract prod in filtrare.Filtrare(elemente, new CriteriuCategorie("Tehnologia Informatiei")))
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
