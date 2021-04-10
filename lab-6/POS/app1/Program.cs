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

           
            PacheteMgr pachete = new PacheteMgr();
            pachete.InitListafromXML();

            produseManager.InitListafromXML();
            seviciiManager.InitListafromXML();


            pachete.Write2Console();
        }
    }
}
