using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proclube.Fifa.Api.Models
{
    public class CampeonatoViewModel
    {


        public CampeonatoViewModel()
        {
            this.DataRegistro = DateTime.Now;
        }

        public int CampeonatoID
        {
            get;
            set;

        }


        [Required(ErrorMessage = "Nome Campeonato é obrigatório")]
        public string Nome
        {
            get;
            set;

        }

        [Required(ErrorMessage = "Descricao é obrigatório")]
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