using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace app1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Nr. servicii: ");
            int nrServicii = int.Parse(Console.ReadLine());
            Console.WriteLine("Nr. produse: ");
            int nrProduse = int.Parse(Console.ReadLine());

            ServiciuMgr seviciiManager = new ServiciuMgr(nrServicii);
            ProdeseMgr prodeseManager = new ProdeseMgr(nrProduse);

            seviciiManager.AdaugareServicii();
            prodeseManager.AdaugareProduse();

            prodeseManager.AdaugareProduse();
            prodeseManager.AfisareProduse();
        }
    }
}
