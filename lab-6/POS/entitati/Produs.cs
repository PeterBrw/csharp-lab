using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs : ProdusAbstract, IPackageble
    {
        string producator;
        public Produs(long id, string nume, string codIntern, int pret, string categorie, string producator) : base( id, nume, codIntern, pret, categorie) 
            {
            this.Producator = producator;
            }

        public string Producator { get => producator; set => producator = value; }

        public bool canAddToPackage(Pachet pachet)
        {
            int nrProduse = 0;
            foreach (IPackageble item in pachet.Elem_pachet)
            {
                if (item is Produs)
                    nrProduse++;
            }

            if(nrProduse < pachet.NrProduse)
            {
                return true;
            }

            return false;
        }

        public override string Descriere()
                {
            return $@" Produs
Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern}
Pret: {Pret},
Categorie: {Categorie},
Producator: {Producator}
";
        }
    }
}

