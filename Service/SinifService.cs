using Core.Models;
using Core.Repository;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SinifService : Service<Sinif>, ISinifService
    {
        public SinifService(IUnitOfWork unitOfWork, IRepository<Sinif> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Sinif> GetWithStudentsByIdAsync(int sinifId)
        {
            return await _unitOfWork.Siniflar.GetWithStudentsByIdAsync(sinifId);
        }
    }
}
