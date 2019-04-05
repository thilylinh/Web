using System;

namespace TyTyShop.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        TyTyShopDbContext Init();
    }
}