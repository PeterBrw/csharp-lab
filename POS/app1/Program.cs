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
            var servicii = new List<Serviciu>();
            var produse = new List<Produs>();

            AdaugareServicii(servicii, nrServicii);
            AdaugareProduse(produse, nrProduse);

            AfisareServicii(servicii);
            AfisareProduse(produse);
            
        }

        public static void AdaugareServicii(List<Serviciu> servicii, int nrServicii) 
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

        public static void AdaugareProduse(List<Produs> produse, int nrProduse)
        {
            while (produse.Count < nrProduse)
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

                bool exist = produse.Any(item => item.Id == prod.Id && item.Nume == prod.Nume && item.CodIntern == prod.CodIntern && item.Producator == prod.Producator);

                if (exist)
                {
                    Console.WriteLine("Produs exista deja!");
                    continue;
                }
                else
                {
                    produse.Add(prod);
                    Console.WriteLine("Produs adaugat!");
                }
            }
        }

        public static void AfisareServicii(List<Serviciu> servicii)
        {
            foreach (var serviciu in servicii)
            {
                Console.WriteLine(serviciu.Afisare());
            }
        }

        public static void AfisareProduse(List<Produs> produse)
        {
            foreach (var produs in produse)
            {
                Console.WriteLine(produs.Afisare());
            }
        }
    }
}
