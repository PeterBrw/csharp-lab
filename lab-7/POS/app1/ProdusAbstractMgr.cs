using entitati;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace app1
{
    public abstract class ProdusAbstractMgr
    {
        protected static List<ProdusAbstract> elemente = new List<ProdusAbstract>(); 

        public void Write2Console()
        {
            //elemente = (from prod in elemente
            //            orderby prod.Nume
            //            select prod
            //            ).ToList();
            foreach (ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
        public void Filtrare()
        {
            FiltrareCriteriu filtrare = new FiltrareCriteriu();
            foreach(ProdusAbstract prod in filtrare.Filtrare(elemente, new CriteriuPret(10000)))
            {
                Console.WriteLine(prod.Descriere());
            }

            Console.WriteLine("\n");

            foreach (ProdusAbstract prod in filtrare.Filtrare(elemente, new CriteriuCategorie("Tehnologia Informatiei")))
            {
                Console.WriteLine(prod.Descriere());
            }
        }

        public void save2XML(string fileName)
        {
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Pachet);
            prodAbstractTypes[1] = typeof(Serviciu);
            prodAbstractTypes[2] = typeof(Produs);
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>), prodAbstractTypes);
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            try
            {
                xs.Serialize(sw, elemente);
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException source: " + e.Source);
            }
            sw.Close();
        }

        public List<ProdusAbstract> loadFromXML(string fileName)
        {
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Pachet);
            prodAbstractTypes[1] = typeof(Serviciu);
            prodAbstractTypes[2] = typeof(Produs);
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>), prodAbstractTypes);
            try
            {
                FileStream fs = new FileStream(fileName + ".xml", FileMode.Open);
                XmlReader reader = new XmlTextReader(fs);
                List<ProdusAbstract> colectie = (List<ProdusAbstract>)xs.Deserialize(reader);
                fs.Close();
                return colectie;

            }
            catch (IOException e)
            {
                Console.WriteLine("IOException source: " + e.Source);
            }
            return null;
        }
    }
}
