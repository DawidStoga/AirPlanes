using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirPlane.Domain.DAL
{
    class EfConfiguration:DbConfiguration
    {
        public EfConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new MyDBExecutionStrategy());
        }
    }

    internal class MyDBExecutionStrategy : DbExecutionStrategy
    {
        protected override bool ShouldRetryOn(Exception exception)
        {
            bool retry = false;
            SqlException sqlException = exception as SqlException;
          if (sqlException!=null)
            {
                int[] ErrorsToRetry = { 1025, -2, 2601 };
            
                if (sqlException.Errors.Cast<SqlError> ().Any(x=>ErrorsToRetry.Contains(x.Number)))
                {
                    return true;
                }
                else
                {

                }
   
            }
          if(exception is TimeoutException)
            {
                return true;
            }
            return retry;
        }
    }
}
