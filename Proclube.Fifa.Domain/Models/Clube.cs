using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Models
{
    public class Clube
    {
        public Clube()
        {

            this.DataRegistro = DateTime.Now;
        }

        public int ClubeID
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


    }
}
