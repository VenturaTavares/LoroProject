﻿using Proclube.Fifa.Domain.Infraestrutura;
using Proclube.Fifa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proclube.Fifa.Domain.Repositorio
{
    public class ClubeContratandoRepository : BaseRepository<ClubeContratando>, IDisposable
    {
        public ClubeContratandoRepository(ProclubeContext context) : base(context)
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
