using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs
    {
        long id;
        String nume;
        String codIntern;
        String producator;

        public Produs(long id, string nume, string codIntern, string producator)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
            this.producator = producator;
        }

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }
        public string Producator { get => producator; set => producator = value; }

        public string Afisare()
        {
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern},
Producator: {Producator}
";
        }
    }
}
