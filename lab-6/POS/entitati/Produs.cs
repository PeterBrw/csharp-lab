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
            throw new NotImplementedException();
        }

        public override string Descriere()
                {
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern}
Pret: {Pret},
Categorie: {Categorie},
Producator: {Producator}
";
        }
    }
}

