using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class ColectieTipizata : System.Collections.CollectionBase
    {

        public void Adauga(ProdusAbstract produs)
        {

            this.List.Add(produs);
        }
        public void Extrage(long id)
        {

            this.List.Remove(id);
        }
        public bool Contine(ProdusAbstract produs)
        {

            String tit =
            (String)produs.CodIntern;

            return
            this.List.Contains(tit);
        }
        public bool Contine(string codIntern)
        {
            String tit = (String)codIntern;
            return this.List.Contains(tit);
        }

        public ProdusAbstract this[string codIntern]
        {
            get
            {
                if
                (this.List.Contains(codIntern))
                    return
                    (ProdusAbstract)(this.List[int.Parse(codIntern)]);
                else return null;
            }
        }
    }

}
