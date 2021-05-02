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
    public class OgretmenRepository : Repository<Ogretmen>,IOgretmenRepository
    {
        public OgretmenRepository(AppDbContext context) : base(context)
        {
        }
    }
}
