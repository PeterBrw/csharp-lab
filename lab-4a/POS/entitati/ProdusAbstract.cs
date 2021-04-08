using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class ProdusAbstract
    {
        long id;
        String nume;
        String codIntern;

        protected ProdusAbstract(long id, string nume, string codIntern)
        {
            this.Id = id;
            this.Nume = nume;
            this.CodIntern = codIntern;
        }

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }

        public abstract String Descriere();
    }
}
