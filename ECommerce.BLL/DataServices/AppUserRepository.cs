using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.BLL.BaseServices;
//using ECommerce.Common.CryptoServices;
using ECommerce.DAL.Data.Entities;
using ECommerce.DAL.Model;

namespace ECommerce.BLL.DataServices
{
    public class AppUserRepository:GenericRepository<AppUser> 
    {
        public override void Insert(AppUser entity)
        {
            if (_context.Set<AppUser>().Any(x=>x.UserName == entity.UserName)==false)
            {
                entity.IsActive = false;
               //var password= CryptoService.PasswordHash(entity.PasswordHash);
               // entity.PasswordHash = password;
                _context.Set<AppUser>().Add(entity);
            }
        }
    }
}
