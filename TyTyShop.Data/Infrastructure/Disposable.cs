using System;

namespace TyTyShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposabled;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposabled && disposing)
            {
                DisposableCore();
            }
            isDisposabled = true;
        }

        // overide this to dispose custom object
        protected virtual void DisposableCore()
        {
        }
    }
}