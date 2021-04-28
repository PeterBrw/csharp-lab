using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class FiltrareCriteriu : IFiltrare
    {
        public IEnumerable<ProdusAbstract> Filtrare(List<ProdusAbstract> elemente, ICriteriu criteriu)
        {
           return   from elem in elemente
                    where criteriu.IsIndeplinit(elem)
                    select elem;
        }
    }
}
