using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace entitati
{
    public class Serviciu : ProdusAbstract, IPackageble
        
    {
        public Serviciu()
        {

        }
        public Serviciu(long id, string nume, string codIntern, int pret, string categorie) : base(id, nume, codIntern, pret, categorie) {}

        public bool canAddToPackage(Pachet pachet)
        {
            if(pachet.NrTotalServicii < pachet.NrServicii)
            {
                return true;
            }

            return false;
        }
        public override string Descriere()
        {
            return $@"Serviciu
Nume: {Nume},
Id: {Id},
Cod Intern: {CodIntern},
Pret: {Pret},
Categorie: {Categorie}
";
        }

        public void save2XML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Serviciu));
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this);
            sw.Close();
        }

    }
}