using Proclube.Fifa.Domain.Infraestrutura;
using Proclube.Fifa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Repositorio
{
    public class PosicaoRepository : BaseRepository<Posicao>, IDisposable
    {
        public PosicaoRepository(ProclubeContext context) : base(context)
        {

        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<Posicao> ObterPosicao(int PosicaoID)
        {

            Posicao Posicao = new Posicao();
            if (PosicaoID == 0)
                return Posicao;


            Posicao.PosicaoID = PosicaoID;

            Posicao.Descricao = "Atacante";


            return Posicao;

        }
    }
}
