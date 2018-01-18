using Proclube.Fifa.Domain.Infraestrutura;
using Proclube.Fifa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Repositorio
{
    public class CampeonatoRepositorio : BaseRepository<Campeonato>, IDisposable
    {
        public CampeonatoRepositorio(ProclubeContext context) : base(context)
        {

        }
        public void Dispose()
        {
            _context.Dispose();
        }




        public async Task<Campeonato> ObterCampeonato(int CampeonatoID)
        {

            Campeonato Campeonato = new Campeonato();

            Campeonato.CampeonatoID = 1;
            Campeonato.Nome = "Campeonato Brasileiro";
            Campeonato.Descricao = "Campeonato Brasileiro";
            Campeonato.DataInicio = DateTime.Now;
            Campeonato.DataFim = DateTime.Now.AddMonths(12);

            return Campeonato;


        }


        public async Task<List<Clube>> ObterClubesPartcipantes(int CampeonatoID)
        {
            List<Clube> ListaClubes = new List<Clube>();


            using (var Rep = new ClubeRepository(new ProclubeContext()))
            {

                ListaClubes = await Rep.ObterClubesCampeonato(CampeonatoID);

            }

            return ListaClubes;

        }


    }
}
