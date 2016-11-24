﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class Artigo
    {
        public string CodArtigo
        {
            get;
            set;
        }

        public string DescArtigo
        {
            get;
            set;
        }

        public double StockActual
        {
            get;
            set;
        }

        public string Marca
        {
            get;
            set;
        }


        public double PCPadrao
        {
            get;
            set;
        }
        public string familia
        {
            get;
            set;
        }
        public string subFamilia
        {
            get;
            set;
        }

    }
}