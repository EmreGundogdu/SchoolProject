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
    public class OgrenciRepository : Repository<Ogrenci>, IOgrenciRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public OgrenciRepository(DbContext context) : base(context)
        {

        }
        public async Task<Ogrenci> GetWithSinifByIdAsync(int ogrenciId)
        {
            return await appDbContext.Ogrenciler.Include(x => x.Sinif).FirstOrDefaultAsync(x => x.Id == ogrenciId);
        }
    }
}
