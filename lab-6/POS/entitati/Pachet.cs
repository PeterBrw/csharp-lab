using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Pachet : ProdusAbstract, IPackageble
    {
        private List<IPackageble> elem_pachet = new List<IPackageble>();
        public Pachet(long id, string nume, string codIntern, int pret, string categorie) : base(id, nume, codIntern, pret, categorie)
        {
        }

        public void Add_element(IPackageble p)
        {
            if (p.canAddToPackage(this))
            {
                elem_pachet.Add(p);
            }
        }

        public bool canAddToPackage(Pachet pachet)
        {
            return false ;
        }

        public override string Descriere()
        {
           foreach(IPackageble elem in elem_pachet)
            {
                ((ProdusAbstract)elem).Descriere(); // here it's 
            }
           return "string";
        }
    }
}
