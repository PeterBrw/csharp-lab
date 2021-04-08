using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class ProduseMgr : ProdusAbstractMgr
    {
        int nrProduse;
        public ProduseMgr(int nrProduse)
        {
            this.nrProduse = nrProduse;
        }

        public void AdaugareProduse ()
        {
            int cnt = 0;
            while ( cnt < nrProduse)
            {
                Console.WriteLine("Id produs: ");
                long id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nume produs: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern producator: ");
                string codIntern = Console.ReadLine();
                Console.WriteLine("Producator: ");
                string producator = Console.ReadLine();
                Produs prod = new Produs(id, nume, codIntern, producator);

                bool exist = false;

                foreach (ProdusAbstract obj in elemente)
                {
                    if (obj.Id.Equals(prod.Id) && obj.Nume.Equals(prod.Nume) && obj.CodIntern.Equals(prod.CodIntern))
                    {
                        exist = true;
                    }
                }

                if (exist)
                {
                    Console.WriteLine("Produs exista deja!");
                    continue;
                }
                else
                {
                    elemente.Add(prod);
                    cnt++;
                    Console.WriteLine("Produs adaugat!");
                }
            }
        }
    }
}
