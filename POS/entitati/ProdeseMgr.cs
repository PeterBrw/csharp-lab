using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class ProdeseMgr : ProdusAbstractMgr
    {
        int nrProduse;
        //List<Produs> produse = new List<Produs>();

        public ProdeseMgr(int nrProduse)
        {
            this.nrProduse = nrProduse;
        }

        public void AdaugareProduse ()
        {
            while (produseServicii.Count < nrProduse)
            {
                Console.WriteLine("Id produs: ");
                long id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nume produs: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern serviciu: ");
                string codIntern = Console.ReadLine();
                Console.WriteLine("Producator: ");
                string producator = Console.ReadLine();
                Produs prod = new Produs(id, nume, codIntern, producator);

                bool exist = produseServicii.Any(item => item.Id == prod.Id && item.Nume == prod.Nume && item.CodIntern == prod.CodIntern ); // && item.Producator == prod.Producator

                if (exist)
                {
                    Console.WriteLine("Produs exista deja!");
                    continue;
                }
                else
                {
                    produseServicii.Add(prod);
                    Console.WriteLine("Produs adaugat!");
                }
            }
        }

        public void AfisareProduse()
        {
            foreach (var produs in produseServicii)
            {
                Console.WriteLine(produs.Descriere());
            }
        }
    }
}
