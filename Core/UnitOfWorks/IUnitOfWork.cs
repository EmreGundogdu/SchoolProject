using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IOgrenciRepository Ogrenciler { get; }
        ISinifRepository Siniflar { get; }
        IOgretmenRepository Ogretmenler { get; }
        Task CommitAsync();
        void Commit();
    }
}
