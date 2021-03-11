using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class ServiciuMgr
    {
        int nrServicii;
        List<Serviciu> servicii = new List<Serviciu>();

        public ServiciuMgr(int nrServicii)
        {
            this.nrServicii = nrServicii;
        }
        public void AdaugareServicii()
        {
            while (servicii.Count < nrServicii)
            {
                Console.WriteLine("Id serviciu: ");
                long id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nume serviciu: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern serviciu: ");
                string codIntern = Console.ReadLine();
                Serviciu serv = new Serviciu(id, nume, codIntern);

                bool exist = servicii.Any(item => item.Id == serv.Id && item.Nume == serv.Nume && item.CodIntern == serv.CodIntern);

                if (exist)
                {
                    Console.WriteLine("Serviciul exista deja!");
                    continue;
                }
                else
                {
                    servicii.Add(serv);
                    Console.WriteLine("Serviciu adaugat!");
                }
            }
        }

        public void AfisareServicii(List<Serviciu> servicii)
        {
            foreach (var serviciu in servicii)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}
