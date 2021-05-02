using Core.Repository;
using Core.UnitOfWorks;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private OgrenciRepository _ogrenciRepository;
        private SinifRepository _sinifRepository;
        private OgretmenRepository _ogretmenRepository;

        public IOgrenciRepository Ogrenciler => _ogrenciRepository = _ogrenciRepository ?? new OgrenciRepository(_context);

        public ISinifRepository Siniflar => _sinifRepository = _sinifRepository ?? new SinifRepository(_context);

        public IOgretmenRepository Ogretmenler => _ogretmenRepository = _ogretmenRepository ?? new OgretmenRepository(_context);
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();  
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
