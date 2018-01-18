using Proclube.Fifa.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proclube.Fifa.Api.Models
{
    public class JogadorViewModel
    {
        public JogadorViewModel()
        {

            DataRegistro = DateTime.Now;
        }



        public int JogadorID
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Posicao do jogador é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Posicao do jogador é obrigatório")]
        public int PosicaoID
        {
            get;
            set;
        }

        public Posicao Posicao
        {
            get;
            set;
        }

        public Usuario Usuario
        {
            get;
            set;
        }


        [Required(ErrorMessage = "Nome do jogador é obrigatório")]
        public string Nome
        {
            get;
            set;

        }

        [Required(ErrorMessage = "Altura do jogador é obrigatório")]
        [Range(1, double.MaxValue, ErrorMessage = "Altura do jogador é obrigatório")]
        public double Altura
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Altura do jogador é obrigatório")]
        [Range(1, double.MaxValue, ErrorMessage = "Altura do jogador é obrigatório")]
        public double Peso
        {
            get;
            set;
        }

        public DateTime DataRegistro
        {
            get;
            set;
        }


        public byte FotoProfile
        {
            get;
            set;
        }
    }
}