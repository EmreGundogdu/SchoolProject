using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class SinifRepository : Repository<Sinif>, ISinifRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public SinifRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Sinif> GetWithStudentsByIdAsync(int sinifId)
        {
            return await _appDbContext.Siniflar.Include(x => x.Ogrenciler).SingleOrDefaultAsync(x => x.Id == sinifId);
        }
    }
}
