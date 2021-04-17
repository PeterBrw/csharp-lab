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
        int pret;
        String categorie;

        protected ProdusAbstract(long id, string nume, string codIntern, int pret, string categorie)
        {
            this.Id = id;
            this.Nume = nume;
            this.CodIntern = codIntern;
            this.Pret = pret;
            this.Categorie = categorie;
        }

        protected ProdusAbstract(long id, string nume, string codIntern, string categorie)
        {
            this.Id = id;
            this.Nume = nume;
            this.CodIntern = codIntern;
            this.Categorie = categorie;
        }

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }
        public int Pret { get => pret; set => pret = value; }
        public string Categorie { get => categorie; set => categorie = value; }

        public abstract String Descriere();
    }
}
