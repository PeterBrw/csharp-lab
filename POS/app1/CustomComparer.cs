using entitati;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class CustomComparer : IComparer
    {
        Comparer _comparer = new Comparer(System.Globalization.CultureInfo.CurrentCulture);

        public int Compare(object x, object y)
        {
            return _comparer.Compare(((ProdusAbstract)(x)).Nume, ((ProdusAbstract)(y)).Nume);
        }
    }
}