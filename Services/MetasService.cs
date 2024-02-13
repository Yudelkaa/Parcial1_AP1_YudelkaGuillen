using Parcial1_AP1_YudelkaGuillen.Context;
using System.Linq.Expressions;
using Parcial1_AP1_YudelkaGuillen.Models;
using Microsoft.EntityFrameworkCore;
using Parcial1_AP1_YudelkaGuillen.Migrations;
using Parcial1_AP1_YudelkaGuillen.Models;
namespace Parcial1_AP1_YudelkaGuillen.Services
{
    public class MetasService
    {
        private readonly Contexto _contexto;
        public MetasService(Contexto contexto)
        {
            _contexto = contexto;

        }
        public async Task<bool> Insertar(metas meta)
        {
            _contexto.Metas.Add(meta);
            return await _contexto.SaveChangesAsync() > 0;

        }

        public async Task<bool> Modificar(metas metas)
        {
            if (metas.MetasId != 0)
            {
                _contexto.Update(metas);
                var modifico = await _contexto.SaveChangesAsync() > 0;
                return modifico;
            }
            else
            {
                return false;
            }
        }
  
        public async Task<bool> Guardar(metas metas)
        {
            if (metas.MetasId == 0)
                await _contexto.Metas.AddAsync(metas);
            else
                _contexto.Metas.Update(metas);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(metas metas)
        {
            var cantidad = await _contexto.Metas
                .Where(a => a.MetasId == metas.MetasId)
                .ExecuteDeleteAsync();
            return cantidad > 0;
        }

        public async Task<Models.metas?> Buscar(int aportesId)
        {
            return await _contexto.Metas.AsNoTracking().FirstOrDefaultAsync(a => a.MetasId == aportesId);
        }

        public async Task<bool> Existe(int aportesId)
        {
            return await _contexto.Metas!.AnyAsync(a => a.MetasId == aportesId);
        }

        public async Task<List<Models.metas>> Listar(Expression<Func<Models.metas, bool>> criterio)
        {
            return await _contexto.Metas.AsNoTracking().Where(criterio).ToListAsync();
        }
    }
}

