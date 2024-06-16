using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Contract_Reporter.DataModelLayer.UnitOfWork
{
    public  interface IUnitOfwork

    { 
        void Dispose();
        void Save();

    }
}
