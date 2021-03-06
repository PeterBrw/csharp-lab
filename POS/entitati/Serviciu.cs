using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Serviciu
    {
        long id;
        String nume;
        String codIntern;

        public Serviciu(long id, string nume, string codIntern)
        {
            this.Id = id;
            this.Nume = nume;
            this.CodIntern = codIntern;
        }

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }

        public string Afisare()
        {
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern}
";
        }
    }
}



