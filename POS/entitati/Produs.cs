using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Produs : ProdusAbstract
    {
        string producator;
        public Produs(long id, string nume, string codIntern, string producator) : base( id, nume, codIntern) 
            {
            this.Producator = producator;
            }

        public string Producator { get => producator; set => producator = value; }

        public override string Descriere()
                {
            return $@"Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern}
Producator: {Producator}
";
        }
            }
    }

