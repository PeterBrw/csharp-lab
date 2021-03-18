using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class ServiciuMgr : ProdusAbstractMgr
    {
        int nrServicii;
        //List<Serviciu> servicii = new List<Serviciu>();

        public ServiciuMgr(int nrServicii)
        {
            this.nrServicii = nrServicii;
        }
        public void AdaugareServicii()
        {
            while (produseServicii.Count < nrServicii)
            {
                Console.WriteLine("Id serviciu: ");
                long id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nume serviciu: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern serviciu: ");
                string codIntern = Console.ReadLine();
                Serviciu serv = new Serviciu(id, nume, codIntern);

                bool exist = produseServicii.Any(item => item.Id == serv.Id && item.Nume == serv.Nume && item.CodIntern == serv.CodIntern);

                if (exist)
                {
                    Console.WriteLine("Serviciul exista deja!");
                    continue;
                }
                else
                {
                    produseServicii.Add(serv);
                    Console.WriteLine("Serviciu adaugat!");
                }
            }
        }

        public void AfisareServicii(List<Serviciu> servicii)
        {
            foreach (var serviciu in produseServicii)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}
