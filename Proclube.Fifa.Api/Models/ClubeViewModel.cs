using Proclube.Fifa.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proclube.Fifa.Api.Models
{
    public class ClubeViewModel
    {
        public ClubeViewModel()
        {

            this.DataRegistro = DateTime.Now;
        }

        public int ClubeID
        {
            get;
            set;

        }


        [Required(ErrorMessage = "Nome do Time é obrigatório")]
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

        public List<Jogador> Jogadores
        {
            get;
            set;
        }

    }
}