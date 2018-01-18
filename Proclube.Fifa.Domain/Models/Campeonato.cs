using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Models
{
    public class Campeonato
    {
        public Campeonato()
        {
            this.DataRegistro = DateTime.Now;
        }

        public int CampeonatoID
        {
            get;
            set;

        }

        public string Nome
        {
            get;
            set;

        }

        public string Descricao
        {
            get;
            set;
        }

        public DateTime DataRegistro
        {
            get;
            set;
        }

        public DateTime DataInicio
        {
            get;
            set;
        }

        public DateTime DataFim
        {
            get;
            set;
        }



    }
}
