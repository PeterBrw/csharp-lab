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
        protected static ColectieTipizata elemente = new ColectieTipizata();

        public void Write2Console()
        {
            elemente.Sortare();
            foreach(ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
    }
}
