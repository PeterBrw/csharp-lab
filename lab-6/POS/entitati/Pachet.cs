using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Pachet : ProdusAbstract, IPackageble
    {
        List<IPackageble> elem_pachet = new List<IPackageble>();
        int nrProduse;
        int nrServicii;
        public Pachet(int id, string nume, string codIntern, int nrServicii, int nrProduse) : base(id, nume, codIntern)
        {
            this.NrProduse = nrProduse;
            this.NrServicii = nrServicii;
        }

        public List<IPackageble> Elem_pachet { get => elem_pachet; set => elem_pachet = value; }
        public int NrProduse { get => nrProduse; set => nrProduse = value; }
        public int NrServicii { get => nrServicii; set => nrServicii = value; }

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
            var builder = new StringBuilder("");
            foreach (IPackageble elem in elem_pachet)
            {
                builder.Append(((ProdusAbstract)elem).Descriere()); 
            }
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern},
Pret: {NrProduse},
Categorie: {NrProduse}
Elemente Pachet: {builder.ToString()}
"; 
        }
    }
}
