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
        public ServiciuMgr(int nrServicii)
        {
            this.nrServicii = nrServicii;
        }
        public void AdaugareServicii()
        {
            int cnt = 0;
            while (cnt < nrServicii)
            {
                Console.WriteLine("Id serviciu: ");
                long id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nume serviciu: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern serviciu: ");
                string codIntern = Console.ReadLine();
                Serviciu serv = new Serviciu(id, nume, codIntern);

                //bool exist = produseServicii.Any(item => item.Id == serv.Id && item.Nume == serv.Nume && item.CodIntern == serv.CodIntern);

                bool exist = false;

                foreach(ProdusAbstract obj in produseServicii)
                {
                    if(obj.Id.Equals(serv.Id) && obj.Nume.Equals(serv.Nume) && obj.CodIntern.Equals(serv.CodIntern))
                    {
                        exist = true;
                    }
                }


                if (exist)
                {
                    Console.WriteLine("Serviciul exista deja!");
                    continue;
                }
                else
                {
                    produseServicii.Adauga(serv);
                    cnt++;
                    Console.WriteLine("Serviciu adaugat!");
                }
            }
        }

        public void AfisareServicii()
        {
            foreach (ProdusAbstract serviciu in produseServicii)
            {
                Console.WriteLine(serviciu.Descriere());
            }
        }
    }
}
