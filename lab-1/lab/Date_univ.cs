using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    public class Date_univ
    {
        string universitate;
        string specializare;
        int an_studiu;

        public string Universitate { get => universitate; set => universitate = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public int An_studiu { get => an_studiu; set => an_studiu = value; }

        public override string ToString()
        {
            return $@"An studiu: {An_studiu},
Specializarea: {Specializare},
Universitatea: {Universitate}";
        }
    }
}
