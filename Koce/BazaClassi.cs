using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koce
{
    public class kraj
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string posta { get; set; }

        public kraj(int i, string na, string post)
        {
            id = i;
            ime = na;
            posta = post;
        }
    }

    public class gora
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string opis { get; set; }
        public int kraj_id { get; set; }

        public gora(int i, string na, string op, int kraji)
        {
            id = i;
            ime = na;
            opis = op;
            kraj_id = kraji;
        }
    }

    public class koca
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string opis { get; set; }

        public int nadmorska_visina { get; set; }

        public int gora_id { get; set; }
    }
}
