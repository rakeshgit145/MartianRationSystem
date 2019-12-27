using DAL.Data;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ErrorLogsRepository : RepositoryBase<ErrorLog>
    {
        //Inherit the Repository base

        //Contructor implements Repository base
        public ErrorLogsRepository(DataContext context)
            : base(context)
        {

            //Check for context is defined
            if (context == null)
                throw new ArgumentException("Database context is not defined.");
        }
    }
}
