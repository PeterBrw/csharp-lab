using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Serviciu : ProdusAbstract
        
    {
        public Serviciu(long id, string nume, string codIntern) : base(id, nume, codIntern) {}

        public override string Descriere()
        {
            return $@"Serviciu:
Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern}
";
        }
    }
}



