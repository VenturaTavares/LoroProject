﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Models
{
    public class Desenvolvimento
    {
        public Desenvolvimento()
        {
        }

        public int DesenvolvimentoID
        {
            get;
            set;
        }


        public int JogadorID
        {
            get;
            set;
        }


        public int Fisico
        {
            get;
            set;
        }

        public int Defesa
        {
            get;
            set;
        }

        public int Drible
        {
            get;
            set;
        }

        public int Passe
        {
            get;
            set;
        }

        public int Finalizacao
        {
            get;
            set;
        }

        public int Ritmo
        {
            get;
            set;
        }

        public int Goleiro
        {
            get;
            set;
        }

    }
}
