﻿using entitati;
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
        protected static List<ProdusAbstract> produseServicii = new List<ProdusAbstract>(); 

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
