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
            ProduseMgr produseManager = new ProduseMgr();
            ServiciuMgr seviciiManager = new ServiciuMgr();

            produseManager.InitListafromXML();
            seviciiManager.InitListafromXML();

            produseManager.Write2Console();
        }
    }
}
