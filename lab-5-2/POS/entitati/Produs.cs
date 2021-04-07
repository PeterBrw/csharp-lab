namespace entitati
{
    public class Produs : ProdusAbstract
    {
        string producator;
        public Produs(long id, string nume, string codIntern, int pret, string categorie, string producator) : base( id, nume, codIntern, pret, categorie) 
            {
            this.Producator = producator;
            }

        public string Producator { get => producator; set => producator = value; }

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

