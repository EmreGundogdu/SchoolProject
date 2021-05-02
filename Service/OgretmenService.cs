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
    public class OgretmenService : Service<Ogretmen>, IOgretmenService
    {
        public OgretmenService(IUnitOfWork unitOfWork, IRepository<Ogretmen> repository) : base(unitOfWork, repository)
        {
        }
    }
}
