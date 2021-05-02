using Core.Models;
using Core.Repository;
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
    public class OgrenciService : Service<Ogrenci>, IOgrenciService
    {
        public OgrenciService(IUnitOfWork unitOfWork, IRepository<Ogrenci> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Ogrenci> GetWithSinifByIdAsync(int ogrenciId)
        {
            return await _unitOfWork.Ogrenciler.GetWithSinifByIdAsync(ogrenciId);
        }
    }
}
