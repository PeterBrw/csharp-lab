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
