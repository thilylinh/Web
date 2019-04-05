namespace TyTyShop.Data.Infrastructure
{
    public class Dbfactory : Disposable, IDbFactory
    {
        private TyTyShopDbContext dbContext;

        public TyTyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TyTyShopDbContext());
        }

        protected override void DisposableCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}