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
        protected static ArrayList elemente = new ArrayList();

        public void Write2Console()
        {
            elemente.Sort(new CustomComparer());
            foreach(ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
