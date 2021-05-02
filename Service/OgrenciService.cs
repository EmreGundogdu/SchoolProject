using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OgrenciService : IOgrenciService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OgrenciService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Ogrenci> AddAsync(Ogrenci entity)
        {
            await _unitOfWork.Ogrenciler.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<Ogrenci>> AddRangeAsync(IEnumerable<Ogrenci> entities)
        {
            await _unitOfWork.Ogrenciler.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public Task<IEnumerable<Ogrenci>> Find(Expression<Func<Ogrenci, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ogrenci>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> GetWithSinifByIdAsync(int ogrenciId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Ogrenci entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Ogrenci> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> SingleOrDefaultAsync(Expression<Func<Ogrenci, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Ogrenci Update(Ogrenci entity)
        {
            throw new NotImplementedException();
        }
    }
}
