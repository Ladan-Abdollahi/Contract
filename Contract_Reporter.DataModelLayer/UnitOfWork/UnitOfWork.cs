using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Reporter.DataModelLayer.UnitOfWork
{
    public class UnitOfWork: IUnitOfwork<Contract_ReporterDbContext>, IDisposable 

    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Createtransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
