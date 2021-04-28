using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class CriteriuCategorie : ICriteriu
    {
        string categorie;

        public CriteriuCategorie(string categorie)
        {
            this.categorie = categorie;
        }

        public bool IsIndeplinit(ProdusAbstract prod)
        {
            return (prod.Categorie == this.categorie);
        }
    }
}
