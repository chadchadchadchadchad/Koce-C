using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koce
{
    public class Variable
    {
        public static int id_u = 0;
    }

    public class kraj
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string posta { get; set; }


        public kraj()
        {
            id = 0;
            ime = "";
            posta = "";
        }

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


        public gora()
        {
            id = 0;
            ime = "";
            opis = "";
            kraj_id = 0;
        }

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


        public koca()
        {
            id = 0;
            ime = "";
            opis = "";
            nadmorska_visina = 0;
            gora_id = 0;
        }

        public koca(int i, string im, string op, int nad, int g)
        {
            id = i;
            ime = im;
            opis = op;
            nadmorska_visina = nad;
            gora_id = g;
        }
    }
}
