using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Serviciu : ProdusAbstract
        
    {
        public Serviciu(long id, string nume, string codIntern, int pret, string categorie) : base(id, nume, codIntern, pret, categorie) {}

        public override string Descriere()
        {
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern},
Pret: {Pret},
Categorie: {Categorie}
";
        }
    }
}



