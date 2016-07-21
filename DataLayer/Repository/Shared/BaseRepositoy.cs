using System;
using DataLayer.Entities;

namespace DataLayer.Repository.Shared
{
    public abstract class BaseRepositoy : IDisposable
    {

        public VerEmpleosConn DbConn;

        protected BaseRepositoy() {
            DbConn = new VerEmpleosConn();
        }

        protected BaseRepositoy(VerEmpleosConn dbConn)
        {
            DbConn = dbConn;
        }

        public void Dispose()
        {
            Dispose(true);

        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (!disposing)
                    return;

                DbConn?.Dispose();
            }
            catch (Exception ex)
            {
                //SharedLogger.LogError(ex);
            }
            finally
            {
                DbConn = null;
            }
        }
    }
}
